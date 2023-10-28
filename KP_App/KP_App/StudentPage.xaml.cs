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
    public partial class StudentPage : TabbedPage
    {
        public StudentPage ()
        {
            InitializeComponent();
            
            Logo1.Source = ImageSource.FromResource("KP_App.Images.Logo.png");
            Logo2.Source = ImageSource.FromResource("KP_App.Images.Logo.png");
            Logo3.Source = ImageSource.FromResource("KP_App.Images.Logo.png");
        }
    }
}