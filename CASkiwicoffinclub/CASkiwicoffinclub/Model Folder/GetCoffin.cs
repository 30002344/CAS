using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASkiwicoffinclub.Model_Folder
{
    public class GetCoffin
    {
        public string coffcaskets;
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
     // public string Lastname;

        public string Lastnames { get; set; }  



        public GetCoffin()
        {

        }
        //===================================


        //========================
        public async Task<List<AddCoffinInfo>> GetCasket()
        {
            var list = (await FirebaseHolder.firebaseHelper.firebase
             .Child("Coffin").Child(FirebaseHolder.firebaseHelper.Casid.ToString())
             .OnceAsync<AddCoffinInfo>()).Select(item => new AddCoffinInfo
             {
                 CustID = item.Object.CustID,
                 Coffin = item.Object.Coffin,
                 Casket = item.Object.Casket,
                 Height1 = item.Object.Height1,
                 Height2 = item.Object.Height2,
                 Height3 = item.Object.Height3,
                 Height4 = item.Object.Height4,
                 Height5 = item.Object.Height5,
                 CoffinHeight = item.Object.CoffinHeight,
                 CoffinSize = item.Object.CoffinSize,
                 Mdf = item.Object.Mdf,
                 Plywood = item.Object.Plywood,
                 Pine = item.Object.Plywood,
                 UnderCoat = item.Object.UnderCoat,
                 Topcoat = item.Object.Topcoat,
                 Spraypaint = item.Object.Spraypaint,
                 Woodstain = item.Object.Woodstain,
                 SRlid = item.Object.SRlid,
                 DRlid = item.Object.DRlid,
                 SScrews = item.Object.SScrews,
                 GScrews = item.Object.GScrews,
                 SHandle = item.Object.SHandle,
                 GHandle = item.Object.GHandle,
                 WHandle = item.Object.WHandle,
                 RHandle = item.Object.RHandle,
                 Lining1 = item.Object.Lining1,
                 Lining2 = item.Object.Lining2,
                 Lining3 = item.Object.Lining3,
                 Lining4 = item.Object.Lining4,
                 Lining5 = item.Object.Lining5,
                 Lining6 = item.Object.Lining6,
                 Customlining = item.Object.Customlining,
                 Extras = item.Object.Extras,
                 Comments = item.Object.Comments,
                 Stored = item.Object.Stored,
                 Pickup = item.Object.Pickup,
                 RotoruaDel = item.Object.RotoruaDel,
                 NongotahaDel = item.Object.NongotahaDel,
                 DeliveryNZ = item.Object.DeliveryNZ,
                 DelAddress = item.Object.DelAddress,
                 DeliveryComments = item.Object.DeliveryComments

             }).ToList(); return list;
        }

        public async Task<List<AddAccountInfo>> GetCustomerAccount()
        {
            var fname = (await FirebaseHolder.firebaseHelper.firebase
            .Child("Coffin").Child(FirebaseHolder.firebaseHelper.Cid.ToString())
            .OnceAsync<AddAccountInfo>()).Select(item => new AddAccountInfo
            {
                FirstName = item.Object.FirstName,
                LastName = item.Object.LastName,
                PhoneNumber = item.Object.PhoneNumber,
                Email = item.Object.Email,
                Address = item.Object.Address
            }).ToList(); return fname;
        }
        //=====================================

        public async Task<AddCoffinInfo> GetCustomerID(string customerid)
        {
            var custid = await GetCasket();
            foreach (var item in custid)
            {
                Console.WriteLine($"{0}", item.CustID);
            }
            return null;
        }
        public string GetCustomerIDitem(string custidRequest)
        {
            custid = GetCustomerID(custidRequest).ToString();
            return custid;
        }
        //=============Customer First Name=============


        public async Task<AddAccountInfo> GetFname(string fname)
        {
            var firstname = await GetCustomerAccount(); 
            foreach (var item in firstname)
            {
                Console.WriteLine($"{0}", item.FirstName);
            }
            return null;
        }
        public string GetFirstName(string fnameRequest) 
        {
            Firstname = GetFname(fnameRequest).ToString();
            return Firstname; 
        }
        //==============Customer Last Name==================
        public async Task<AddAccountInfo> GetLname(string lname)
        {
            var Lastname = await GetCustomerAccount();
            foreach (var item in Lastname)
            {
                Console.WriteLine($"{0}", item.LastName);
            }
            return null;
        }
        public string GetLastName(string fnameRequest)
        {
            Lastnames = GetLname(fnameRequest).ToString();
            return Lastnames;
        }


        //============Coffin ID=============
        public async Task<AddCoffinInfo> GetCoffID(string coffid) 
        {
            var coffinid = await GetCasket();  
            foreach (var item in coffinid)
            {
                    Console.WriteLine($"{0}",item.CoffinID);
            }
            return null;
        }
        public string GetCoffinIDitem(string coffidRequest)  
        {
            coffid = GetCoffCasket(coffidRequest).ToString();
            return coffid;
        }

        //===============Casket of Coffin===========
        public async Task<AddCoffinInfo> GetCoffCasket(string coffcasket)
        {
            var casket = await GetCasket();
            foreach (var item in casket)
            {
                if (item.Coffin == true)
                {
                  Console.WriteLine( $"Coffin");
                }

                else
                {
                    Console.WriteLine($"Casket");
                }
            }
            return null;
        }
        public string Getcoffcasketitem(string coffcaskettRequest) 
        {
            coffcaskets = GetCoffCasket(coffcaskettRequest).ToString();
            return coffcaskets;
        }
        //======================Coffin Height=========
        public async Task<AddCoffinInfo> GetHeight(string coffinheight)  
        {
            var height = await GetCasket();
            foreach (var item in height)
            {
                if (item.Height1 == true)
                {
                    Console.WriteLine($"Height 1");
                }
                else if (item.Height2 == true)
                {
                    Console.WriteLine($"Height 2");
                }
                else if (item.Height3 == true)
                {
                    Console.WriteLine($"Height 2");
                }
                else if (item.Height4 == true)
                {
                    Console.WriteLine($"Height 2");
                }
                else if (item.Height5 == true)
                {
                    Console.WriteLine($"Height 2");
                }
                else 
                {
                    Console.WriteLine($"{0}", item.CoffinHeight);
                }
            }
            return null;
        }
        public string GetCoffHeight(string heightRequest) 
        {
            heights = GetHeight(heightRequest).ToString();
            return heights;
        }
        //=================Coffin Size===============
        public async Task<AddCoffinInfo> GetSize(string coffinSize)
        {
            var size = await GetCasket();
            foreach (var item in size)
            { Console.WriteLine($"{0}", item.CoffinSize); }
            return null;
        }
        public string GetCoffSize(string sizeRequest) 
        {
            Woods = GetSize(sizeRequest).ToString();
            return Woods;
        }
        //===============Coffin Wood Type =================
        public async Task<AddCoffinInfo> GetWood(string coffinwood)
        {
            var wood = await GetCasket();
            foreach (var item in wood)
            {
                if (item.Mdf == true)
                {
                    Console.WriteLine($"M D F");
                }
                else if (item.Plywood == true)
                {
                    Console.WriteLine($"PlyWood");
                }
                else
                {
                    Console.WriteLine($"Pine");
                }
            }
            return null;
        }
        public string GetCoffWood(string woodRequest)
        {
            Woods = GetWood(woodRequest).ToString();
            return Woods;
        }
        //====================Coffin Paints==========
        //--------Coffin TopCoat-----
        public async Task<AddCoffinInfo> GetTopCoat(string coffinTopCoat) 
        {
            var topcoat = await GetCasket();
            foreach (var item in topcoat)
            {
                Console.WriteLine($"{0}", item.Topcoat);
            }
            return null;
        }
        public string GetCoffTopCoat(string topcoatRequest) 

        { topcoat = GetTopCoat(topcoatRequest).ToString();
            return topcoat;
        }
        //----- Coffin UnderCoat----
        public async Task<AddCoffinInfo> GetUnderCoat(string coffinUnderCoat)
        {
            var undercoat = await GetCasket(); 
            foreach (var item in undercoat)
            {
                Console.WriteLine($"{0}", item.UnderCoat); 
            }
            return null;
        }
        public string GetCoffUnderCoat(string undercoatRequest) 

        {
            undercoat = GetUnderCoat(undercoatRequest).ToString(); 
            return undercoat;
        }
        //----------Coffin Spraypaint----------
        public async Task<AddCoffinInfo> GetSpraypaint(string coffinSpraypaint) 
        {
            var spraycoat = await GetCasket();
            foreach (var item in spraycoat) 
            {
                Console.WriteLine($"{0}", item.Spraypaint);
            }
            return null;
        }
        public string GetCoffSpraypaint(string spraypaintRequest) 

        {
            spraypaint = GetSpraypaint(spraypaintRequest).ToString();
            return spraypaint;
        }
        //----------Coffin WoodStain----------
        public async Task<AddCoffinInfo> GetWoodStain(string coffinWoodStain)
        {
            var woodstain = await GetCasket();
            foreach (var item in woodstain)
            {
                Console.WriteLine($"{0}", item.Woodstain);
            }
            return null;
        }
        public string GetCoffWoodStain(string woodstainRequest) 

        {
            woodstain = GetWoodStain(woodstainRequest).ToString();
            return woodstain;
        }

        //=============Coffin Lid===================
        public async Task<AddCoffinInfo> GetLid(string coffinlid)
        {
            var lid = await GetCasket();
            foreach (var item in lid)
            {
                if (item.SRlid == true)
                {
                    Console.WriteLine($"Single Raised Lid");
                }
                else
                {
                    Console.WriteLine($"Double Raised Lid");
                }
            }
            return null;
        }
        public string GetCoffLid(string lidRequest)
        {
            Lids = GetLid(lidRequest).ToString();
            return Lids;
        }

        //===========Coffin Screws and plate ==========
        public async Task<AddCoffinInfo> GetScrews(string coffinscrews)
        {
            var screw = await GetCasket();
            foreach (var item in screw)
            {
                if (item.SScrews == true)
                {
                    Console.WriteLine($"Silver Screws & Plates");
                }
                else
                {
                    Console.WriteLine($"Gold Screws & Plates");
                }
            }
            return null;
        }
        public string GetCoffScrews(string screwsRequest) 
        {
            Screws = GetScrews(screwsRequest).ToString();
            return Screws;
        }
        //===============Coffin Handles===================
        public async Task<AddCoffinInfo> GetHandles(string coffinhandles)
        {
            var handle = await GetCasket();
            foreach (var item in handle)
            {
                if (item.SHandle == true)
                {
                    Console.WriteLine($"Silver Handles");
                }
                else if (item.GHandle == true)
                {
                    Console.WriteLine($"Gold Handles");
                }
                else if (item.WHandle == true)
                {
                    Console.WriteLine($"Wood Handles");
                }
                else
                {
                    Console.WriteLine($"Rope Handles");
                }
            }
            return null;
        }
        public string GetCoffHandles(string handlesRequest)
        {
            Handles = GetHandles(handlesRequest).ToString();
            return Handles;
        }
        //=========Coffin Linings ===========
        public async Task<AddCoffinInfo> GetLinings(string coffinLinings)
        {
            var lining = await GetCasket();
            foreach (var item in lining)
            {
                if (item.Lining1 == true)
                {
                    Console.WriteLine($"Lining 1");
                }
                else if (item.Lining2 == true)
                {
                    Console.WriteLine($"Lining 2");
                }
                else if (item.Lining3 == true)
                {
                    Console.WriteLine($"Lining 3");
                }
                else if (item.Lining4 == true)
                {
                    Console.WriteLine($"Lining 4");
                }
                else if (item.Lining5 == true)
                {
                    Console.WriteLine($"Lining 5");
                }
                else if (item.Lining6 == true)
                {
                    Console.WriteLine($"Lining 6");
                }
                else
                {
                    Console.WriteLine($"{0}",item.Customlining);
                }
            }
            return null;
        }
        public string GetCoffLinings(string liningsRequest)
        {
            Linings = GetLinings(liningsRequest).ToString();
            return Linings;
        }
        //====================================
        public async Task<AddCoffinInfo> GetExtra(string coffinextra)
        {
            var extra = await GetCasket();
            foreach (var item in extra)
            {
                    Console.WriteLine($"{0}",item.Extras);
            }
            return null;
        }
        public string GetCoffExtra(string extraRequest)
        {
            Extra = GetExtra(extraRequest).ToString();
            return Extra;
        }
        //===========Comments ========
        public async Task<AddCoffinInfo> GetComments(string coffincomments)
        {
            var comments = await GetCasket();
            foreach (var item in comments)
            {
                Console.WriteLine($"{0}", item.Comments);
            }
            return null;
        }
        public string GetCoffComments(string CommentRequest)
        {
            Comment = GetComments(CommentRequest).ToString();
            return Comment;
        }
        //============Delivery and Storage=============
        public async Task<AddCoffinInfo> GetDelivery(string coffinDelivery) 
        {
            var delivering = await GetCasket(); 
            foreach (var item in delivering)
            {
                if (item.Stored == true)
                {
                    Console.WriteLine($"To be Stored");
                }
                else if (item.Pickup == true)
                {
                    Console.WriteLine($"To be Picked Up");
                }
                else if (item.RotoruaDel == true)
                {
                    Console.WriteLine($"Deliver Rotorua");
                }
                else if (item.NongotahaDel == true)
                {
                    Console.WriteLine($"Deliver Ngongotaha");
                }
                else
                {
                    Console.WriteLine($"Delivery New Zealand");
                }
            }
            return null;
        }
        public string GetCoffdelivery(string deliveryRequest) 
        {
            Delivery = GetDelivery(deliveryRequest).ToString();
            return Delivery;
        }
        //=============Delivery Address===========
        public async Task<AddCoffinInfo> GetDeliveryAddress(string coffinDeliveryAddress) 
        {
            var deliveryaddress = await GetCasket();
            foreach (var item in deliveryaddress)
            {
                    Console.WriteLine($"{0}",item.DelAddress);
            }
            return null;
        }
        public string GetCoffDeliveryAddress(string deliveryaddressRequest) 
        {
            DeliveryAddress = GetDelivery(deliveryaddressRequest).ToString();
            return DeliveryAddress;
        }
        //===============Delivery Comments===============
        public async Task<AddCoffinInfo> GetDeliveryComments(string coffinDeliveryComments) 
        {
            var deliveryComments = await GetCasket();
            foreach (var item in deliveryComments)
            {
                Console.WriteLine($"{0}", item.DeliveryComments);
            }
            return null;
        }
        public string GetCoffDeliveryComments(string deliverycommentsRequest)
        {
            DeliveryComment = GetDelivery(deliverycommentsRequest).ToString();
            return DeliveryComment;
        }

        

    }
}
