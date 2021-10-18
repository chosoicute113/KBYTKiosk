using KhaiBaoYTeKiosk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.API
{
    class QRProcessor
    {
        struct Message
        {
            public string message;
        }
        public static async Task<CheckinUser> LoadActivity(string url, string ID)
        {
            string URL = url + ID;
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var user = Newtonsoft.Json.JsonConvert.DeserializeObject<CheckinUser>(await response.Content.ReadAsStringAsync());
                    return user;
                }
                else
                {
                    Message errorMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<Message>((response.Content.ReadAsStringAsync().Result));
                    throw new Exception(errorMessage.message);
                }
            }

        }
    }
}
