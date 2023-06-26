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
	public partial class RegisterUser : ContentPage
	{
        UserRepository _userRepository = new UserRepository();
		public RegisterUser ()
		{
			InitializeComponent ();
		}

        private async void ButtonRegister_Clicked(object sender, EventArgs e)
        {
			string name = TxtName.Text;
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;
            string confirmPassword = TxtConfirmPassword.Text;
			if (String.IsNullOrEmpty(name))
			{
				await DisplayAlert("Warning", "Type name", "Ok");
				return;
			}
            if (String.IsNullOrEmpty(email))
            {
                await DisplayAlert("Warning", "Type email", "Ok");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                await DisplayAlert("Warning", "Type password", "Ok");
                return;
            }
            if (String.IsNullOrEmpty(confirmPassword))
            {
                await DisplayAlert("Warning", "Type Confirm password", "Ok");
                return;
            }
            if (password!=confirmPassword)
            {
                await DisplayAlert("Warning", "Password not match", "Ok");
                return;
            }
            bool isSave = await _userRepository.Register(email, name, password);
            if (isSave)
            {
                await DisplayAlert("Register user", "Registration completed", "Ok");
            }
            else
            {
                await DisplayAlert("Register user", "Registration failed", "Ok");
            }
            await Navigation.PushAsync(new LoginPage());
        }
    }
}