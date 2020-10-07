using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASkiwicoffinclub.Model_Folder;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CASkiwicoffinclub.View_Folder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormDisplay : ContentPage
	{
        GetCoffin GetCoffin = new GetCoffin();

        public FormDisplay ()
		{
           // BindingContext = GetCoffin;
			InitializeComponent ();
            LblCustID.Text = FirebaseHolder.firebaseHelper.Cid;
            LblCoffID.Text = FirebaseHolder.firebaseHelper.Casid;
            LblFname.Text = FirebaseHolder.firebaseHelper.Lastname;
            LblCoffCasket.Text = GetCoffin.coffcaskets;
        }

        private void HomeBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AccountBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void CoffinBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void MembersBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ReportsBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}