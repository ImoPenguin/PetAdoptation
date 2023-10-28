using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public class Shelter
    {
        //  PRIVATE Fields
        private string storeID;
        private string address;

        //
        //  PUBLIC Functions
        //

        //  GETTERs & SETTERs
        public string StoreID
        {
            get { return storeID; }
            set { storeID = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        //  CONSTRUCTORS
        public Shelter(string storeID, string address)
        {
            StoreID = storeID;
            Address = address;
        }
    }
}
