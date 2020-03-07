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


        public async Task<List<News>> GetNews()
        {
            string WowURL = base_url + "get/news";

            HttpClient client = new HttpClient();   
    
            HttpResponseMessage response = await client.GetAsync(WowURL);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null)
            {
                var json = JsonConvert.DeserializeObject<List<News>>(result);
                return json;
            }

            return null;
        }


        public async Task<List<Unit>> GetUnit(string topic_id)
        {
            string WowURL = base_url + "get/unit";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "topic_id=" + topic_id;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null)
            {
                var json = JsonConvert.DeserializeObject<List<Unit>>(result);
                return json;
            }

            return null;
        }

        public async Task<List<topic>> GetQuiz(string topic_id)
        {
            string WowURL = base_url + "get/quiz";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "topic_id=" + topic_id;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null)
            {
                var json = JsonConvert.DeserializeObject<List<topic>>(result);
                return json;
            }

            return null;
        }

        public async Task<List<Soalan>> GetQuizSet(string Quiz_Id)
        {
            string WowURL = base_url + "get/quiz/soalan";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "quiz_id=" + Quiz_Id;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null)
            {
                var json = JsonConvert.DeserializeObject<List<Soalan>>(result);
                return json;
            }

            return null;
        }

        public async Task<List<video>> GetVideo(string Topic_id)
        {
            string WowURL = base_url + "get/video/";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "topic_id=" + Topic_id;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null)
            {
                var json = JsonConvert.DeserializeObject<List<video>>(result);
                return json;
            }

            return null;
        }
    }
}
