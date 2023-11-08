using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
            for (int i = 1; i < 10; i++)
            {
                groups[i] = "Группа "+ i.ToString();
            }
            PickGroups.ItemsSource = groups;
            LogoImage.Source = ImageSource.FromResource("KP_App.Images.Logo.png");
        }
        List<Model> schedule = new List<Model>();
        public async Task GetJsonAsync()
        {
            var uri = new Uri("file:///D:\\VS\\repos\\KP_App\\KP_App\\KP_App\\schedule\\schedule.json");
            HttpClient httpClient = new HttpClient();
            var responce = await httpClient.GetAsync(uri);

            if (responce.IsSuccessStatusCode)
            {
                var content = await responce.Content.ReadAsStringAsync();
                var json = content.ToString();
                var jsonObject = JObject.Parse(json);
                var date = jsonObject["date"];
                var days = jsonObject["days"];
                Debug.WriteLine(date);
            }
        }
    }
}