using AppIE.Services.ServiceImplementation;
using AppIE.Services.ServiceInterface;
using AppIE.Views;
using CommonServiceLocator;
using System;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIE
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            //Registro Interface
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ILogInService, LogInService>();


            var unityServiceLocator = new UnityServiceLocator(unityContainer);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

            MainPage = new LogInPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
