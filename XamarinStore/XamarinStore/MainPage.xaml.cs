using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private async void CheckUserAsync()
        {
            //Obtenemos los datos
            bool correcto = false;
            string name = "";
            string passwd = "";
            User user;
            //ObservableCollection<User> userList = new ObservableCollection<User>(await App.DataRepo.GetAllUsers());
            //user = userList.SingleOrDefault(t => t.Nick == name);
            name = txtNick.Text.ToString();
            passwd = txtPasswd.Text.ToString();
            //Comprobamos los datos
            user = await App.DataRepo.GetUserByName(name);

            if (user != null)
            {
                if (user.Password.Equals(passwd))
                {
                    //Si la password es correcta
                    //miramos el tipo
                    if (user.Type.Equals("User"))
                    {
                        ShowClientActivity("user");
                    }
                    else
                    {
                        ShowClientActivity("admin");
                    }
                }
            }
            else
            {
                //El usuario introducido no es válido
                correcto = false;
            }

        }

        private void ShowClientActivity(string v)
        {
            throw new NotImplementedException();
        }
    }
}
