
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CASkiwicoffinclub
{
    public class AddAccountInfo 
    {


        public AddAccountInfo()//Constructor
        {
        }
        //=======================Account Properties
        public string CustID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
 

    }
}
