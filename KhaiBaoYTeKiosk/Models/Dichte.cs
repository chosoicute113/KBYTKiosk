using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.Models
{
    public class Dichte
    {
        public string id { get; set; }
        public string ten { get; set; }
        public int batbuoc { get; set; }
        public bool deleted { get; set; }
        public int trangthai { get; set; }
        public object created_at { get; set; }
        public object created_by { get; set; }
        public object deleted_at { get; set; }
        public object deleted_by { get; set; }
        public int updated_at { get; set; }
        public object updated_by { get; set; }
        public string tenkhongdau { get; set; }
        public string tentienganh { get; set; }
        public int thutu_uutien { get; set; }
        public int yeucau_cachly { get; set; }
        public int yeucau_xetnghiem { get; set; }
    }
}
