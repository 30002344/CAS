
using CASkiwicoffinclub.controler_folder;
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

namespace CASkiwicoffinclub
{
   
    public partial class AddAccount : ContentPage
    {
        //FirebaseHelper firebaseHelper = new FirebaseHelper();
        
        public AddAccount() 
        {
            InitializeComponent();
            //dataformAccount.DataObject = new AddAccountInfo();
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

        private async void AddCoffinBtn_Clicked(object sender, EventArgs e) 
        {
          
            await Model_Folder.FirebaseHolder.firebaseHelper.AddAccount(txtCustID.Text, txtFirstName.Text, txtLastName.Text, txtPhno.Text,  txtEmail.Text, txtAddress.Text);
            txtCustID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhno.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;

            await DisplayAlert("Success", "Person Added Successfully", "OK");

            App.Current.MainPage = new AddCoffin();
        }



        //dataformAccount.Commit();
        
     

        //private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        //{
        //    if (e.DataFormItem != null && e.DataFormItem.Name == "Email")
        //        (e.DataFormItem as DataFormTextItem).KeyBoard = Keyboard.Email;
        //}

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}