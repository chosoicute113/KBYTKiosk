using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.Models
{
    public class User
    {
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public object updated_by { get; set; }
        public string id { get; set; }
        public string fullname { get; set; }
        public object accountName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public object type_user { get; set; }
        public int active { get; set; }
        public string donvi_id { get; set; }
        public Donvi donvi { get; set; }
        public int co_donvi_con { get; set; }
        public string token { get; set; }
        public List<string> roles { get; set; }
    }
}
