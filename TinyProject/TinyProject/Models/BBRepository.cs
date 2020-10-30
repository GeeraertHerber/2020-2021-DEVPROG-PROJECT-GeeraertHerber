using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TinyProject.Models
{
    public static class BBRepository
    {


        private async static Task<HttpClient> GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            return httpClient;
        }

        public static String completeUrl(String adding)
        {
            String url = "https://www.breakingbadapi.com/api";
            
            return url + adding;
        }

        public static async Task<List<Character>> GetCharactersAsync()
        {
            
            using (HttpClient client = await GetClient())
            {
                
                String url = completeUrl("charachters");
                Debug.WriteLine(url);
                String json = await client.GetStringAsync(url);
                if (json != null)
                {
                    List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(json);
                    return characters;
                }
                else
                {
                    return null;
                }
                //json -> List<TrelloBoard>
            }
        }
    }
}
