﻿using AppIE.ViewModels;
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
    public partial class ReportaBullyingPage : ContentPage
    {
        public ReportaBullyingPage()
        {
            InitializeComponent();
            BindingContext = new ReportaBullyingViewModel();
        }
    }
}