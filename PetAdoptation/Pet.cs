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
        private string name;
        private string color;
        private string sex;
        private string breed;
        private string size;
        private bool vaccinated;
        private bool microchip;
        private string description;
        private string age;

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


        // Constructor
        public Pet(string storeID, string ID, string name, string color, string sex, string breed, string size, bool vaccinated, bool microchip, string description, string age)
        {
            this.storeID = storeID;
            this.ID = ID;
            this.name = name;
            this.color = color;
            this.sex = sex;
            this.breed = breed;
            this.size = size;
            this.vaccinated = vaccinated;
            this.microchip = microchip;
            this.description = description;
            this.age = age;
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
