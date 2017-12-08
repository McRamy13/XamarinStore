using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinStore.model;

namespace XamarinStore.admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminActivity : ContentPage
    {
        private User user;

        //cambiamos el constructor por defecto dejándolo como privado
        private AdminActivity()
        {
            InitializeComponent();
        }

        //El nuevo constructor va a recibir el usuario que le hemos pasado por BBDD
        public AdminActivity(User user)
        {
            this.user = user;
            InitializeComponent();
            LoadDataAsync();

        }

        private async Task LoadDataAsync()
        {
            List<Pedido> listPedidos = new List<Pedido>();
            ObservableCollection<Order> orderList = new ObservableCollection<Order>();

            //obtenemos la lista de los pedidos
            listPedidos = await App.DataRepo.GetAllPedidos();
            //vamos creando por cada elemento de la lista de pedidos un objeto order
            foreach (Pedido p in listPedidos)
            {
                User user = await App.DataRepo.GetUserById(p.IdUser);
                PcBox pcBox = await App.DataRepo.GetPcBoxById(p.IdCase);
                CPU cpu = await App.DataRepo.GetCPUById(p.IdCpu);
                GPU gpu = await App.DataRepo.GetGPUById(p.IdCpu);
                MotherBoard motherBoard = await App.DataRepo.GetMotherBoardId(p.IdMotherBoard);
                Ram ram = await App.DataRepo.GetRamById(p.IdRam);
                double price = p.Price;
                //agregamos la información a el objeto Order
                orderList.Add(new Order
                {
                    NomUser = user.Nick,
                    NomCase = pcBox.Name,
                    NomCpu = cpu.Name,
                    NomGpu = gpu.Name,
                    NomMotherBoard = motherBoard.Name,
                    NomRam = ram.Name,
                    FinalPrice = price
                });
            }
            //Una vez agregamos todos los datos, pasamos los datos a la colección.
            lstPedidos.ItemsSource = orderList;
        }
    }
}