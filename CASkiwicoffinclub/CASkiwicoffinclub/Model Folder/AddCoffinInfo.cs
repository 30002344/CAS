using CASkiwicoffinclub.controler_folder;
using Firebase.Database;
using Firebase.Database.Query;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CASkiwicoffinclub.Model_Folder
{
    public class AddCoffinInfo
    {
    
        public AddCoffinInfo()//Constructor
        {  
        }

        //============Coffin Properties


        public bool Casket { get; set; }
        public bool Coffin { get; set; }
        public string CoffinID { get; set; }
        public string CustID { get; set; }//=====carried over from CustID from Accounts
        public bool DRlid { get; set; }
        public bool DeliveryNZ { get; set; }


        public bool Height1 { get; set; }
        public bool Height2 { get; set; }
        public bool Height3 { get; set; }
        public bool Height4 { get; set; }
        public bool Height5 { get; set; }


        public string CoffinHeight { get; set; } 

        public string CoffinSize { get; set; }

        public bool Mdf { get; set; }

        public bool Plywood { get; set; }

        public bool Pine { get; set; }

        public string UnderCoat { get; set; }

        public string Topcoat { get; set; }

        public string Spraypaint { get; set; }

        public string Woodstain { get; set; }

        public bool SRlid { get; set; }
        
        
        
        public bool SScrews { get; set; }

        public bool GScrews { get; set; }

        public bool SHandle { get; set; }

        public bool GHandle { get; set; }

        public bool WHandle { get; set; }

        public bool RHandle { get; set; }

        public bool Lining1 { get; set; }

        public bool Lining2 { get; set; }

        public bool Lining3 { get; set; }

        public bool Lining4 { get; set; }

        public bool Lining5 { get; set; }

        public bool Lining6 { get; set; }

        public string Customlining { get; set; }

        public string Extras { get; set; }

        public string Comments { get; set; }
        //=================================Delivery/storage

        public bool Stored { get; set; }

        public bool Pickup { get; set; }

        public bool RotoruaDel { get; set; }

        public bool NongotahaDel { get; set; }

        

        public string DelAddress { get; set; }

        public string DeliveryComments { get; set; }
    }
}
    //=============================================


