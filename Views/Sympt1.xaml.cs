using Firebase.Database.Offline;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sympt1 : ContentPage
    {
        
        public Sympt1()
        {
            InitializeComponent();
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == 0)
            {
                _ = App.Database.SetItem(1);
            }
            if (selectedIndex == 1)
            {
                _ = App.Database.SetItem(0);
            }
            if (selectedIndex == 2)
            {
                _ = App.Database.SetItem(2);
               
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1200);
            await Navigation.PushAsync(new Result());
        }
    }
}