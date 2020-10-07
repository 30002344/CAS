using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASkiwicoffinclub.Model_Folder;
using Firebase.Database;
using Firebase.Database.Query;

namespace CASkiwicoffinclub.controler_folder
{
    class FirebaseHelper
    {
        public FirebaseClient firebase = new FirebaseClient("https://caskiwicoffinclub.firebaseio.com/");
        public Model_Folder.CurrentCustomer cc;
        public Model_Folder.CurrentCoffin Cc;
        public string CustomerID;
        public string CoffinID;
        public string Cid;
        public string Casid;
        
        //==========================
        public string Coffcaskets { get; set; }
        public string heights;
        public string Woods;
        private string topcoat;
        private string undercoat;
        private string spraypaint;
        private string woodstain;
        private string Lids;
        private string Screws;
        private string Handles;
        private string Linings;
        private string Extra;
        private string Comment;
        private string Delivery;
        private string DeliveryAddress;
        private string DeliveryComment;
        private string coffid;
        private string custid;
        private string Firstname;
        public string Lastname;

        public string CustID { get; private set; }

        //=============================
       

        //---------used to Alocate the current Customer ID -----------
        public async Task<CustIDTracker> GetCustID()
        {
            return await firebase.Child("IDs")
                .OnceSingleAsync<CustIDTracker>();
            
        }

        public async Task UpdateCustID(CustIDTracker idTracker)
        {
            await firebase
                .Child("IDs")
                .PutAsync(idTracker);
        }
        //==============================================================
        //----Used to Alocate Current Coffin ID ----------------
        public async Task<CustIDTracker> GetCoffinID()
        {
            return (await firebase.Child("IDs")
                .OnceSingleAsync<CustIDTracker>());
        }
        public async Task UpdateCoffinID(CustIDTracker idTracker)
        {
            await firebase
                .Child("IDs")
                .PutAsync(idTracker);
        }
        //=============================================================ADD Account====
        public async Task AddAccount(string custid ,string firstname, string lastname, string phonenumber, string email, string address)
        {
            CustIDTracker idTracker = await GetCustID();
            CustomerID = idTracker.Customerid.ToString();
            custid = CustomerID;
            await firebase
              .Child("Account").Child(idTracker.Customerid.ToString())
              .PutAsync(new AddAccountInfo() {CustID = custid, FirstName = firstname, LastName = lastname, PhoneNumber = phonenumber, Email = email, Address = address });
            //============
            //await CreateCurrentCustomer();
            Cid = CustomerID;
            Lastname = lastname;
            Firstname = firstname;
            //==========
            idTracker.Customerid++;//increase the cust id by one for the next customer
            await UpdateCustID(idTracker);
        }
        //=======================used to call the current ids
        private async Task CreateCurrentCustomer()
        {
            cc = new CurrentCustomer(CustomerID);
        }
        //====
        private async Task CreateCurrentCoffin()
        {
            Cc = new CurrentCoffin(CoffinID);
        }


        //===============================================================ADD Coffin
        public async Task AddCoffins(string cofid, string text, bool coffin, bool casket, bool height1, bool height2, bool height3, bool height4, bool height5,
            string coffinheight, string coffinsize, bool mdf, bool plywood, bool pine, string undercoat,
            string topcoat, string spraypaint, string woodstain, bool srlid, bool drlid, bool sscrews, bool gscrews, bool shandle, bool ghandle, bool whandle, bool rhandle,
            bool lining1, bool lining2, bool lining3, bool lining4, bool lining5, bool lining6, string customlining, string extras, string comments, bool strored, bool pickup,
            bool rotoruadel, bool nongotahadel, bool deliverynz, string deladdress, string deliverycomments)
        {
            CustIDTracker idTracker = await GetCoffinID();
            CoffinID = idTracker.Cofid.ToString();
            cofid = CoffinID;
            
 
            await firebase
             .Child("Coffin").Child(idTracker.Cofid.ToString())
             .PutAsync(new AddCoffinInfo()
             {
                 CoffinID = CoffinID,
                 CustID = CustomerID,
                 Coffin = coffin,
                 Casket = casket,
                 CoffinHeight = coffinheight,
                 CoffinSize = coffinsize,
                 Mdf = mdf,
                 Plywood = plywood,
                 Pine = pine,
                 UnderCoat = undercoat,
                 Topcoat = topcoat,
                 Spraypaint = spraypaint,
                 Woodstain = woodstain,
                 SRlid = srlid,
                 DRlid = drlid,
                 SScrews = sscrews,
                 GScrews = gscrews,
                 SHandle = shandle,
                 GHandle = ghandle,
                 WHandle = whandle,
                 RHandle = rhandle,
                 Lining1 = lining1,
                 Lining2 = lining2,
                 Lining3 = lining3,
                 Lining4 = lining4,
                 Lining5 = lining5,
                 Lining6 = lining6,
                 Customlining = customlining,
                 Extras = extras,
                 Comments = comments,
                 Stored = strored,
                 Pickup = pickup,
                 RotoruaDel = rotoruadel,
                 NongotahaDel = nongotahadel,
                 DeliveryNZ = deliverynz,
                 DelAddress = deladdress,
                 DeliveryComments = deliverycomments
             });
            //==============
            Casid = CoffinID;
            
        idTracker.Cofid++;//increse the id by one for the next coffin
            //==============
            await UpdateCoffinID(idTracker);
        }


        //===================================================Add Account custID to Coffin 

  
        public async Task<List<AddAccountInfo>> GetAccountID()
        {
            var list = (await firebase
            .Child("Account")
            .OrderByKey().LimitToLast(1)
            .OnceAsync<AddAccountInfo>()).Select(item => new AddAccountInfo
            {
                CustID = item.Object.CustID
            }).ToList();

            return list;
        }
        //=======
        public async Task<AddAccountInfo> GetCustID(string custId)

        {
            var accountid = await GetAccountID();
            foreach (var item in accountid)
            {
                if (item.CustID == custId)
                    

                await firebase
              .Child("Coffin").Child(item.ToString())
              .PutAsync(new AddCoffinInfo());
            }
            return null;

        }
        //=========
        public string GetCid(string custidRequest)
        {
            Cid = GetCustID(custidRequest).ToString();
            return Cid;
        }

        //=========================================Add Current Coffin ID to Coffin ================

        public async Task<List<AddCoffinInfo>> GetCasketID() 

        {
            var list = (await firebase
            .Child("Coffin")
            .OrderByKey().LimitToLast(1)
            .OnceAsync<AddCoffinInfo>()).Select(item => new AddCoffinInfo
            {
            CoffinID = item.Object.CoffinID
            }).ToList();
            return list;
            }

        public async Task<AddCoffinInfo> GetCasketIDs(string coffinId)  
        {
            var casketid = await GetCasketID();  
            foreach (var item in casketid)
            {
                if (item.CoffinID == coffinId)
                  await firebase
                  .Child("Coffin").Child(item.ToString())
                  .PutAsync(new AddCoffinInfo());
            }
            return null;
        }
        public string GetCasid(string casketidRequest)  
        {
            Casid = GetCasketIDs(casketidRequest).ToString();
            return Casid;
        }
        //public async Task<List<AddAccountInfo>> GetAccountInfo()
        //{

        //    return (await firebase
        //      .Child("Account")
        //      .OnceAsync<AddAccountInfo>()).Select(item => new AddAccountInfo
        //      {
        //          FirstName = item.Object.FirstName,
        //          LastName = item.Object.LastName,
        //          PhoneNumber = item.Object.PhoneNumber,
        //          Email = item.Object.Email,
        //          Address = item.Object.Address,

        //      }).ToList();
        //}

        


    }
    }
