using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai2
{
    internal class ThiSinh
    {
        //ma ho so(int), ten(string),tuoi,diem uu tien,diem mon 1, diem mon 2, diem mon 3
        //Phương thức nhập thông tin thí sinh
        //xét ket qua tuyen sinh: phương thức này thực hiện nhập điểm chuẩn của trường:
        //- tổng 3 môn + ưu tiên >= điểm chuẩn và ko có môn nào <3đ:Thông báo "Chuc mưng ban da trung tuyen"
        // Ngược lại thông báo: "Ban rot cmnr"
        //Xuất thông tin thí sinh: Sau khi xuất thông tin thí sinh, xuất luôn kết quả xét tuyển
        public int maHoSo;
        public string hoVaTen;
        public int tuoi;
        public float diemUuTien;
        public float diem1;
        public float diem2;
        public float diem3;

        public void NhapThongTinThiSinh()
        {
            maHoSo = 1;
            hoVaTen = "Hoang Minh Tri";
            tuoi = 20;
            diemUuTien = 0.5f;
            diem1 = 9;
            diem2 = 8.5f;
            diem3 = 9;
        }
        public void XetTuyen()
        {
            float tong = diem1 + diem2 + diem3 + diemUuTien;
            Console.Write("Nhap diem xet tuyen cua truong: ");
            float diemXetTuyen = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem cua ban: "+ tong);
            Console.WriteLine("Diem trung tuyen: "+ diemXetTuyen);
            if (tong >= diemXetTuyen)
                Console.WriteLine("Chuc mung ban da trung tuyen");
            else
                Console.WriteLine("Ban rot cmnr");
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Ma thi sinh: " + maHoSo);
            Console.WriteLine("Ho va ten: " + hoVaTen);
            Console.WriteLine("Tuoi: "+ tuoi);
            Console.WriteLine("Diem uu tien: "+ diemUuTien);
            Console.WriteLine("Diem mon 1: "+ diem1);
            Console.WriteLine("Diem mon 2: "+ diem2);
            Console.WriteLine("Diem mon 3: "+ diem3);
            XetTuyen();
        }
    }
}
