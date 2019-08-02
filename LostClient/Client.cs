using LostClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LostClient
{
    public class Client
    {
        private string url;

        public Client(string url)
        {
            this.url = url;
        }

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<Poteryashka>> GetPoteryashkasAsync(string surname = null,
                                                                         int? age = 0,
                                                                         DateTime? lostTo = null,
                                                                         DateTime? lostFrom = null)
        {
            var client = GetClient();
            var getUrl = url + "getPoteryashkas/?";
            if (!string.IsNullOrWhiteSpace(surname))
            {
                getUrl += $"surname={surname}&";
            }
            if (age.HasValue && age > 0)
            {
                getUrl += $"age={age.ToString()}&";
            }
            if (lostTo != null)
            {
                getUrl += $"lostto={lostTo?.ToShortDateString()}&";
            }
            if (lostFrom != null)
            {
                getUrl += $"lostfrom={lostFrom?.ToShortDateString()}";
            }

            var dataString = await client.GetStringAsync(getUrl);
            return JsonConvert.DeserializeObject<IEnumerable<Poteryashka>>(dataString);
        }

        public async Task<IEnumerable<Seen>> GetPoteryashkaSeenAsync(int id)
        {
            var client = GetClient();
            var getUrl = url + $"getpoteryashkaseen/{id.ToString()}";
            var dataString = await client.GetStringAsync(getUrl);
            return JsonConvert.DeserializeObject<IEnumerable<Seen>>(dataString);
        }

        public async Task<Poteryashka> AddPoteryashkaAsync(Poteryashka poteryashka)
        {
            var client = GetClient();
            var postUrl = url + "addPoteryashka/";
            var responce = await client.PostAsync(postUrl,
                new StringContent(
                    JsonConvert.SerializeObject(poteryashka),
                    Encoding.UTF8,
                    "application/json"));
            var dataString = await responce.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Poteryashka>(dataString);
        }

        public async Task UpdatePoteryashkaAsync(Poteryashka poteryashka)
        {
            if (poteryashka != null)
            {
                var client = GetClient();
                var postUrl = url + "updatepoteryashka/";
                var responce = await client.PutAsync(postUrl,
                    new StringContent(
                        JsonConvert.SerializeObject(poteryashka),
                        Encoding.UTF8,
                        "application/json"));
            }
        }

        public async Task HaveSeenPoteryashkaAsync(Seen seen)
        {
            var client = GetClient();
            var postUrl = url + "haveseenpoteryashka/";
            var responce = await client.PostAsync(postUrl,
                new StringContent(
                    JsonConvert.SerializeObject(seen),
                    Encoding.UTF8,
                    "application/json"));
        }

        public async Task PoteryashkaFoundAsync(FoundInfo info)
        {
            var client = GetClient();
            var postUrl = url + "poteryashkafound/";
            var responce = await client.PutAsync(postUrl,
                new StringContent(
                    JsonConvert.SerializeObject(info),
                    Encoding.UTF8,
                    "text/plain"));
        }
    }
}
