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
    public partial class LoginEmail : ContentPage
    {
        public LoginEmail()
        {
            InitializeComponent();
        }

        private async void btnNext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginCode());
        }
    }
}