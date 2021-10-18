using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaiBaoYTeKiosk.Models
{
    public class CheckinUser
    {
        public int created_at { get; set; }
        public object created_by { get; set; }
        public int updated_at { get; set; }
        public object updated_by { get; set; }
        public bool deleted { get; set; }
        public object deleted_by { get; set; }
        public object deleted_at { get; set; }
        public string id { get; set; }
        public string uid { get; set; }
        public object nguoidan_id { get; set; }
        public string stt { get; set; }
        public string qrcode { get; set; }
        public int loai_khaibao { get; set; }
        public object ma_benh_nhan { get; set; }
        public string so_dien_thoai { get; set; }
        public string ten { get; set; }
        public string tenkhongdau { get; set; }
        public int gioi_tinh { get; set; }
        public int ngaysinh { get; set; }
        public int namsinh { get; set; }
        public string xaphuong_id { get; set; }
        public Xaphuong xaphuong { get; set; }
        public string quanhuyen_id { get; set; }
        public Quanhuyen quanhuyen { get; set; }
        public string tinhthanh_id { get; set; }
        public Tinhthanh tinhthanh { get; set; }
        public string dia_chi { get; set; }
        public object khoa_phong { get; set; }
        public List<Trieuchung> trieuchung { get; set; }
        public List<Dichte> dichte { get; set; }
        public int cotrieuchung { get; set; }
        public int coyeuto_dichte { get; set; }
        public object lydo_toi_donvi { get; set; }
        public string ghi_chu { get; set; }
        public object sothe_bhyt { get; set; }
        public object bhyt_full { get; set; }
        public int thoigian_khaibao { get; set; }
        public object loai_ngon_ngu { get; set; }
        public string quoctich_id { get; set; }
        public Quoctich quoctich { get; set; }
        public object diadiem_id { get; set; }
        public object diadiem { get; set; }
        public string ten_diadiem { get; set; }
        public int yeucau_cachly { get; set; }
        public int yeucau_xetnghiem { get; set; }
        public int checkin { get; set; }
        public object nguoicheckin_id { get; set; }
        public object nguoicheckin_ten { get; set; }
        public object thoigian_checkin { get; set; }
        public int xacnhan { get; set; }
        public object thoigian_xacnhan { get; set; }
        public object nguoixacnhan_id { get; set; }
        public object ghichu_huongxuly { get; set; }
        public string ip { get; set; }
        public string donvi_id { get; set; }
        public Donvi donvi { get; set; }
        public string ma_sinh_vien { get; set; }
        public int noi_tru { get; set; }
        public object ma_xetnghiem { get; set; }
        public object loai_doituong_xetnghiem { get; set; }
        public object ketqua_xetnghiem { get; set; }
        public object nhietdo_cothe { get; set; }
        public object nongdo_spo2 { get; set; }
        public object noi_xet_nghiem { get; set; }
        public object danhsach_benh_nen { get; set; }
        public int co_benh_nen { get; set; }
        public object benh_nen_khac { get; set; }
        public object co_uong_molnupiravir { get; set; }
        public object huyet_ap { get; set; }
        public object tinh_trang { get; set; }
        public object loai_xu_ly { get; set; }
        public object chan_doan { get; set; }
        public object trieu_chung_molnupiravir { get; set; }
        public object trieu_chung_molnupiravir_khac { get; set; }
        public object nguoidan { get; set; }
        public string ten_donvi { get; set; }
        public int thongbao_sms { get; set; }
    }
}
