using AppIE.Services.ServiceImplementation;
using AppIE.Services.ServiceInterface;
using AppIE.ViewModels.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppIE.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {

        private ILogInService _logInService;

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value;
                RaisePropertyChanged();
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value;
                RaisePropertyChanged();
            }
        }

        public ICommand LoginCommand => new Command(PulsaLogIn);

        public LogInViewModel()
        {
            _logInService = new LogInService();
        }

        async void PulsaLogIn()
        {
            if (Validate())
            {
                var result = await _logInService.LogIn(UserName, Password);

                if (result != null)
                {
                    //https://github.com/xamarin/Xamarin.Auth/wiki/Migrating-from-AccountStore-to-Xamarin.Essentials-SecureStorage
                    var json = JsonConvert.SerializeObject(result);

                    // Securely save the accounts for the given service
                    await SecureStorage.SetAsync("Usuario", json);

                    var accion = await Application.Current.MainPage.DisplayAlert("😉 Acceso exitoso", "Usted ha iniciado sesión, satisfactoriamente.", null, "✔ Aceptar");
                    if (!accion)
                    {
                        Application.Current.MainPage = new AppShell();
                    }
                }
                else
                {
                    //DisplayInvalidLoginPrompt();
                    await Application.Current.MainPage.DisplayAlert("😌 Error inicio de sesión", "Usuario o contraseña son incorrectos. Verifique por favor.", "✔ Aceptar");
                }
            }
        }

        bool Validate()
        {

            if (string.IsNullOrEmpty(UserName))
            {
                Application.Current.MainPage.DisplayAlert("😌 Validación", "Usuario no puede ser vació", "✔ Aceptar");
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                Application.Current.MainPage.DisplayAlert("😌 Validación", "Contraseña no puede ser vació", "✔ Aceptar");
                return false;
            }
            else if (Password.Length < 8)
            {
                Application.Current.MainPage.DisplayAlert("😌 Validación", "Contraseña debe tener 8 dígitos.", "✔ Aceptar");
                return false;
            }

            return true;
        }

    }
}
