using AppIE.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        Random rand = new Random();

        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            routes.Add("home", typeof(HomePage));
            routes.Add("notas", typeof(CalificativoPage));
            routes.Add("bullying", typeof(ReportaBullyingPage));
            routes.Add("asiste", typeof(Views.AsistenciasPage));
            routes.Add("horario", typeof(Views.HorarioPage));
            routes.Add("comunica", typeof(Views.ComunicadoPage));
            routes.Add("merito", typeof(Views.MeritoDemeritoPage));
        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            // Cancel any back navigation
            //if (e.Source == ShellNavigationSource.Pop)
            //{
            //    e.Cancel();
            //}
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }

        private void ShellSection_ChildRemoved(object sender, ElementEventArgs e)
        {

        }
    }
}