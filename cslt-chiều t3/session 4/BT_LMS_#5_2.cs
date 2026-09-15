using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_4
{
    /*internal class BT_LMS__5_2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            long tien = 1000_000;
            Console.WriteLine("=== GAME ĐOÁN SỐ (1- 100) ===");

            while (tien > 0)
            {
                Console.WriteLine($"\nSố tiền hiện tại: {tien:N0} đồng");
                Console.Write("Nhập số tiền đặt cược (Nhập 0 để thoát): ");
                if (!long.TryParse(Console.ReadLine(), out long tienCuoc) || tienCuoc < 0 || tienCuoc > tien)
                {
                    Console.WriteLine("Số tiền không hợp lệ!");
                    continue;
                }
                if (tienCuoc == 0) break;

                Console.WriteLine("Chọn mức độ chơi:");
                Console.WriteLine("1. Dễ (9 lần đoán - Thắng nhận 1/2 tiền cược)");
                Console.WriteLine("2. Trung bình (6 lần đoán - Thắng nhận 1 lần tiền cược)");
                Console.WriteLine("3. Khó (4 lần đoán - Thắng nhận 3 lần tiền cược)");
                Console.Write("Lựa chọn của bạn (1-3): ");

                int mode = int.Parse(Console.ReadLine() ?? "1");
                int maxLuot = mode == 1 ? 9 : (mode == 2 ? 6 : 4);
                double heSoThuong = mode == 1 ? 0.5 : (mode == 2 ? 1.0 : 3.0);

                Random rand = new Random();
                int targetNumber = rand.Next(1, 101);
                bool isWin = false;

                Console.WriteLine($"\nMáy đã bí mật chọn 1 số từ 1 đến 100. Bạn có {maxLuot} lượt đoán!");

                for (int i = 1; i <= maxLuot; i++)
                {
                    Console.Write($"Lượt {i}/{maxLuot} - Nhập số đoán: ");
                    if (int.TryParse(Console.ReadLine(), out int guess))
                    {
                        if (guess == targetNumber)
                        {
                            isWin = true;
                            break;
                        }
                        else if (guess < targetNumber)
                        {
                            Console.WriteLine("--> Số bạn đoán NHỎ HƠN kết quả.");
                        }
                        else
                        {
                            Console.WriteLine("--> Số bạn đoán LỚN HƠN kết quả.");
                        }
                    }
                }

                if (isWin)
                {
                    long tienThuong = (long)(tienCuoc * heSoThuong);
                    tien += tienThuong;
                    Console.WriteLine($"\nCHÚC MỪNG! Bạn đã đoán đúng số {targetNumber}!");
                    Console.WriteLine($"Bạn thắng thêm {tienThuong:N0} đồng.");
                }
                else
                {
                    tien -= tienCuoc;
                    Console.WriteLine($"\nBẠN ĐÃ THUA! Số đúng là {targetNumber}.");
                    Console.WriteLine($"Bạn mất {tienCuoc:N0} đồng.");
                }
                Console.WriteLine($"\nGame kết thúc! Số tiền cuối cùng của bạn: {tien:N0} đồng.");
            }
        }
    }*/
}
