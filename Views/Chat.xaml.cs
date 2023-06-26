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
	public partial class Chat : ContentPage
	{
		public Chat ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}