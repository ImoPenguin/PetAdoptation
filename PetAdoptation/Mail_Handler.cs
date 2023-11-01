using System;
using System.Text.Json;
using System.Text.Json.Serialization; // Import this namespace for JsonPropertyName
using System.Net.Http;
using System.Threading.Tasks;

namespace PetAdoptation
{
    public class MailCheckResponse
    {
        [JsonPropertyName("format_valid")]
        public bool FormatValid { get; set; }

        [JsonPropertyName("mx_found")]
        public bool MxFound { get; set; }
    }

    public static class Mail_Handler
    {
        public static async Task<MailCheckResponse> Mail_Check(string mail2Check)
        {
            // Construct the API request URL
            string apiKey = "23dfb7cd67e9a249c69cb4e8b25a6cc3";

            using (var client = new HttpClient())
            {
                string apiUrl = $"http://apilayer.net/api/check?access_key={apiKey}&email={mail2Check}&smtp=1&format=1";

                try
                {
                    // Send the GET request
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("API request failed with status code: " + response.StatusCode);
                        return null; // Return null on failure
                    }

                    // Read and process the API response
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API Response: " + jsonResponse);

                    return JsonSerializer.Deserialize<MailCheckResponse>(jsonResponse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception during mail check: " + ex.Message);
                    return null; // Return null on exception
                }
            }
        }
    }
}
