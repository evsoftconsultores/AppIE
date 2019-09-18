using AppIE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIE.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComunicadoPage : ContentPage
    {
        ComunicadoViewModel vm;
        public ComunicadoPage()
        {
            InitializeComponent();
            BindingContext = vm = new ComunicadoViewModel();
        }

        /*protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);
            collectionView.ItemsSource = (BindingContext as ComunicadoViewModel).Comunicados;

        }*/
    }
}