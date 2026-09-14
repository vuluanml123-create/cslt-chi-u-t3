using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace cslt_chiều_t3.session_3
{
    /*internal class BT_1
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số tuổi: ");
            if (!int.TryParse(Console.ReadLine(), out int tuoi) || tuoi <0)
            {
                Console.WriteLine("Tuổi không hợp lệ!");
                return;
            }
            Console.Write("Nhập Giờ Chiếu (0-23): ");
            if (!int.TryParse(Console.ReadLine(), out int GioChieu)|| GioChieu <0||GioChieu > 23)
            {
                Console.WriteLine("Giờ chiếu không hợp lệ!");
                return;
            }

           int GiaVe = 0;
            if (tuoi > 60 || tuoi < 12)
            {
                GiaVe = 50000;
            }
            else
            {
                if (GioChieu < 17)
                {
                    GiaVe = 80000;
                }
                else
                {
                    GiaVe = 110000;
                }
            }
            Console.WriteLine($"Giá vé của bạn là: {GiaVe:N0} VNĐ");
        }*/
    /*internal class BT_3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số dư hiện tại(VNĐ): ");
            if (!long.TryParse(Console.ReadLine(), out long SoDu) || SoDu < 0)
            {
                Console.Write("Số dư không hợp lệ!");
                return;
            }
            Console.Write("Nhập số tiền muốn rút(VNĐ): ");
            if (!long.TryParse(Console.ReadLine(), out long SoTienRut) || SoTienRut > SoDu)
            {
                Console.WriteLine("Số tiền rút không hợp lệ!");
                return;
            }
            if (SoTienRut <= 0)
            {
                Console.WriteLine("Lỗi: số tiền rút phải lớn hơn 0");
            }
            else if (SoTienRut % 50000 != 0)
            {
                Console.WriteLine("Lỗi: số tiền rút phair là bội số của 50000 VNĐ!");
            }
            else if (SoTienRut > SoDu)
            {
                Console.WriteLine("Lỗi: số dư tài khoản không đủ để thực hiện giao dịch!");
            }
            else if (SoTienRut > 5000000)
            {
                Console.WriteLine("Lỗi hạn mức rút tối đa là 5000000 VNĐ/lần");
            }
            else
            {
                SoDu -= SoTienRut;
                Console.WriteLine($"Giao dịch thành công. Số dư còn lại: {SoDu:N0} VNĐ");
            }
        }   
    }*/
    /*internal class BT_5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Số Km di chuyển: ");
            if (!double.TryParse(Console.ReadLine(), out double SoKm) || SoKm <= 0)
            {
                Console.WriteLine(" Số Km phải lớn hơn 0!");
                return;
            }
            double TongTien = 0;
            if (SoKm <= 1)
            {
                TongTien = SoKm * 15000;
            }
            else if (SoKm <= 10)
            {
                TongTien = 15000 + (SoKm - 1) * 12000;
            }
            else if (SoKm >= 11)
            {
                TongTien = 15000 + (9 * 12000) + (SoKm - 10) * 10000;
            }
            double KhuyenMai = 0;
            if (SoKm > 30)
            {
                KhuyenMai = TongTien * 0.10;
            }
            double ThanhTien = TongTien - KhuyenMai;
            Console.WriteLine($"Tồng tiền trước giảm: {TongTien:N0} VND");
            Console.WriteLine($"Khuyến mãi (10%): -{KhuyenMai:N0} VND");
            Console.WriteLine($"Thành tiền: {ThanhTien:N0} VND");
        }
    }*/

    /*internal class BT_7
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Số cân nặng(Kg): ");
            if (!double.TryParse(Console.ReadLine(), out double CanNang) || CanNang <= 0)
            {
                Console.WriteLine("Cân nặng không hợp lệ!");
                return;
            }
            Console.Write("Chiều cao(m): ");
            if (!double.TryParse(Console.ReadLine(), out double ChieuCao) || ChieuCao <= 0)
            {
                Console.WriteLine("Chiều cao không hợp lệ!");
                return;
            }
            double BMI = CanNang/(ChieuCao*ChieuCao);
            string DanhGia = "";
            if (BMI < 18.5)
            {
                DanhGia = "Thấy gầy- Nên bổ sung dinh dưỡng";
            }
            else if (BMI < 25)
            {
                DanhGia = "Cân đối - Tiếp tục duy trì";
            }
            else if (BMI < 30)
            {
                DanhGia = "Thừa cân- Nên tăng cường luyện tập";
            }
            else if (BMI >= 30)
            {
                DanhGia = "Béo phì- Cần sự tư vấn của bác sĩ";
            }
            Console.WriteLine($"BMI: {BMI:F2} - Đánh giá: {DanhGia}");
        }
    }*/

    /*internal class BT_9
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập điểm trung bình tích lũy(GPA): ");
            if (!double.TryParse(Console.ReadLine(), out double GPA) || GPA < 0 || GPA > 4)
            {
                Console.WriteLine("Điểm GPA không hợp lệ!");
                return;
            }
            Console.Write("Điểm rèn luyện(0-100): ");
            if (int.TryParse(Console.ReadLine(),out int DRL) || DRL < 0 || DRL > 100)
            {
                Console.WriteLine("Điểm rèn luyện không hợp lệ!");
                return;
            }
            if (GPA >= 3.6 && DRL >= 90)
            {
                Console.WriteLine("Kết quả: Học bổng xuất sắc (Mức 100%)");
            }
            else if (GPA >= 3.2 && DRL >= 80)
            {
                if (GPA >= 3.6 && DRL < 90)
                {
                    Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%) (Do DRL < 90)");
                }
                else
                {
                    Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%)");
                }
            }
            else
            {
                Console.WriteLine("Kết quả: Không đạt học bổng");
            }
        }
    }*/

    /*internal class BT_11
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số kWh tiêu thụ trong tháng: ");
            if (!int.TryParse(Console.ReadLine(), out int kWh)|| kWh < 0)
            {
                Console.WriteLine("Số kWh không hợp lệ!");
                return;
            }
            double TongTien = 0;
            string ChiTiet = "";
            if (kWh <= 50)
            {
                TongTien = 1806 * kWh;
                ChiTiet = $"{kWh}*1806";
            }
            else if (kWh <= 100)
            {
                int kWhBac1 = 50;
                int kWhBac2 = kWh - 50;
                double tienBac1 = kWhBac1 * 1806;
                double tienBac2 = kWhBac2 * 1866;
                TongTien = tienBac1 + tienBac2;
                ChiTiet = $"{kWhBac1}*1806 + {kWhBac2}*1866 = {tienBac1:N0} + {tienBac2:N0}";
            }
            else
            {
                int kWhBac1 = 50;
                int kWhBac2 = 50;
                int kWhBac3 = kWh - 100;
                double tienBac1 = kWhBac1 * 1806;
                double tienBac2 = kWhBac2 * 1866;
                double tienBac3 = kWhBac3 * 2167;
                TongTien = tienBac1 + tienBac2 + tienBac3;
                ChiTiet = $"{kWhBac1}*1806 + {kWhBac2}*1866 + {kWhBac3}*2167 =  {tienBac1:N0} + {tienBac2:N0} + {tienBac3:N0}";
            }
            Console.WriteLine($"Tổng tiền điện phải thanh toán: {TongTien:N0} VND");
            Console.WriteLine($"(Chi tiết: {ChiTiet})");
        }
    }*/

    /*internal class BT_13
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập mức lương cơ bản: ");
            if (!int.TryParse(Console.ReadLine(), out int Luong) || Luong < 0)
            {
                Console.WriteLine("Mức lương không hợp lệ!");
                return;
            }
            Console.Write("Nhập tỷ lệ hoàn thành KPI(%): ");
            if (!double.TryParse(Console.ReadLine(), out double KPI) || KPI < 0)
            {
                Console.WriteLine("Tỷ lệ hoàn thành KPI không hợp lệ!");
                return;
            }
            double TienThuongTet = 0;
            string DanhGia = "";
            if (KPI < 80)
            {
                DanhGia = "Cần cải thiện";
                TienThuongTet = 0;
            }
            else if (KPI < 100)
            {
                DanhGia = "Đạt";
                TienThuongTet = Luong * 0.5;
            }
            else if (KPI <= 120)
            {
                DanhGia = "Tốt";
                TienThuongTet = Luong * 1;
            }
            else
            {
                DanhGia = "Xuất sắc";
                TienThuongTet = Luong * 1.5;
            }
            Console.WriteLine($"Đánh giá: {DanhGia}.Tiền thưởng Tết: {TienThuongTet:N0} VND");
        }
    }*/

    /*internal class BT_12
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số ngày trễ: ");
            if (!int.TryParse(Console.ReadLine(), out int NgayTre) || NgayTre < 0)
            {
                Console.WriteLine("Số ngày không hợp lệ!");
                return;
            }
            if (NgayTre==0)
            {
                Console.WriteLine("Bạn đã trả sách đúng hạn, không bị phạt");
                return;
            }
            long Phat = 0;
            
            if( NgayTre <=3)
            {
                Phat = NgayTre * 5000;
            }
            else if( NgayTre <=7)
            {
                Phat = NgayTre * 10000;
            }
            else
            {
                Phat = NgayTre * 20000;
            }
            Console.WriteLine($"Tiền phạt: {Phat:N0} VND");
            if (NgayTre >7)
            {
                Console.WriteLine("cảnh báo:Tài khoản thư viện của bạn bị tạm khóa 30 ngày");
            }

        }
    }*/
    /*internal class BT_17
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhiệt độ(°C): ");
            if(!double.TryParse(Console.ReadLine(), out double NhietDo))
            {
                Console.WriteLine("Nhiệt độ không hợp lệ!");
                return;
            }
            Console.Write("Thời tiết (1: Nắng, 2: Mưa): ");
            if (!int.TryParse(Console.ReadLine(), out int ThoiTiet))
            {
                Console.WriteLine("Trạng thái thời tiết không hợp lệ!");
                return;
            }
            string KhuyenDung = "";
            if (NhietDo < 18)
            {
                KhuyenDung = "Mặc áo khoác dày, giữ ấm.";
            }
            else if(NhietDo <=28)
            {
                KhuyenDung = "Mặc áo phông/sơ mi thoải mái";
            }
            else
            {
                KhuyenDung = "Mặc đồ thoáng mát, mang theo kem chống nắng";
            }
            if (ThoiTiet == 2)
            {
                KhuyenDung += "Đừng quên mang theo ô/áo mưa!";
            }
            Console.WriteLine($"Khuyên dùng: {KhuyenDung}");
        }
    }*/

    /*internal class BT_20
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhóm máu người nhận(O, A, B, AB): ");
            string NhomMauNguoiNhan = Console.ReadLine()?.Trim().ToUpper();
            switch (NhomMauNguoiNhan )
            {
                case "O":
                    Console.WriteLine("Người có nhóm máu O có thể nhận máu từ nhóm: O.");
                    break;
                case "A":
                    Console.WriteLine("Người có nhóm máu A có thể nhận máu từ nhóm: A, O");
                    break;
                case "B":
                    Console.WriteLine("Người có nhóm máu B có thể nhận máu từ nhóm: B, O");
                    break;
                case "AB":
                    Console.WriteLine("Người có nhóm máu AB có thể nhận máu từ tất cả các nhóm A, B, AB, O");
                    break;
                default:
                    Console.WriteLine("Lỗi: Nhóm máu nhập vào không hợp lệ (Chỉ nhận O, A, B, AB)");
                    break;
            }

        }
    }*/
}

