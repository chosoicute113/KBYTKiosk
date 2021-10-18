using KhaiBaoYTeKiosk.Models;
using KhaiBaoYTeKiosk.Resources.Command;
using MVVMEssentials.ViewModels;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace KhaiBaoYTeKiosk.ViewModels
{
    public class CheckinInfoViewModel : ViewModelBase
    {
        private Dictionary<int, string> _cacLoaiKhaiBao = new Dictionary<int, string>(){
            {2, "Bệnh nhân/Người nhà" },
            {3, "Nhân viên bệnh viện" },
            {4, "Khách đến liên hệ công tác" },
            {5, "Tiêm chủng vaccine" },
            {6, "Xét nghiệm covid 19" },
            {7, "Theo dõi sức khỏe tại nhà" }
            };

        private Dictionary<int, string> _cacLoaiGioiTinh = new Dictionary<int, string>()
        {
            {0,"Nữ"},
            {1,"Nam" }
        };

        public ICommand updateViewCommand { get; set; }
        public MainViewModel MainVM;

        public CheckinInfoViewModel(MainViewModel vm, CheckinUser user)
        {
            updateViewCommand = new UpdateViewCommand(vm);
            MainVM = vm;

            HoTen = user.ten;
            NgayKhaiBao = DateTimeOffset
                .FromUnixTimeSeconds(user.created_at)
                .ToString("g");
            NoiKhaiBao = user.ten_diadiem;
            DonVi = user.donvi.ten;
            LoaiKhaiBao = _cacLoaiKhaiBao.GetValueOrDefault(user.loai_khaibao);
            NamSinh = user.namsinh.ToString();
            GioiTinh = _cacLoaiGioiTinh.GetValueOrDefault(user.gioi_tinh);
            DiaChi = $"{user.dia_chi}, {user.xaphuong.ten}, {user.quanhuyen.ten}, {user.tinhthanh.ten}";
            QRImage = convertStringToDrawingImage("https://kbyt.khambenh.gov.vn/#tokhai_yte/ketqua?id=" + user.id);
            SoDienThoai = user.so_dien_thoai;
            DanhSachTrieuChung = summarizeTrieuChung(user.trieuchung);
            DanhSachDichTe = summarizeYeuToDichTe(user.dichte);
        }

        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value;
                OnPropertyChanged(nameof(HoTen));
            }
        }


        private string _ngayKhaiBao;
        public string NgayKhaiBao
        {
            get { return _ngayKhaiBao; }
            set { _ngayKhaiBao = value;
                OnPropertyChanged(nameof(NgayKhaiBao));
            }
        }

        private string _noiKhaiBao;
        public string NoiKhaiBao
        {
            get { return _noiKhaiBao; }
            set { _noiKhaiBao = value;
                OnPropertyChanged(nameof(NoiKhaiBao));
            }
        }

        private string _donVi;
        public string DonVi
        {
            get { return _donVi; }
            set { _donVi = value;
                OnPropertyChanged(nameof(DonVi));
            }
        }

        private string _loaiKhaiBao;
        public string LoaiKhaiBao
        {
            get { return _loaiKhaiBao; }
            set { _loaiKhaiBao = value;
                OnPropertyChanged(nameof(LoaiKhaiBao));
            }
        }

        private string _namSinh;
        public string NamSinh
        {
            get { return _namSinh; }
            set
            {
                _namSinh = value;
                OnPropertyChanged(nameof(NamSinh));
            }
        }

        private string _gioiTinh;
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set
            {
                _gioiTinh = value;
                OnPropertyChanged(nameof(GioiTinh));
            }
        }

        private string _diaChi;
        public string DiaChi
        {
            get { return _diaChi; }
            set
            {
                _diaChi = value;
                OnPropertyChanged(nameof(DiaChi));
            }
        }

        private BitmapImage _qrImage;

        public BitmapImage QRImage
        {
            get { return _qrImage; }
            set { _qrImage = value;
                OnPropertyChanged(nameof(QRImage));
            }
        }

        private string _soDienThoai;
        public string SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value;
                OnPropertyChanged(nameof(SoDienThoai));
            }
        }

        private string _danhsachTrieuChung;
        public string DanhSachTrieuChung
        {
            get { return _danhsachTrieuChung; }
            set
            {
                _danhsachTrieuChung = value;
                OnPropertyChanged(nameof(DanhSachTrieuChung));
            }
        }

        private string _danhsachDichTe;
        public string DanhSachDichTe
        {
            get { return _danhsachDichTe; }
            set
            {
                _danhsachDichTe = value;
                OnPropertyChanged(nameof(DanhSachDichTe));
            }
        }


        public BitmapImage convertStringToDrawingImage(string input)
        {
            Debug.WriteLine("Im in the function");
            if (input != null)
            {
                //Generate a QR bitmap from string input
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrData);
                Bitmap qrImage = qrCode.GetGraphic(20);

                //Convert Bitmap into BitmapImage
                MemoryStream ms = new MemoryStream();
                qrImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                ms.Seek(0, SeekOrigin.Begin);
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();

                return bitmapImage;
            }
            else return new BitmapImage();

        }
        public string summarizeTrieuChung(IEnumerable<Trieuchung> cactrieuchung)
        {
            if(cactrieuchung.Count<Trieuchung>() > 0)
            {
                string[] v = cactrieuchung.Select(n => n.ten).ToArray<string>();
                return String.Join<string>(", ", v);
            }
            return "Không";
        }

        public string summarizeYeuToDichTe(IEnumerable<Dichte> cacdichte)
        {
            if (cacdichte.Count<Dichte>() > 0)
            {
                string[] v = cacdichte.Select(n => n.ten).ToArray<string>();
                return String.Join<string>("\n", v);
            }
            return "Không";
        }

    }
}
