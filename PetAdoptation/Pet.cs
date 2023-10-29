using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public class Pet
    {
        // Fields
        private string storeID;
        private string id;
        private string type;
        private string name;
        private string color;
        private string sex;
        private string breed;
        private string size;
        private bool vaccinated;
        private bool microchip;
        private string description;
        private string age;
        private bool adopted;

        private string ownerID;

        //
        //  GETTERs & SETTERs
        //
        public string StoreID
        {
            get { return storeID; }
            set { storeID = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public bool Vaccinated
        {
            get { return vaccinated; }
            set { vaccinated = value; }
        }

        public bool Microchip
        {
            get { return microchip; }
            set { microchip = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool Adopted
        {
            get { return adopted; }
            set { adopted = value; }
        }

        public string OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }


        // Constructor
        public Pet(string storeID, string ID, string type, string name, string color, string sex, string breed, string size, bool vaccinated, bool microchip, string description, string age, string ownerID)
        {
            this.storeID = storeID;
            this.ID = ID;
            this.type = type;
            this.name = name;
            this.color = color;
            this.sex = sex;
            this.breed = breed;
            this.size = size;
            this.vaccinated = vaccinated;
            this.microchip = microchip;
            this.description = description;
            this.age = age;
            this.ownerID = ownerID;

            if(ownerID == "")
            {
                adopted = false;
            }
            else
            {
                adopted = true;
            }
        }

        // PUBLIC Functions

        // Show details of the pet
        public void ViewPet()
        {
            // Implement the logic to display the details of the pet here
            //  WAIT FOR UI
        }

        // Update the pet's description
        public void UpdateDescription(string newDescription)
        {
            this.description = newDescription;
        }

        // Set the "vaccinated" property to true
        public void VaccinatePet()
        {
            this.vaccinated = true;
        }

        // Change the "StoreID" to a new store
        public void TransferToStore(string newStoreID)
        {
            this.storeID = newStoreID;
        }
    }
}
