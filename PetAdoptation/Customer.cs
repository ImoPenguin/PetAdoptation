using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public class Customer : User
    {
        private List<string> petsID = new List<string>();
        private string assignedStaff_ID = "null";

        //  PUBLIC Functions

        //
        //  GETTERs & SETTERs
        //

        public List<string> PetsList
        {
            get { return petsID; }
            set { petsID = value; }
        }

        public string AssignedStaff_ID
        {
            get { return assignedStaff_ID; }
            set { assignedStaff_ID = value; }
        }

        //
        //  CONSTRUCTOR
        //
        public Customer(string ID, string password, string name, string phoneNo, string email, string address)
        {
            this.ID = ID;
            this.Password = password;
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.Address = address;
        }

        public Customer(string ID, string password, string name, string phoneNo, string email, string address, string assignedStaff)
        {
            this.ID = ID;
            this.Password = password;
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.Address = address;
            this.AssignedStaff_ID = assignedStaff;
        }

        //
        //  Other Functions
        //

        //  ADOPT Pets Function
        public void adoptPet(string petID)
        {
            PetsList.Add(petID);
        }

        //  REMOVE Pets Function
        public void removePet(string petID)
        {
            PetsList.Remove(petID);
        }

        //  View Assigned Staff Function
        public void viewAssignedStaff()
        {

        }

    }
}
