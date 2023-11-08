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
	public partial class MaterialsPage : ContentPage
	{
		public MaterialsPage ()
		{
			InitializeComponent ();
		}

        private async void TeacherPageButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new TeacherPage());
        }

        private async void GroupScheduleButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new GroupsSchedulePage());
        }

        private async void HomeworkPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeworkPage());
        }

        private async void AddMaterialButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddMaterialPage());
        }
    }
}