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

        public AdminActivity()
        {
            InitializeComponent();
        }

        public AdminActivity(User user)
        {
            this.user = user;
        }
    }
}