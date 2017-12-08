using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinStore.model;

namespace XamarinStore.user
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserActivity : ContentPage
    {
        public User user;

        private UserActivity()
        {
            InitializeComponent();
        }

        public UserActivity(User user)
        {
            this.user = user;
            InitializeComponent();
            //método para cargar los datos
            //lblUserName.Text = "Bienvenido, " + user.Nick;
            LoadData();
        }

        private async Task  LoadData()
        {
            await LoadMotherBoardsAsync();
            await LoadCpuAsync();
            await LoadPcBoxAsync();
            await LoadGpuAsync();
            await LoadRamAsync();
           /* < Label Grid.Column = "0" Text = "{Binding NomUser}" />*/
        }

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