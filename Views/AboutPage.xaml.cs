using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Threading;

namespace project2.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        CancellationTokenSource cts;

        private async void Geo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sympt1());
        }
    }
}