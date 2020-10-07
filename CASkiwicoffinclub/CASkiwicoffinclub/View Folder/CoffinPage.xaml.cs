using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CASkiwicoffinclub
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CoffinPage : ContentPage
	{
        public FirebaseClient firebase = new FirebaseClient($"https://caskiwicoffinclub.firebaseio.com/");
        public CoffinPage ()
		{
			InitializeComponent ();
		}
        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        private void AccountBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new AccountPage();
        }

        private void CoffinBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CoffinPage();
        }

        private void MembersBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MembersPage();
        }

        private void ReportsBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ReportsPage();
        }
    }
}