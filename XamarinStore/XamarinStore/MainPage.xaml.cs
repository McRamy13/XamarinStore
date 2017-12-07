using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinStore.model;

namespace XamarinStore
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnLogin.Clicked += (sender, args) =>
            {
                CheckUserAsync();
            };
        }

        private async Task CheckUserAsync()
        {
            //Obtenemos los datos
            bool correcto = false;
            string user;
            string passwd;
            User data;


            user = txtUser.Text;
            passwd = txtPasswd.Text;
            //Comprobamos los datos
            data = await App.DataRepo.getUserByName(user);

            if(data != null)
            {
                if (data.Password.Equals(passwd))
                {
                    //Si la password es correcta
                    //miramos el tipo
                    if (data.Type.Equals("User"))
                    {
                        showClientActivity("user");
                    }
                    else
                    {
                        showClientActivity("admin");
                    }
                }
            }
            else
            {
                //El usuario introducido no es válido
            }

        }

        private void showClientActivity(string v)
        {
            throw new NotImplementedException();
        }
    }
}
