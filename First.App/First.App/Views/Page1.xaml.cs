﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace First.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : Xamarin.Forms.Shell
    {
        public Page1()
        {
            InitializeComponent();
        }
    }
}