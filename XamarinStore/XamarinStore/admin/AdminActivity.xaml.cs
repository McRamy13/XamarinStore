using System;
using System.Collections.Generic;
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

        }
    }
}