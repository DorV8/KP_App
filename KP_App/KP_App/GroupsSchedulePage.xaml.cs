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
	public partial class GroupsSchedulePage : ContentPage
	{
		public GroupsSchedulePage ()
		{
			InitializeComponent ();
		}

        private async void ButtonTeacherPage_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new TeacherPage());
        }

        private async void ButtonMaterials_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync (new MaterialsPage());
        }

        private async void ButtonHomework_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeworkPage());
        }
    }
}