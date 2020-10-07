using CASkiwicoffinclub.controler_folder;
using CASkiwicoffinclub.Model_Folder;
using CASkiwicoffinclub.View_Folder;
using Firebase.Database;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CASkiwicoffinclub.View_Folder
{
   
	public partial class AddCoffin : ContentPage
	{
        CustIDTracker IDTracker = new CustIDTracker();
        //FirebaseHelper firebasehelper = new FirebaseHelper();

        

        public AddCoffin ()
		{
			InitializeComponent ();
           
          //BindingContext = Model_Folder.FirebaseHolder.firebaseHelper;
            //firebasehelper.Cid = firebasehelper.cc.CustID;
            txtCustID.Text = Model_Folder.FirebaseHolder.firebaseHelper.Cid;
          
        }
        //==========================================Nav Bar
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


        //================================Submit Coffin Details
        private async void SubmitBtn_Clicked(object sender, EventArgs e)
        {

            await Model_Folder.FirebaseHolder.firebaseHelper.AddCoffins(txtCoffinID.Text, txtCustID.Text, txtCoffin.IsChecked, txtCasket.IsChecked, txtHeight1.IsChecked, txtHeight2.IsChecked,
                txtHeight3.IsChecked, txtHeight4.IsChecked, txtHeight5.IsChecked, txtCustomheight.Text, txtSize.Text, txtMdf.IsChecked, txtPlywood.IsChecked, txtPine.IsChecked,
                txtUndercoat.Text, txtTopcoat.Text, txtSpraypaint.Text, txtWoodstain.Text, txtSRLid.IsChecked, txtDRLid.IsChecked, txtSScrews.IsChecked, txtGScrews.IsChecked,
                txtSHandle.IsChecked, txtGHandle.IsChecked, txtWHandle.IsChecked, txtRHandle.IsChecked,
                txtLining1.IsChecked, txtLining2.IsChecked, txtLining3.IsChecked, txtLining4.IsChecked, txtLining5.IsChecked, txtLining6.IsChecked, txtCustomLining.Text,
                txtExtras.Text, txtComments.Text, txtStored.IsChecked, txtPickup.IsChecked, txtRotoruaDel.IsChecked, txtNongotahaDel.IsChecked, txtDeliveryNZ.IsChecked,
                txtDelAddress.Text, txtDeliveryComments.Text);


            //blCustID.Text = firebaseHelper.GetCustID().ToString();
            txtCoffinID.Text = string.Empty;
            txtCustID.Text = string.Empty;
            txtCoffin.IsChecked = true;
            txtCasket.IsChecked = true;
            txtHeight1.IsChecked = true;
            txtHeight2.IsChecked = true;
            txtHeight3.IsChecked = true;
            txtHeight4.IsChecked = true;
            txtHeight5.IsChecked = true;
            txtCustomheight.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtMdf.IsChecked = true;
            txtPlywood.IsChecked = true;
            txtPine.IsChecked = true;
            txtUndercoat.Text = string.Empty;
            txtTopcoat.Text = string.Empty;
            txtSpraypaint.Text = string.Empty;
            txtWoodstain.Text = string.Empty;
            txtSRLid.IsChecked = true;
            txtDRLid.IsChecked = true;
            txtSScrews.IsChecked = true;
            txtGScrews.IsChecked = true;
            txtSHandle.IsChecked = true;
            txtGHandle.IsChecked = true;
            txtWHandle.IsChecked = true;
            txtRHandle.IsChecked = true;
            txtLining1.IsChecked = true;
            txtLining2.IsChecked = true;
            txtLining3.IsChecked = true;
            txtLining4.IsChecked = true;
            txtLining5.IsChecked = true;
            txtLining6.IsChecked = true;
            txtCustomLining.Text = string.Empty;
            txtExtras.Text = string.Empty;
            txtComments.Text = string.Empty;
            txtStored.IsChecked = true;
            txtPickup.IsChecked = true;
            txtRotoruaDel.IsChecked = true;
            txtNongotahaDel.IsChecked = true;
            txtDeliveryNZ.IsChecked = true;
            txtDelAddress.Text = string.Empty;
            txtDeliveryComments.Text = string.Empty;

            await DisplayAlert("Success", "Coffin Added Successfully", "OK");

            App.Current.MainPage = new FormDisplay();

            //dataformCoffin.Commit();
        }



        private void CancelBtn_Clicked(object sender, EventArgs e)
        {

        }

        //=======================Coffin Check box change codes == 
        private void TxtCoffin_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtCasket.IsChecked = false;

            }
        }
        private void TxtCasket_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtCoffin.IsChecked = false;
            }
        }

        private void TxtHeight1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtHeight2.IsChecked = false;
                txtHeight3.IsChecked = false;
                txtHeight4.IsChecked = false;
                txtHeight5.IsChecked = false;
            }
        }

        private void TxtHeight2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtHeight1.IsChecked = false;
                txtHeight3.IsChecked = false;
                txtHeight4.IsChecked = false;
                txtHeight5.IsChecked = false;
            }
        }

        private void TxtHeight3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtHeight1.IsChecked = false;
                txtHeight2.IsChecked = false;
                txtHeight4.IsChecked = false;
                txtHeight5.IsChecked = false;
            }
        }

        private void TxtHeight4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtHeight1.IsChecked = false;
                txtHeight2.IsChecked = false;
                txtHeight3.IsChecked = false;
                txtHeight5.IsChecked = false;
            }
        }

        private void TxtHeight5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtHeight1.IsChecked = false;
                txtHeight2.IsChecked = false;
                txtHeight3.IsChecked = false;
                txtHeight4.IsChecked = false;
            }
        }

        private void TxtMdf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtPlywood.IsChecked = false;
                txtPine.IsChecked = false;

            }
        }

        private void TxtPlywood_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtMdf.IsChecked = false;
                txtPine.IsChecked = false;

            }
        }

        private void TxtPine_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtMdf.IsChecked = false;
                txtPlywood.IsChecked = false;
                

            }
        }

        private void TxtSRLid_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtDRLid.IsChecked = false;
            }
        }
        private void TxtDRLid_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtSRLid.IsChecked = false;
            }
        }
        private void TxtSScrews_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtGScrews.IsChecked = false;

            }
        }

        private void TxtGScrews_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtSScrews.IsChecked = false;
            }
        }

        private void TxtSHandle_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtGHandle.IsChecked = false;
                txtWHandle.IsChecked = false;
                txtRHandle.IsChecked = false;

            }
        }
        private void TxtGHandle_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtSHandle.IsChecked = false;
                txtWHandle.IsChecked = false;
                txtRHandle.IsChecked = false;

            }
        }
        private void TxtWHandle_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtSHandle.IsChecked = false;
                txtGHandle.IsChecked = false;
                txtRHandle.IsChecked = false;

            }
        }

        private void TxtRHandle_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtSHandle.IsChecked = false;
                txtGHandle.IsChecked = false;
                txtWHandle.IsChecked = false;

            }
        }

        private void TxtLining1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtLining2.IsChecked = false;
                txtLining3.IsChecked = false;
                txtLining4.IsChecked = false;
                txtLining5.IsChecked = false;
                txtLining6.IsChecked = false;
            }

        }

        private void TxtLining2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtLining1.IsChecked = false;
                txtLining3.IsChecked = false;
                txtLining4.IsChecked = false;
                txtLining5.IsChecked = false;
                txtLining6.IsChecked = false;
            }
        }

        private void TxtLining3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtLining1.IsChecked = false;
                txtLining2.IsChecked = false;
                txtLining4.IsChecked = false;
                txtLining5.IsChecked = false;
                txtLining6.IsChecked = false;
            }
        }

        private void TxtLining4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtLining1.IsChecked = false;
                txtLining2.IsChecked = false;
                txtLining3.IsChecked = false;
                txtLining5.IsChecked = false;
                txtLining6.IsChecked = false;
            }
        }

        private void TxtLining5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtLining1.IsChecked = false;
                txtLining2.IsChecked = false;
                txtLining3.IsChecked = false;
                txtLining4.IsChecked = false;
                txtLining6.IsChecked = false;
            }
        }

        private void TxtLining6_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtLining1.IsChecked = false;
                txtLining2.IsChecked = false;
                txtLining3.IsChecked = false;
                txtLining4.IsChecked = false;
                txtLining5.IsChecked = false;
            }
        }

        private void TxtStored_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtPickup.IsChecked = false;
                txtRotoruaDel.IsChecked = false;
                txtNongotahaDel.IsChecked = false;
                txtDeliveryNZ.IsChecked = false;
            }
        }

        private void TxtPickup_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtStored.IsChecked = false;
                txtRotoruaDel.IsChecked = false;
                txtNongotahaDel.IsChecked = false;
                txtDeliveryNZ.IsChecked = false;
            }
        }

        private void TxtRotoruaDel_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtPickup.IsChecked = false;
                txtPickup.IsChecked = false;
                txtNongotahaDel.IsChecked = false;
                txtDeliveryNZ.IsChecked = false;
            }
        }
        private void TxtNongotahaDel_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtPickup.IsChecked = false;
                txtPickup.IsChecked = false;
                txtRotoruaDel.IsChecked = false;
                txtDeliveryNZ.IsChecked = false;
            }
        }

        private void TxtDeliveryNZ_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (true)
            {
                txtPickup.IsChecked = false;
                txtPickup.IsChecked = false;
                txtRotoruaDel.IsChecked = false;
                txtNongotahaDel.IsChecked = false;
                
            }
        }




    }
}