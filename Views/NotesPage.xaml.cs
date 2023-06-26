using project2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowNotes();
        }
        private void ShowNotes()
        {
            itemsCollection.ItemsSource = App.Db.GetNotes();
        }
        private async void AddItemButton(object sender, EventArgs e)
        {
            string title = titleField.Text.Trim();
            string desc = descField.Text.Trim();
            string image = imageField.Text.Trim();
            int price = Convert.ToInt32(priceField.Text.Trim());
            if (title.Length < 5)
            {
                await DisplayAlert("Error", "Title min 5", "Ok");
                return;
            }

            Note note = new Note
            {
                Title = title,
                Desc = desc,
                Image = image,
                Price = price,
            };
            App.Db.SaveNote(note);
            ShowNotes();

            titleField.Text = "";
            descField.Text = "";
            imageField.Text = "";
            priceField.Text = "";
        }

        
    }
}