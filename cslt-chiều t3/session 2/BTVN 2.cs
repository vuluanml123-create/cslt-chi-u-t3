using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

namespace cslt_chiều_t3.session_2
{
    /*internal class Bai1

    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal chiSoCu = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            decimal chiSoMoi = decimal.Parse(Console.ReadLine());

            if (chiSoMoi < chiSoCu)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }

            decimal soKwh = chiSoMoi - chiSoCu;
            decimal tienDienChuaThue = 0;
            decimal kwhConLai = soKwh;
            decimal bac1 = Math.Min(kwhConLai, 50);
            tienDienChuaThue += bac1 * 1806m;
            kwhConLai -= bac1;

            if (kwhConLai > 0)
            {
                decimal bac2 = Math.Min(kwhConLai, 50);
                tienDienChuaThue += bac2 * 1866m;
                kwhConLai -= bac2;
            }
            if (kwhConLai > 0)
            {
                decimal bac3 = Math.Min(kwhConLai, 100);
                tienDienChuaThue += bac3 * 2167m;
                kwhConLai -= bac3;
            }
            if (kwhConLai > 0)
            {
                decimal bac4 = Math.Min(kwhConLai, 100);
                tienDienChuaThue += bac4 * 2729m;
                kwhConLai -= bac4;
            }
            if (kwhConLai > 0)
            {
                tienDienChuaThue += kwhConLai * 3050m;
            }

            decimal thueVAT = Math.Round(tienDienChuaThue * 0.08m, MidpointRounding.AwayFromZero);
            decimal tongThanhToan = tienDienChuaThue + thueVAT;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Số điện tiêu thụ: {soKwh} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDienChuaThue:#,##0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:#,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongThanhToan:#,##0} VNĐ");
        }*/


    /*class Bai2
    {
       static void Main()

       {
           Console.OutputEncoding = System.Text.Encoding.UTF8;

           Console.Write("Chiều cao (m): ");
           double chieuCao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           Console.Write("Cân nặng (kg): ");
           double canNang = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           double bmi = Math.Round(canNang / Math.Pow(chieuCao, 2), 2);

           string phanLoai = "";
           if (bmi < 18.5)
               phanLoai = "Gầy (Thiếu cân)";
           else if (bmi < 23.0)
               phanLoai = "Bình thường (Lý tưởng)";
           else if (bmi < 25.0)
               phanLoai = "Thừa cân (Tiền béo phì)";
           else
               phanLoai = "Béo phì";

           double canNangMin = Math.Round(18.5 * Math.Pow(chieuCao, 2), 2);
           double canNangMax = Math.Round(22.9 * Math.Pow(chieuCao, 2), 2);

           Console.WriteLine("\n--- OUTPUT ---");
           Console.WriteLine($"Chỉ số BMI của bạn: {bmi.ToString("F2",CultureInfo.InvariantCulture)}");
           Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
           Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2} kg đến {canNangMax:F2} kg.");
       }
   }*/

    /*enum CurrencyType
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4
    }

    class Bai3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số tiền VNĐ: ");
            decimal soTienVnd = decimal.Parse(Console.ReadLine());

            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            CurrencyType loaiNgoaiTe = (CurrencyType)int.Parse(Console.ReadLine());

            decimal phiDichVu = soTienVnd * 0.005m;
            decimal tienVndSauPhi = soTienVnd - phiDichVu;

            decimal tyGia = 0m;
            string maTienTe = "";

            switch (loaiNgoaiTe)
            {
                case CurrencyType.USD:
                    tyGia = 25400m;
                    maTienTe = "USD";
                    break;
                case CurrencyType.EUR:
                    tyGia = 27200m;
                    maTienTe = "EUR";
                    break;
                case CurrencyType.JPY:
                    tyGia = 165m;
                    maTienTe = "JPY";
                    break;
                case CurrencyType.GBP:
                    tyGia = 32100m;
                    maTienTe = "GBP";
                    break;
                default:
                    Console.WriteLine("Loại ngoại tệ không hợp lệ!");
                    return;
            }

            decimal soTienNgoaiTe = tienVndSauPhi / tyGia;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:#,##0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {tienVndSauPhi:#,##0} VNĐ");
            Console.WriteLine($"Số tiền {maTienTe} nhận được: {soTienNgoaiTe:N2} {maTienTe}");
        }
    }*/

    /* class Bai4
     {
         static void Main()
         {
             Console.OutputEncoding = System.Text.Encoding.UTF8;

             Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
             string input = Console.ReadLine();

             if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))
             {
                 Console.WriteLine("Định dạng ngày sinh không hợp lệ!");
                 return;
             }

             DateTime ngayHienTai = DateTime.Now.Date;

             // Tính tuổi
             int tuoi = ngayHienTai.Year - ngaySinh.Year;
             if (ngayHienTai < ngaySinh.AddYears(tuoi))
             {
                 tuoi--;
             }

             // Tính tổng số ngày đã sống
             int tongSoNgaySong = (int)(ngayHienTai - ngaySinh).TotalDays;

             // Tính ngày sinh nhật tiếp theo
             DateTime sinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
             if (sinhNhatTiepTheo < ngayHienTai)
             {
                 sinhNhatTiepTheo = sinhNhatTiepTheo.AddYears(1);
             }

             int soNgayConLai = (int)(sinhNhatTiepTheo - ngayHienTai).TotalDays;

             Console.WriteLine("\n--- OUTPUT ---");
             Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
             Console.WriteLine($"Bạn đã sống tổng cộng: {tongSoNgaySong:#,##0} ngày");
             Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai} ngày nữa");
         }
     }*/

    /*class Bai5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int tcCSharp = 4, tcToan = 3, tcTiengAnh = 2;

            Console.Write($"C# ({tcCSharp} TC): ");
            double diemCSharp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Toán ({tcToan} TC): ");
            double diemToan = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Tiếng Anh ({tcTiengAnh} TC): ");
            double diemTiengAnh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int tongTinChi = tcCSharp + tcToan + tcTiengAnh;
            double scoreAvg = ((diemCSharp * tcCSharp) + (diemToan * tcToan) + (diemTiengAnh * tcTiengAnh)) / tongTinChi;

            string diemChu = "";
            double gpa4 = 0.0;
            string xepLoai = "";

            // Quy đổi theo đúng bảng trong đề bài
            if (scoreAvg >= 8.5)
            {
                diemChu = "A";
                gpa4 = 4.0;
                xepLoai = "Xuất sắc / Giỏi";
            }
            else if (scoreAvg >= 7.0)
            {
                diemChu = "B";
                gpa4 = 3.0;
                xepLoai = "Khá";
            }
            else if (scoreAvg >= 5.5)
            {
                diemChu = "C";
                gpa4 = 2.0;
                xepLoai = "Trung bình";
            }
            else if (scoreAvg >= 4.0)
            {
                diemChu = "D";
                gpa4 = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = "F";
                gpa4 = 0.0;
                xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Điểm TB Thang 10: {scoreAvg.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa4.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }
    }*/

    /*class Bai6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên thô: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                Console.WriteLine("Họ tên không hợp lệ!");
                return;
            }
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                words[i] = char.ToUpper(word[0]) + word.Substring(1);
            }

            string hoTenChuanHoa = string.Join(" ", words);
            string ho = words[0];
            string ten = words[words.Length - 1];
            string tenDem = words.Length > 2
                ? string.Join(" ", words.Skip(1).Take(words.Length - 2))
                : (words.Length == 2 ? words[0] : "");
            string tenKhongDau = LoaiBoDauTiengViet(ten).ToLower();
            string hoKhongDau = LoaiBoDauTiengViet(ho).ToLower();

            string tenDemKhongDau = "";
            if (words.Length > 2)
            {
                var tenDemWords = words.Skip(1).Take(words.Length - 2).Select(w => LoaiBoDauTiengViet(w).ToLower());
                tenDemKhongDau = string.Join("", tenDemWords);
            }

            string username = $"{tenKhongDau}.{hoKhongDau}{tenDemKhongDau}";
            string email = $"{username}@company.edu.vn";

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Họ tên chuẩn hóa: {hoTenChuanHoa}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {(string.IsNullOrEmpty(tenDem) ? "Không có" : tenDem)} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");
        }
        static string LoaiBoDauTiengViet(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
                    return sb.ToString().Normalize(NormalizationForm.FormC).Replace('đ', 'd').Replace('Đ', 'D');
        }
    }*/

    /*class Bai7
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập quãng đường (km): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Nhập mức tiêu thụ trung bình (L/100km): ");
            double fuelRate= double.Parse(Console.ReadLine());

            Console.Write("Nhập giá xăng (VNĐ/Lít): ");
            decimal fuelPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập số người đi: ");
            int peopleCount = int.Parse(Console.ReadLine());

            double totalFuel = (distance / 100.0) * fuelRate;
            decimal totalCost = (decimal)totalFuel * fuelPrice;
            decimal rawcostPerson = totalCost / peopleCount;
            decimal costPerPerson = Math.Ceiling(rawcostPerson / 1000m) * 1000m;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {totalFuel:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {Math.Round(totalCost):N0} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {costPerPerson:N0} VNĐ");
        }
    }*/

    /*class Bai9
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập Lương Gross (VNĐ): ");
            decimal gross = decimal.Parse(Console.ReadLine());

            Console.Write("Số người phụ thuộc: ");
            int dependents = int.Parse(Console.ReadLine());

            decimal insurance = gross * 0.105m;

            decimal taxableIncome = gross - insurance - 11000000m - (dependents * 4400000m);
            if (taxableIncome < 0) taxableIncome = 0;

            decimal personalTax = CalculatePIT(taxableIncome);

            decimal netSalary = gross - insurance - personalTax;

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {insurance:N0} VNĐ");
            Console.WriteLine($"Thu nhập chịu thuế: {taxableIncome:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {personalTax:N0} VNĐ");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {netSalary:N0} VNĐ");
        }

        static decimal CalculatePIT(decimal taxableIncome)
        {
            if (taxableIncome <= 0) return 0;

            decimal tax = 0;
            if (taxableIncome > 5000000m)
            {
                tax += 5000000m * 0.05m;
                taxableIncome -= 5000000m;
            }
            else return tax + taxableIncome * 0.05m;

            if (taxableIncome > 5000000m)
            {
                tax += 5000000m * 0.10m;
                taxableIncome -= 5000000m;
            }
            else return tax + taxableIncome * 0.10m;

            if (taxableIncome > 8000000m)
            {
                tax += 8000000m * 0.15m;
                taxableIncome -= 8000000m;
            }
            else return tax + taxableIncome * 0.15m;

            return tax;
        }
    }*/

    /*class Bai11
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Số tiền gửi: ");
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.Write("Lãi suất năm (%): ");
            double annualRate = double.Parse(Console.ReadLine());

            Console.Write("Thời gian gửi (tháng): ");
            int months = int.Parse(Console.ReadLine());

            decimal simpleInterest = principal * (decimal)(annualRate / 100) * (months / 12.0m);

            double ratePerMonth = annualRate / 100 / 12;
            double compoundAmountDouble = (double)principal * Math.Pow(1 + ratePerMonth, months);
            decimal compoundInterest = (decimal)compoundAmountDouble - principal;

            decimal difference = compoundInterest - simpleInterest;


            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {simpleInterest:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {compoundInterest:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {difference:N0} VNĐ (Lãi kép tối ưu hơn)");
        }
    }*/

    /*class Bai14
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chuỗi số: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Lỗi: Chuỗi nhập vào không phải số nguyên hợp lệ!");
                return;
            }

            Console.WriteLine("\n--- OUTPUT ---");
            Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {number}");

            if (number >= byte.MinValue && number <= byte.MaxValue)
                Console.WriteLine("Phù hợp kiểu byte: Có (Vừa vặn trong dải 0-255)");
            else if (number >= short.MinValue && number <= short.MaxValue)
                Console.WriteLine("Phù hợp kiểu short: Có (Vừa vặn trong dải -32,768 đến 32,767)");
            else
                Console.WriteLine("Phù hợp kiểu int: Có (Vừa vặn trong dải Int32)");

            int sumDigits = 0;
            string absoluteStr = Math.Abs(number).ToString();
            for (int i = 0; i < absoluteStr.Length; i++)
            {
                sumDigits += absoluteStr[i] - '0';
            }

            string formattedSum = string.Join(" + ", absoluteStr.ToCharArray());
            Console.WriteLine($"Tổng các chữ số: {formattedSum} = {sumDigits}");

            try
            {
                checked
                {
                    int testValue = number;
                    testValue = testValue + 0;
                }
                Console.WriteLine("Kiểm tra Tràn số: An toàn trong phạm vi int32.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Kiểm tra Tràn số: Phát hiện tràn số (Overflow Exception) trong khối checked!");
            }
        }
    }*/
}






        