using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public static class SearchData
    {
        public static string animalType = string.Empty;
        public static string animalLocation = string.Empty;
        public static string animalAge = string.Empty;
        public static string animalGender = string.Empty;
        public static string vaccinated = string.Empty;
        public static string petID = string.Empty;

        public static void resetSearchData()
        {
            animalType = string.Empty;
            animalLocation = string.Empty;
            animalAge = string.Empty;
            animalGender = string.Empty;
            vaccinated = string.Empty;
            petID = string.Empty;
        }
    }
}