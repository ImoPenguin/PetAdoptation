using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public abstract class User
    {
        //  PRIVATE Fields
        private string ID;
        private string password;
        private string name;
        private string phoneNo;
        private string email;
        private string address;


        //  PUBLIC Functions


        //
        // GETTERs & SETTERs
        //
        public string UserID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        //
        //  Other Functions
        //
        public void UpdateContactInfo(string phoneNo, string email, string address)
        {
            PhoneNo = phoneNo;
            Email = email;
            Address = address;
        }

    }
}
