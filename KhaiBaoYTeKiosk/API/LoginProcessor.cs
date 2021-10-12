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
        public static async Task<object> LoadActivity(string url, Account useraccount)
        {
            string Url = url;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(useraccount);
            StringContent body_content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using (HttpResponseMessage response = await APIHelper.ApiClient.PostAsync(Url, body_content)) ;
        }
    }
}
