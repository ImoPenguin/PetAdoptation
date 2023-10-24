using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public class Manager : Staff
    {
        private List<string> staffList = new List<string>();

        //
        //  PUBLIC Functions
        //

        //  CONSTRUCTORS
        public Manager(string ID, string password, string name, string phoneNo, string email, string address, string workingStore_ID)
        {
            this.ID = ID;
            this.Password = password;
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.Address = address;
            this.WorkingStoreID = workingStore_ID;
            this.ManagerID = "null";
        }

        //  GETTERs & SETTERs
        public List<string> StaffList
        {
            get { return staffList; }
            set { staffList = value; }
        }

        //  OTHER Functions
        public void viewStaffList()
        {

        }

        public void addStaff(string staffID)
        {
            StaffList.Add(staffID);
        }

        public void removeStaff(string staffID)
        {
            StaffList.Remove(staffID);
        }
    }
}
