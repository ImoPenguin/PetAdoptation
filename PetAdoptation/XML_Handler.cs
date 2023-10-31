using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public static class XML_Handler
    {
        public static string getSolutionFolder()
        {
            //  FIND Solution File Path
            string assemblyLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

            // Assuming the solution file is in the parent directory of the executable
            string solutionDirectory = Directory.GetParent(assemblyDirectory).FullName;

            string binDirectory = Directory.GetParent(solutionDirectory).FullName;
            string solutionFolderPath = Directory.GetParent(Directory.GetParent(binDirectory).FullName).FullName;

            return solutionFolderPath;
        }

        public static string getUserFilePath()
        {
            //  FIND Solution File Path
            string assemblyLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

            // Assuming the solution file is in the parent directory of the executable
            string solutionDirectory = Directory.GetParent(assemblyDirectory).FullName;

            string binDirectory = Directory.GetParent(solutionDirectory).FullName;
            string solutionFolderPath = Directory.GetParent(Directory.GetParent(binDirectory).FullName).FullName;

            //  Load XML File
            string filePath = Path.Combine(solutionFolderPath, "Database\\User.xml");

            return filePath;
        }

        public static string getPetFilePath()
        {
            //  FIND Solution File Path
            string assemblyLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

            // Assuming the solution file is in the parent directory of the executable
            string solutionDirectory = Directory.GetParent(assemblyDirectory).FullName;

            string binDirectory = Directory.GetParent(solutionDirectory).FullName;
            string solutionFolderPath = Directory.GetParent(Directory.GetParent(binDirectory).FullName).FullName;

            //  Load XML File
            string filePath = Path.Combine(solutionFolderPath, "Database\\Pet.xml");

            return filePath;
        }

        ////////////////////////////////////
        //  HANDLING Customer XML Files  //
        //////////////////////////////////
        public static List<Customer> readCustomerData()
        {
            //  LOAD XML File
            XDocument xmlDoc = XDocument.Load(getUserFilePath());
            List<Customer> userList = new List<Customer>();
            Console.WriteLine(xmlDoc.ToString());

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
                            assignedStaff_ID = cus.Element("assignedStaff").Value
                        };

            //  ADD data to customers List
            foreach(var c in Customers)
            {
                userList.Add(new Customer(c.ID, c.Password, c.Name, c.phoneNo, c.Email, c.Address, c.assignedStaff_ID));
            }
            
            return userList;
        }
    
        public static void addCustomerData(Customer newCus)
        {
            //  LOAD XML File
            XDocument xmlDoc = XDocument.Load(getUserFilePath());

            //  Create new XML Element
            XElement newUser = new XElement("customer",
                new XElement("id", newCus.ID),
                new XElement("password", newCus.Password),
                new XElement("name", newCus.Name),
                new XElement("phoneNo", newCus.PhoneNo),
                new XElement("email", newCus.Email),
                new XElement("address", newCus.Address),
                new XElement("assignedStaff", newCus.AssignedStaff_ID)
                );

            //  ADD new Customer to XML File
            xmlDoc.Root.Add(newUser);
            xmlDoc.Save(getUserFilePath());
        }

        public static void editCustomerData(Customer newData)
        {
            XDocument xmlDoc = XDocument.Load(getUserFilePath());
            XElement customerElement = xmlDoc.Descendants("customer")
                .FirstOrDefault(cus => cus.Element("id")?.Value == newData.ID);

            if(customerElement != null)
            {
                //  UPDATE customer new DATA
                customerElement.Element("id").Value = newData.ID;
                customerElement.Element("password").Value = newData.Password;
                customerElement.Element("name").Value = newData.Name;
                customerElement.Element("phoneNo").Value = newData.PhoneNo;
                customerElement.Element("email").Value = newData.Email;
                customerElement.Element("address").Value = newData.Address;
                customerElement.Element("assignedStaff").Value = newData.AssignedStaff_ID;
                xmlDoc.Save(getUserFilePath());
            }
        }

        /////////////////////////////////
        //  HANDLING Staff XML Files  //
        ///////////////////////////////
        public static List<Staff> readStaffData()
        {
            //  LOAD XML Files
            XDocument xmlDoc = XDocument.Load(getUserFilePath());
            List<Staff> userList = new List<Staff>();

            //  GET all USER data
            var staffs = from staff in xmlDoc.Descendants("staff")
                         select new
                         {
                             ID = staff.Element("id").Value,
                             Password = staff.Element("password").Value,
                             Name = staff.Element("name").Value,
                             phoneNo = staff.Element("phoneNo").Value,
                             Email = staff.Element("email").Value,
                             Address = staff.Element("address").Value,
                             workingStore = staff.Element("workingStore").Value,
                             managerID = staff.Element("managerID").Value
                         };

            //  ADD Staffs Info to Staff List
            foreach ( var s in staffs )
            {
                userList.Add(new Staff(s.ID, s.Password, s.Name, s.phoneNo, s.Email, s.Address, s.workingStore, s.managerID));
            }
            
            return userList;
        }

        public static void addStaffData(Staff newStaff)
        {
            //  LOAD XML File
            XDocument xmlDoc = new XDocument(getUserFilePath());

            //  Create new XML Element
            XElement newUser = new XElement("staff",
                new XElement("id", newStaff.ID),
                new XElement("password", newStaff.Password),
                new XElement("name", newStaff.Name),
                new XElement("phoneNo", newStaff.PhoneNo),
                new XElement("email", newStaff.Email),
                new XElement("address", newStaff.Address),
                new XElement("workingStore", newStaff.WorkingStoreID),
                new XElement("managerID", newStaff.ManagerID)
                );

            //  ADD new Customer to XML File
            xmlDoc.Root.Add(newUser);
            xmlDoc.Save(getUserFilePath());
        }


        ///////////////////////////////////
        //  HANDLING Manager XML Files  //
        /////////////////////////////////
        public static List<Manager> readManagerData()
        {
            //  LOAD XML Files
            XDocument xmlDoc = XDocument.Load(getUserFilePath());
            List<Manager> userList = new List<Manager>();

            //  GET all USER data
            var managers = from manager in xmlDoc.Descendants("manager")
                         select new
                         {
                             ID = manager.Element("id").Value,
                             Password = manager.Element("password").Value,
                             Name = manager.Element("name").Value,
                             phoneNo = manager.Element("phoneNo").Value,
                             Email = manager.Element("email").Value,
                             Address = manager.Element("address").Value,
                             workingStore = manager.Element("workingStore").Value,
                         };

            //  ADD Staffs Info to Staff List
            foreach (var m in managers)
            {
                userList.Add(new Manager(m.ID, m.Password, m.Name, m.phoneNo, m.Email, m.Address, m.workingStore));
            }

            return userList;
        }

        public static void addManagerData(Manager newManager)
        {
            //  LOAD XML File
            XDocument xmlDoc = new XDocument(getUserFilePath());

            //  Create new XML Element
            XElement newUser = new XElement("manager",
                new XElement("id", newManager.ID),
                new XElement("password", newManager.Password),
                new XElement("name", newManager.Name),
                new XElement("phoneNo", newManager.PhoneNo),
                new XElement("email", newManager.Email),
                new XElement("address", newManager.Address),
                new XElement("workingStore", newManager.WorkingStoreID)
                );

            //  ADD new Customer to XML File
            xmlDoc.Root.Add(newUser);
            xmlDoc.Save(getUserFilePath());
        }
    
        public static List<Shelter> readShelterData()
        {
            //  LOAD XML Data
            XDocument xmlDoc = XDocument.Load("Shelter.xml");
            List<Shelter> shelterList = new List<Shelter>();

            //  GET all USER Data
            var shelters = from shelter in xmlDoc.Descendants("shelter")
                           select new
                           {
                               ID = shelter.Element("id").Value,
                               Address = shelter.Element("address").Value
                           };

            //  ADD Shelters to Shelter List
            foreach(var s in shelters)
            {
                shelterList.Add(new Shelter(s.ID, s.Address));
            }

            return shelterList;
        }



        ///////////////////////////////
        //  HANDLING Pet XML Files  //
        /////////////////////////////

        public static List<Pet> readPetData()
        {
            // Load the XML data from a file
            XDocument xmlDoc = XDocument.Load(getPetFilePath());
            List<Pet> petsList = new List<Pet>();

            var pets = from pet in xmlDoc.Descendants("pet")
                       select new
                       {
                           StoreID = pet.Element("storeID").Value,
                           ID = pet.Element("id").Value,
                           Type = pet.Element("type").Value,
                           Name = pet.Element("name").Value,
                           Color = pet.Element("color").Value,
                           Sex = pet.Element("sex").Value,
                           Breed = pet.Element("breed").Value,
                           Size = pet.Element("size").Value,
                           Vaccinated = bool.Parse(pet.Element("vaccinated").Value),
                           Microchip = bool.Parse(pet.Element("microchip").Value),
                           Desexed = bool.Parse(pet.Element("desexed").Value),
                           Wormed = bool.Parse(pet.Element("wormed").Value),
                           Description = pet.Element("description").Value,
                           Age = pet.Element("age").Value,
                           OwnerID = pet.Element("ownerID").Value
                       };

            Console.WriteLine("Testing");

            foreach (var pet in pets)
            {
                petsList.Add(new Pet(pet.StoreID, pet.ID, pet.Type, pet.Name, pet.Color, pet.Sex, pet.Breed, pet.Size,
                                    pet.Vaccinated, pet.Microchip, pet.Desexed, pet.Wormed, pet.Description, pet.Age, pet.OwnerID));
            }

            return petsList;
        }
    
        public static void addPetData(Pet pet)
        {
            XDocument xmlDoc = XDocument.Load(getPetFilePath());

            // Create a new pet element and add it to the XML
            XElement newPet = new XElement("pet",
                new XElement("storeID", pet.StoreID),
                new XElement("id", pet.ID),
                new XElement("name", pet.Name),
                new XElement("color", pet.Color),
                new XElement("sex", pet.Sex),
                new XElement("breed", pet.Breed),
                new XElement("size", pet.Size),
                new XElement("vaccinated", pet.Vaccinated),
                new XElement("microchip", pet.Microchip),
                new XElement("desexed", pet.Desexed),
                new XElement("wormed", pet.Wormed),
                new XElement("description", pet.Description),
                new XElement("age", pet.Age),
                new XElement("adopted", pet.Adopted),
                new XElement("ownerID", pet.OwnerID)
            );

            xmlDoc.Root.Add(newPet);
            xmlDoc.Save(getPetFilePath());
        }

        public static Pet findPetData(string findID)
        {
            List<Pet> petList = readPetData();

            //  FIND Pet with same ID
            foreach(Pet p in petList)
            {
                if(p.ID == findID)
                {
                    return p;
                }
            }

            //  ELSE Return null
            return null;
        }


        //  FUNCTION to find USERS
        public static Customer findCustomerAccount(string findID, string findPassword)
        {
            //  READ all CUSTOMERS DATA
            List<Customer> customers = readCustomerData();

            //  FIND Customers with same ID and PWD
            foreach(Customer c in customers)
            {
                if(c.ID == findID && c.Password == findPassword)
                {
                    return c;
                }
            }

            return null;
        }

        public static Staff findStaffAccount(string findID, string findPassword)
        {
            //  READ all STAFFS DATA
            List<Staff> staffs = readStaffData();

            //  FIND Staff with same ID and PWD
            foreach(Staff s in staffs)
            {
                if(s.ID == findID && s.Password == findPassword)
                {
                    return s;
                }
            }

            return null;
        }

        public static Manager findManagerAccount(string findID, string findPassword)
        {
            //  READ all MANAGERS DATA
            List<Manager> managers = readManagerData();

            //  FIND Manager with same ID and PWD
            foreach(Manager m in managers)
            {
                if(m.ID ==  findID && m.Password == findPassword) { return m; }
            }

            return null;
        }
    
        
    }
}
