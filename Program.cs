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
            Console.WriteLine("Phạm Thiện Tâm 22115053122336");
            //JOIN nhân viên với phòng ban
            var nhanVienPhongBan_336 = from nv_336 in nhanViens_336
                                       join pb_336 in phongBans_336 on nv_336.PhongBanId_336 equals pb_336.Id_336
                                       select new { nv_336.Ten_336, nv_336.Tuoi_336, nv_336.Luong_336, TenPhong_336 = pb_336.Ten_336 };

            Console.WriteLine("\nDanh sách nhân viên và phòng ban:");
            foreach (var item_336 in nhanVienPhongBan_336)
            {
                Console.WriteLine($"Nhân viên: {item_336.Ten_336}, Tuổi: {item_336.Tuoi_336}, Lương: {item_336.Luong_336:C}, Phòng ban: {item_336.TenPhong_336}");
            }

            // Nhóm nhân viên theo phòng ban, sắp xếp theo tuổi
            var nhomNhanVien_336 = from nv_336 in nhanViens_336
                                   group nv_336 by nv_336.PhongBanId_336 into nhom_336
                                   join pb_336 in phongBans_336 on nhom_336.Key equals pb_336.Id_336
                                   select new
                                   {
                                       TenPhong_336 = pb_336.Ten_336,
                                       TreNhat_336 = nhom_336.OrderBy(e => e.Tuoi_336).First(),
                                       GiaNhat_336 = nhom_336.OrderByDescending(e => e.Tuoi_336).First(),
                                       TuoiTB_336 = nhom_336.Average(e => e.Tuoi_336)
                                   };

            Console.WriteLine("\n Danh sách nhân viên theo phòng ban (Trẻ nhất, Già nhất, Trung bình tuổi):");
            foreach (var group_336 in nhomNhanVien_336)
            {
                Console.WriteLine($"Phòng: {group_336.TenPhong_336}");
                Console.WriteLine($"- Trẻ nhất: {group_336.TreNhat_336.Ten_336}, Tuổi: {group_336.TreNhat_336.Tuoi_336}");
                Console.WriteLine($"- Già nhất: {group_336.GiaNhat_336.Ten_336}, Tuổi: {group_336.GiaNhat_336.Tuoi_336}");
                Console.WriteLine($"- Tuổi trung bình: {group_336.TuoiTB_336:F2}");
            }

            // Tính lương trung bình của công ty
            decimal luongTB_336 = nhanViens_336.Average(e => e.Luong_336);
            Console.WriteLine($"\nLương trung bình của công ty: {luongTB_336:C}");

            Console.ReadLine();
        }


  
        
       
    }
    }

