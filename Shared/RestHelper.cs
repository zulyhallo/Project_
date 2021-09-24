using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project_.Shared
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://reqres.in/api/";

        public static async Task<string> GetALL() // apiden verileri listelemek için 
        {


            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users")) // baseaddress+""
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }
        public static string BeautifyJson(string jsonStr) // dataları json formatta göstermek için 
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static async Task<string> Get(string id) // belirli bir id çekmek için 
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }
        public static async Task<string> Post(string name, string job)// idye göre eklemek için POST
        {

            var inputData = new Dictionary<string, string> // name ve job a göre ekleme yapmak için Dictionary<TKey,TValue> dize anahtarlarıyla boş dizeler oluşturur
            {
                 {  "name","name"},
                 {  "job", "job"}
            };
            var input = new FormUrlEncodedContent(inputData);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "users", input)) // users a inputData aldığı nesneyi eklemesi için 
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }

        public static async Task<string> Put(string id, string name, string job) // update için
        {

            var inputData = new Dictionary<string, string> // name ve job a göre ekleme yapmak için Dictionary<TKey,TValue> dize anahtarlarıyla boş dizeler oluşturur
            {
                 {  "name","name"},
                 {  "job", "job"}
            };
            var input = new FormUrlEncodedContent(inputData);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL + "users/" + id, input)) // listeyi idye göre input et 
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }



    }
}

