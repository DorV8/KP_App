using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KP_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TeacherPage : ContentPage
	{
		public TeacherPage ()
		{
			InitializeComponent ();
			LogoImage.Source = ImageSource.FromResource("KP_App.Images.Logo.png");
			Rasp.Source = ImageSource.FromResource("KP_App.Images.Example.png");
		}

        private async void ButtonGroupSchedule_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new GroupsSchedulePage ());
        }

        private async void ButtonMaterials_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MaterialsPage());
        }

        private async void ButtonHomework_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeworkPage());
        }

        private void ButtonNotification_Clicked(object sender, EventArgs e)
        {
        }
    }
}