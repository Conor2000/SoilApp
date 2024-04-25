using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoilApp.Data
{
    public class FirebaseDataService
    {
        private readonly HttpClient _httpClient;
        private const string FirebaseUrl = "https://soil-data-6f4b6-default-rtdb.firebaseio.com/sensor_readings.json";

        public FirebaseDataService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<SoilTest>> GetSoilTestDataAsync()
        {
            var soilTestDataList = new List<SoilTest>();
            try
            {
                var response = await _httpClient.GetAsync(FirebaseUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<Dictionary<string, SoilTest>>(content);

                    if (data != null)
                    {
                        foreach (var item in data.Values)
                        {
                            soilTestDataList.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching soil test data: {ex.Message}");
            }

            return soilTestDataList;
        }
    }
}
