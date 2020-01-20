using Eduka.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Eduka.Services
{
    public class Auth : IAuth
    {
        private string base_url = "https://balmasic.000webhostapp.com/";
        public async Task<User> Login(string userid, string password)
        {
            string WowURL = base_url + "login";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "userid=" + userid + "&password=" + password;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != "false")
            {
                var json = JsonConvert.DeserializeObject<User>(result);
                return json;
            }

            return null;
        }

        public async Task<string> Register(string username, string password, string userclass)
        {
            string WowURL = base_url + "register";
            string DIRECT_POST_CONTENT_TYPE = "application/x-www-form-urlencoded";

            HttpClient client = new HttpClient();
            string postData = "student_password=" + password + "&student_name=" + username + "&student_class=" + userclass;

            StringContent content = new StringContent(postData, Encoding.UTF8, DIRECT_POST_CONTENT_TYPE);
            HttpResponseMessage response = await client.PostAsync(WowURL, content);

            string result = await response.Content.ReadAsStringAsync();


            if (result != null || result != "false")
            {

                return result;
            }

            return null;
        }
    }
}
