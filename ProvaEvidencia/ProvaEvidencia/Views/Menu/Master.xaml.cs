﻿using ProvaEvidencia.ViewModels;
using ProvaEvidencia.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProvaEvidencia.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : BasePage
    {
        public Master()
        {
            InitializeComponent();
            BindingContext = new MasterViewModel();
        }
    }
}
