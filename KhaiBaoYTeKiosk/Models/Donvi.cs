using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.Models
{
    public class Donvi
    {
        public int created_at { get; set; }
        public string created_by { get; set; }
        public int updated_at { get; set; }
        public object updated_by { get; set; }
        public bool deleted { get; set; }
        public object deleted_by { get; set; }
        public object deleted_at { get; set; }
        public string id { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
        public object tentienganh { get; set; }
        public object sogiayphep { get; set; }
        public object ngaycapphep { get; set; }
        public string sodienthoai { get; set; }
        public string email { get; set; }
        public object website { get; set; }
        public object loaihinh_hoatdong { get; set; }
        public object lich_lamviec { get; set; }
        public object gioithieu { get; set; }
        public string nguoidaidien { get; set; }
        public string nguoidaidien_dienthoai { get; set; }
        public string hotline_2 { get; set; }
        public object thumbnail_url { get; set; }
        public object banner_url { get; set; }
        public object logo_url { get; set; }
        public object logo_text { get; set; }
        public object color { get; set; }
        public object domain { get; set; }
        public string xaphuong_id { get; set; }
        public string quanhuyen_id { get; set; }
        public string tinhthanh_id { get; set; }
        public object quocgia_id { get; set; }
        public string diachi { get; set; }
        public string tuyendonvi_id { get; set; }
        public string captren_id { get; set; }
        public string captren_name { get; set; }
        public bool active { get; set; }
        public bool xetnghiem { get; set; }
        public bool tiemchung_vacxin { get; set; }
        public bool dongbo_tiemchung { get; set; }
        public bool chamsoc_suckhoe_tainha { get; set; }
        public bool dat_hen { get; set; }
        public bool sms_dat_hen { get; set; }
        public bool dat_hen_online { get; set; }
        public bool kham_luu_dong { get; set; }
        public string tenkhongdau { get; set; }
        public string token { get; set; }
    }
}
