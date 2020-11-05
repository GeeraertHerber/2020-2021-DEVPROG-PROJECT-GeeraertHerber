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
            String url = "https://www.breakingbadapi.com/api/";
            
            return url + adding;
        }

        public static async Task<List<Character>> GetCharactersAsync()
        {
            
            using (HttpClient client = await GetClient())
            {
                
                String url = completeUrl("characters");
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
                
            }
        }
        public static async Task<List<Character>> GetOneCharacterAsync(int itemIndex)
        {

            using (HttpClient client = await GetClient())
            {

                String url = completeUrl($"characters/{itemIndex}");
                if(itemIndex == -1)
                {
                    url = completeUrl("character/random");
                }
                String json = await client.GetStringAsync(url);

                if (json != null)
                {
                    List<Character> character = JsonConvert.DeserializeObject<List<Character>>(json);
                    return character;
                }
                else
                {
                    return null;
                }
                
            }
        }

        public static async Task<List<Quote>> GetQuotes(int itemIndex)
        {

            using (HttpClient client = await GetClient())
            {

                String url = completeUrl($"quotes");
                if (itemIndex == -1)
                {
                    url = completeUrl("quote/random");
                }
                String json = await client.GetStringAsync(url);

                if (json != null)
                {
                    List<Quote> quote = JsonConvert.DeserializeObject<List<Quote>>(json);
                    return quote;
                }
                else
                {
                    return null;
                }
                
            }
        }
    }
}
