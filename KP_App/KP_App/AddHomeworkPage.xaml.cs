﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KP_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddHomeworkPage : ContentPage
	{
		public AddHomeworkPage ()
		{
			InitializeComponent ();
		}

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new HomeworkPage());
        }
    }
}