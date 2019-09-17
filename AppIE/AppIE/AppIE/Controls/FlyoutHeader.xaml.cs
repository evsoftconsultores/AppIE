using AppIE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIE.Controls
{
    public partial class FlyoutHeader : ContentView
    {
        FlyoutHeaderViewModel vm;
        public FlyoutHeader()
        {
            InitializeComponent();
            vm = new FlyoutHeaderViewModel();
            BindingContext = vm;
        }
    }
}