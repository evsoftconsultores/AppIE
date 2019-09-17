using AppIE.Model;
using AppIE.ViewModels.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace AppIE.ViewModels
{
    public class FlyoutHeaderViewModel : BaseViewModel
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                RaisePropertyChanged();
            }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                RaisePropertyChanged();
            }
        }

        public FlyoutHeaderViewModel()
        {
            IsBusy = true;
            SetearUsuaio();
            IsBusy = false;
        }

        async void SetearUsuaio()
        {
            var json = await SecureStorage.GetAsync("Usuario");
            try
            {
                // Try to return deserialized of user
                User user = JsonConvert.DeserializeObject<User>(json);

                Apellidos = user.Apellidos;
                Nombre = user.Nombre;
            }
            catch { 
            
            }

           
        }

    }
}
