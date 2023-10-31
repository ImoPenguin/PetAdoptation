using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public static class Mail_Handler
    {
        public static async Task<bool> Mail_Check(string mail2Check)
        {
            string apiKey = "23dfb7cd67e9a249c69cb4e8b25a6cc3";

            using (var client = new HttpClient())
            {
                // Construct the API request URL
                string apiUrl = $"http://apilayer.net/api/check?access_key={apiKey}&email={mail2Check}&smtp=1&format=1";

                // Send the GET request
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                //  response List Array
                string[] responseList = new string[] { };
                if (response.IsSuccessStatusCode)
                {
                    // Read and process the API response
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(jsonResponse);

                    responseList = jsonResponse.Split(',');
                }
                else
                {
                    Console.WriteLine("API request failed with status code: " + response.StatusCode);
                }

                //  BOOL var to check if MAIL FORMAT IS VALID and MAIL DOMAIN EXIST
                bool formatValid = bool.Parse(responseList[4].Split(':')[1]);
                bool domainExisted = bool.Parse(responseList[5].Split(':')[1]);

                return (formatValid && domainExisted);
            }
        }
    }
}
