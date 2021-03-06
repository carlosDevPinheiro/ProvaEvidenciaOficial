﻿using ProvaEvidencia.ViewModels;
using ProvaEvidencia.Views.Base;
using ProvaEvidencia.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProvaEvidencia
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Master = new Master();
            Detail = new NavigationPage(new Detail());
            App.MasterDetailNav = this;
        }
    }
}
