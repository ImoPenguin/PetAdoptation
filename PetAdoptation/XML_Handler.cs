using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public static class XML_Handler
    {
        public static List<Customer> readCustomerData()
        {
            //  Load XML File
            XDocument xmlDoc = XDocument.Load("Customer.xml");
            List<Customer> customersList = new List<Customer>();

            //  Get all USER data
            var Customers = from cus in xmlDoc.Descendants("customer")
                            select new
                        {
                            ID = cus.Element("id").Value,
                            Password = cus.Element("password").Value,
                            Name = cus.Element("name").Value,
                            phoneNo = cus.Element("phoneNo").Value,
                            Email = cus.Element("email").Value,
                            Address = cus.Element("address").Value,
                            assignedStaff_ID = cus.Element("assignedStaff_ID").Value
                        };

            //  ADD data to customers List
            foreach(var c in Customers)
            {
                customersList.Add(new Customer(c.ID, c.Password, c.Name, c.phoneNo, c.Email, c.Address, c.assignedStaff_ID));
            }
                        
            return customersList;
        }
    
        public static void addCustomerData(Customer newCus)
        {
            //  LOAD XML File
            XDocument xmlDoc = new XDocument("Customer.xml");

            //  Create new XML Element
            XElement newCustomer = new XElement("customer",
                new XElement("id", newCus.ID),
                new XElement("password", newCus.Password),
                new XElement("name", newCus.Name),
                new XElement("phoneNo", newCus.PhoneNo),
                new XElement("email", newCus.Email),
                new XElement("address", newCus.Address),
                new XElement("assignedStaff_ID", newCus.AssignedStaff_ID)
                );

            //  ADD new Customer to XML File
            xmlDoc.Root.Add(newCustomer);
            xmlDoc.Save("Customer.xml");
        }
    }
}
