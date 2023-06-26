using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        UserRepository _userRepository=new UserRepository();
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void BtnSignIn_Clicked(object sender, EventArgs e)
        {
            string email=TxtEmail.Text;
            string password=TxtPassword.Text;

            string token= await _userRepository.SignIn(email, password);
            if (!string.IsNullOrEmpty(token))
            {
                await Navigation.PushAsync(new AppShell());
            }
            else
            {
                await DisplayAlert("Sign In", "Sign In failed", "Ok");
            }
        }

        private async void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterUser());
        }
    }
}