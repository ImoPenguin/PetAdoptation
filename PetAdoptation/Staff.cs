using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public class Staff : User
    {
        private List<string> assignedCus_ID = new List<string>();
        private string workingStore_ID;
        private string managerID;

        //
        //  PUBLIC Functions
        //

        //  CONSTRUCTORS
        public Staff() { }

        public Staff(string ID, string password, string name, string phoneNo, string email, string address, string workingStore_ID, string managerID)
        {
            this.ID = ID;
            this.Password = password;
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.Address = address;
            this.WorkingStoreID = workingStore_ID;
            this.ManagerID = managerID;

        }

        //  GETTERs & SETTERs
        public List<string> AssignedCustomer_List
        {
            get { return assignedCus_ID; }
            set { assignedCus_ID = value; }
        }

        public string WorkingStoreID
        {
            get { return workingStore_ID; }
            set { workingStore_ID = value; }
        }

        public string ManagerID
        {
            get { return managerID; }
            set { managerID = value; }
        }

        //  OTHER Functions
        public void assignCustomer(string customerID)
        {
            AssignedCustomer_List.Add(customerID);
        }

        public void removeCustomer(string customerID)
        {
            AssignedCustomer_List.Remove(customerID);
        }

        public void addPet()
        {

        }

        public void removePet(string petID)
        {
            //  Wait for SQL
        }
    }
}
