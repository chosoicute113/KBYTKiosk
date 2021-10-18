using KhaiBaoYTeKiosk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.API
{
    class LoginProcessor
    {
        public static async Task<User> LoadProcessor(string url, Account useraccount)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(useraccount);
            StringContent body_content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using (HttpResponseMessage response = await APIHelper.ApiClient.PostAsync(url, body_content))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    User user = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
                    return user;
                }
                else throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
