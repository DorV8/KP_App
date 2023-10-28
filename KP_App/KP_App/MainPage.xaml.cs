using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace KP_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LogoImage.Source = ImageSource.FromResource("KP_App.Images.Logo.png");
        }

        private async void ButtonEnterClick(object sender, EventArgs e)
        {
            if (LoginField.Text.ToUpper() == "СТУД" && PassField.Text.ToUpper() == "СТУД")
            {
                await Navigation.PushModalAsync(new StudentPage());
            }
            else if (LoginField.Text.ToUpper() == "ПРЕП" && PassField.Text.ToUpper() == "ПРЕП")
            {
                await Navigation.PushModalAsync(new TeacherPage());
            }
        }
        private async void ButtonGuestEnterClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GuestPage());
        }

        private async void Stud_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StudentPage());
        }

        private async void Teacher_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TeacherPage());
        }
    }
}
