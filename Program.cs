using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_linq
{
    class PhongBan_336
    {
        public int Id_336 { get; set; }
        public string Ten_336 { get; set; }

        public PhongBan_336(int id_336, string ten_336)
        {
            Id_336 = id_336;
            Ten_336 = ten_336;
        }
    }

    class NhanVien_336
    {
        public int Id_336 { get; set; }
        public string Ten_336 { get; set; }
        public int Tuoi_336 { get; set; }
        public decimal Luong_336 { get; set; }
        public int PhongBanId_336 { get; set; } // Mã phòng ban

   
        public NhanVien_336(int id_336, string ten_336, int tuoi_336, decimal luong_336, int phongBanId_336)
        {
            Id_336 = id_336;
            Ten_336 = ten_336;
            Tuoi_336 = tuoi_336;
            Luong_336 = luong_336;
            PhongBanId_336 = phongBanId_336;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<PhongBan_336> phongBans_336 = new List<PhongBan_336>
        {
            new PhongBan_336(1, "Công nghệ thông tin"),
            new PhongBan_336(2, "Nhân sự"),
            new PhongBan_336(3, "Tài chính")
        };

            // Danh sách nhân viên
            List<NhanVien_336> nhanViens_336 = new List<NhanVien_336>
        {
            new NhanVien_336(1, "Anh", 25, 5000, 1),
            new NhanVien_336(2, "Bảo", 30, 6000, 1),
            new NhanVien_336(3, "Cường", 28, 7000, 2),
            new NhanVien_336(4, "Dũng", 40, 8000, 2),
            new NhanVien_336(5, "Em", 35, 5500, 3),
            new NhanVien_336(6, "Phúc", 27, 7200, 3)

        };

        
          
            Console.ReadLine();
        }
       
    }
    }

