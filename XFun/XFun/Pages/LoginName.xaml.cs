﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFun.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginName : ContentPage
    {
        public LoginName()
        {
            InitializeComponent();
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}