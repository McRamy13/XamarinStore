using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinStore.admin;
using XamarinStore.model;
using XamarinStore.user;

namespace XamarinStore
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// El constructor inicializa los componentes y gestiona los eventos
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            btnLogin.Clicked += (sender, args) =>
            {
                CheckUserAsync();
            };
        }

        /// <summary>
        /// Comprueba que el usuario exista en la BBDD y sea correcto
        /// </summary>
        /// <remarks>
        /// Recogemos los datos introducidos en los campos de texto. Una vez
        /// recogidos los datos, comprobamos que en la BBDD haya un usuario con ese
        /// nombre. En ese caso, comprobamos si la contraseña es igual.
        /// Si los datos son correctos, abrimos la actividad del usuario o el administrador
        /// en función del tipo de usuario.
        /// </remarks>
        private async void CheckUserAsync()
        {
            //Obtenemos los datos
            bool correcto = false;
            string name = "";
            string passwd = "";
            User user;
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
                    if (user.Tipo.Equals("User"))
                    {
                        await ShowClientActivityAsync("user", user);
                    }
                    else
                    {
                        await ShowClientActivityAsync("admin", user);
                    }
                }
            }
            else
            {
                //El usuario introducido no es válido
                correcto = false;
            }

        }

        /// <summary>
        /// Método para llamar a las distintas actividades
        /// </summary>
        /// <param name="userType">Tipo de usuario para llamar a la actividad</param>
        /// <param name="user">Objeto usuario que ha llamado a la actividad</param>
        private async Task ShowClientActivityAsync(string userType, User user)
        {
            switch (userType)
            {
                case "user":
                    await Navigation.PushModalAsync(new UserActivity(user));
                    break;
                case "admin":
                    await Navigation.PushModalAsync(new AdminActivity(user));
                    break;
            }
        }
    }
}
