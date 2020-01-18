using Eduka.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Eduka.Services
{
    public class RestApi : IRestApi
    {
        private string base_url = "https://balmasic.000webhostapp.com/";
        public async Task<List<Peta>> GetPeta(string topic_id)
        {
            string WowURL = base_url + "get/peta";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "topic_id=" + topic_id;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null)
            {
                var json = JsonConvert.DeserializeObject<List<Peta>>(result);
                return json;
            }

            return null;
        }

    }
}
