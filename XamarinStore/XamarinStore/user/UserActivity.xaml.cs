using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinStore.model;
using XamarinStore.utils;

namespace XamarinStore.user
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserActivity : ContentPage
    {
        public User user;
        public Pedido order;

        private UserActivity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que tendrá como parámetro el usuario que viene de la otra
        /// actividad
        /// </summary>
        /// <remarks>
        /// El constructor está sobrecargado. el otro está puesto en privado para que no sea
        /// accesible y se llame a este cada vez que queramos iniciar la actividad.
        /// </remarks>
        /// <param name="user">Usuario que llega de la otra actividad</param>
        public UserActivity(User user)
        {
            this.user = user;
            InitializeComponent();
            //método para cargar los datos
            lblUserName.Text = "Bienvenido, " + user.Nick;
            btnAccept.Clicked += async (sender, args) =>
            {
                await AcceptData();
            };

            btnConfirm.Clicked += async (sender, args) =>
            {
                await ConfirmData();
            };
            LoadData();
        }

        /// <summary>
        /// Cada vez que pulsemos en ConfirmData, insertamos
        /// un nuevo pedido.
        /// </summary>
        /// <remarks>
        /// Se inserta un pedido si el objeto order no es nulo 
        /// </remarks>
        private async Task ConfirmData()
        {
            if (order != null)
            {
                await App.DataRepo.AddNewOrderAsync(order);
            }
        }

        /// <summary>
        /// El método acceptData creará una lista de productos
        /// y asignará esa lista a la lista para poder visualizar
        /// el detalle del pedido
        /// </summary>
        /// <remarks>
        /// Usando una observable collection, vamos a ir rellenando los datos
        /// Por otra parte, vamos a asignar a la variable order el Pedido.
        /// </remarks>
        /// <returns></returns>
        private async Task AcceptData()
        {
            //creamos una lista de objetos y la asignamos
            ObservableCollection<Producto> productList = new ObservableCollection<Producto>();

            //obtenemos todos los datos de los productos
            if (pickerCpu.SelectedItem != null && pickerGpu.SelectedItem != null && pickerMotherBoard.SelectedItem != null
                && pickerPcBox.SelectedItem != null && pickerRam.SelectedItem != null)
            {

                CPU cpu = (CPU)pickerCpu.SelectedItem;
                GPU gpu = (GPU)pickerGpu.SelectedItem;
                MotherBoard board = (MotherBoard)pickerMotherBoard.SelectedItem;
                PcBox box = (PcBox)pickerPcBox.SelectedItem;
                Ram ram = (Ram)pickerRam.SelectedItem;

                double total;

                //creamos los productos
                productList.Add(new Producto { ProductName = cpu.Name, Price = cpu.Price });
                productList.Add(new Producto { ProductName = gpu.Name, Price = gpu.Price });
                productList.Add(new Producto { ProductName = board.Name, Price = board.Price });
                productList.Add(new Producto { ProductName = box.Name, Price = box.Price });
                productList.Add(new Producto { ProductName = ram.Name, Price = ram.Price });

                //pasamos la lista al listView
                lstPedidos.ItemsSource = productList;
                //calculamos el total
                total = OperationUtils.GetTotalPrice(cpu, gpu, board, box, ram);
                lblTotal.Text = total.ToString();
                order = new Pedido
                {
                    IdCase = box.IdCase,
                    IdCpu = cpu.IdCpu,
                    IdGpu = gpu.IdGpu,
                    IdMotherBoard = board.IdMotherBoard,
                    IdRam = ram.IdRam,
                    IdUser = user.IdUser,
                    Price = total
                };
            }
        }

        /// <summary>
        /// Método que llamará a los distintos métodos
        /// para leer datos.
        /// </summary>
        private async Task LoadData()
        {
            await LoadMotherBoardsAsync();
            await LoadCpuAsync();
            await LoadPcBoxAsync();
            await LoadGpuAsync();
            await LoadRamAsync();
            /* < Label Grid.Column = "0" Text = "{Binding NomUser}" />*/
        }

        /// <summary>
        /// Método que rellena el picker de memorias Ram
        /// </summary>
        private async Task LoadRamAsync()
        {
            List<Ram> ramList = new List<Ram>();
            ObservableCollection<Ram> list = new ObservableCollection<Ram>();

            ramList = await App.DataRepo.GetAllRam();

            foreach (Ram ram in ramList)
            {
                list.Add(ram);
            }
            pickerRam.ItemsSource = list;
        }

        /// <summary>
        /// Método que rellena el picker de GPU
        /// </summary>
        private async Task LoadGpuAsync()
        {
            List<GPU> gpuList = new List<GPU>();
            ObservableCollection<GPU> list = new ObservableCollection<GPU>();

            gpuList = await App.DataRepo.GetAllGpu();

            foreach (GPU gpu in gpuList)
            {
                list.Add(gpu);
            }
            pickerGpu.ItemsSource = list;
        }


        /// <summary>
        /// Método que rellena el picker de cajas de ordenador
        /// </summary>
        private async Task LoadPcBoxAsync()
        {
            List<PcBox> pcBoxList = new List<PcBox>();
            ObservableCollection<PcBox> list = new ObservableCollection<PcBox>();

            pcBoxList = await App.DataRepo.GetAllCases();

            foreach (PcBox box in pcBoxList)
            {
                list.Add(box);
            }
            pickerPcBox.ItemsSource = list;
        }

        /// <summary>
        /// Método que rellena el picker de CPU
        /// </summary>
        private async Task LoadCpuAsync()
        {
            List<CPU> cpuList = new List<CPU>();
            ObservableCollection<CPU> list = new ObservableCollection<CPU>();

            cpuList = await App.DataRepo.GetAllCpu();

            foreach (CPU cpu in cpuList)
            {
                list.Add(cpu);
            }
            pickerCpu.ItemsSource = list;
        }

        /// <summary>
        /// Método que rellena el picker de placas base
        /// </summary>
        private async Task LoadMotherBoardsAsync()
        {
            List<MotherBoard> motherList = new List<MotherBoard>();
            ObservableCollection<MotherBoard> list = new ObservableCollection<MotherBoard>();

            motherList = await App.DataRepo.GetAllMotherBoards();

            foreach (MotherBoard mother in motherList)
            {
                list.Add(mother);
            }
            pickerMotherBoard.ItemsSource = list;
        }
    }
}