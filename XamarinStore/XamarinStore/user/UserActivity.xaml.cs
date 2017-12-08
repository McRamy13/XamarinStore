using System;
using System.Collections.Generic;
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
        private User user;

        private UserActivity()
        {
            InitializeComponent();
        }

        public UserActivity(User user)
        {
            this.user = user;
        }
    }
}