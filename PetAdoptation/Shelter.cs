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
        private List<string> staffRoster;
        private List<string> petList;

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

        public List<string> StaffList
        {
            get { return staffRoster; }
            set { staffRoster = value; }
        }

        public List<string> PetList
        {
            get { return petList; }
            set { petList = value; }
        }

        //  CONSTRUCTORS
        public Shelter(string storeID, string address, List<string> staffList, List<string> petList)
        {
            StoreID = storeID;
            Address = address;
            StaffList = staffList;
            PetList = petList;
        }

        //  OTHER Functions
        public void addStaff(string staffID)
        {
            StaffList.Add(staffID);
        }

        public void removeStaff(string staffID)
        {
            StaffList.Remove(staffID);
        }

        public void addPet(string petID)
        {
            PetList.Add(petID);
        }

        public void removePet(string petID)
        {
            PetList.Remove(petID);
        }
    }
}
