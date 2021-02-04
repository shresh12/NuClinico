using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NuClinico
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());

        }
        public async void Navigate_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dashboard());

        }
    }
}
