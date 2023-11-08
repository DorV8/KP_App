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
	public partial class HomeworkPage : ContentPage
	{
		public HomeworkPage ()
		{
			InitializeComponent ();
		}

        private async void ButtonAddHomework_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync (new AddHomeworkPage ());
        }

        private async void ButtonMaterials_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MaterialsPage());
        }

        private async void TeacherPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TeacherPage());
        }

        private async void GroupScheduleButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GroupsSchedulePage());
        }
    }
}