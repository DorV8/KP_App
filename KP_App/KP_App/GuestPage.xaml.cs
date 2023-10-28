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
    public partial class GuestPage : ContentPage
    {
        public GuestPage()
        {
            InitializeComponent();
            string[] groups = new string[10];
            for (int i = 0; i < 10; i++)
            {
                groups[i] = "Группа "+ i.ToString();
            }
            PickGroups.ItemsSource = groups;
        }
    }
}