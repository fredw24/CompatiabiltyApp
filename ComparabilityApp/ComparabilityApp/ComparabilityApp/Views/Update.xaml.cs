﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComparabilityApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Update : ContentPage
	{
		public Update ()
		{
			InitializeComponent ();
		}

        public async void Updated(object sender, System.EventArgs e)
        {
            Console.WriteLine();
            await Navigation.PushAsync(new MainPage());
        }
	}
}