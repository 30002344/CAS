using System;
using System.Collections.Generic;
using System.Text;

namespace CASkiwicoffinclub.Model_Folder
{
    class FirebaseHolder
    {
        public static controler_folder.FirebaseHelper firebaseHelper = new controler_folder.FirebaseHelper();
        //used to save the current data so its not lost on close of firebasehelper
    }
}
