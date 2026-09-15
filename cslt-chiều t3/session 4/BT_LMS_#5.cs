using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace cslt_chiều_t3.session_4
{
    /*internal class Game_Xí_Ngầu
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            dice_game();
        }
        public static void dice_game()
        {
            Console.WriteLine("""
  _____   _____  _____  ______     _____          __  __ ______ 
 |  __ \ |_   _|/ ____||  ____|   / ____|   /\   |  \/  |  ____|
 | |  | |  | | | |     | |__     | |  __   /  \  | \  / | |__   
 | |  | |  | | | |     |  __|    | | |_ | / /\ \ | |\/| |  __|  
 | |__| | _| |_| |____ | |____   | |__| |/ ____ \| |  | | |____ 
 |_____/ |_____|\_____||______|   \_____/_/    \_\_|  |_|______|
                                                                
""");
       
            long tien = 1000_000_000;
            int soLanChoi = 0;
            int soLanThua = 0;
            int soLanDacBiet = 0;
            bool continuePlaying = true;

            do
            {
                soLanChoi++;
                Console.WriteLine($"\n--- LẦN CHƠI THỬ {soLanChoi} ---");
                Console.WriteLine($"Bạn đang có {tien:N0} VND.");

                if (tien <= 0)
                {
                    Console.WriteLine("Bạn đã hết tiền! Game kết thúc.");
                    break;
                }
                long tienDatCuoc = 0;
                do
                {
                    Console.Write("Bạn đã đặt bao nhiêu? ");
                    bool ok = long.TryParse(Console.ReadLine(), out long result);
                    if (ok && result <= tien && result >= 1000)
                    {
                        tienDatCuoc = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Vui lòng nhập số tiền hợp lệ (từ 1000 đến {tien:N0} VND)");
                    }

                } while (true);
                Random rand = new Random();
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                int sum = dice1 + dice2;
                string guess;
                do
                {
                    Console.Write("Bạn đoán Tài (T), Xỉu (X) hay Lục (L)? ");
                    guess = Console.ReadLine().Trim().ToLower();
                    if (guess == "t" || guess == "x" || guess == "l")
                    {
                        break;
                    }
                    Console.WriteLine("Vui lòng chỉ nhập T, X hoặc L.");
                } while (true);
                bool isWin = false;
                bool isSpecial = false;
                if (guess == "t" && sum > 6)
                {
                    isWin = true;
                }
                else if (guess == "x" && sum < 6)
                {
                    isWin = true;
                }
                else if (guess == "l" && sum == 6)
                {
                    isWin = true;
                    isSpecial = true;
                }
                Console.WriteLine($"Kết quả gieo xúc xắc: {dice1} + {dice2} = {sum}");
                if (isWin)
                {
                    if (isSpecial)
                    {
                        soLanDacBiet++;
                        long tienThuong = tienDatCuoc * 3;
                        tien += tienThuong;
                        Console.WriteLine($"Bạn thắng ĐẶC BIỆT! Nhận được {tienThuong:N0} VND. Tổng tiền: {tien:N0} VND.");
                    }
                    else
                    {
                        tien += tienDatCuoc;
                        Console.WriteLine($"Bạn THẮNG! Tổng tiền; {tien:N0} VND");
                    }
                }
                else
                {
                    tien -= tienDatCuoc;
                    soLanThua++;
                    Console.WriteLine($"Bạn THUA! Mất {tienDatCuoc:N0} VND. Tổng tiền: {tien:N0} VND.");
                }
                if (tien > 0)
                {
                    Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
                    string input = Console.ReadLine().Trim().ToLower();
                    if (input == "k")
                    {
                        continuePlaying = false;
                    }
                }
            } while (continuePlaying && tien > 0);
            int soLanThangThuong = soLanChoi - soLanThua - soLanDacBiet;
            Console.WriteLine("\n================ TRÒ CHƠI KẾT THÚC ================");
            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
            Console.WriteLine($"Tổng số lần thắng thường: {soLanThangThuong}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {soLanDacBiet}");
            Console.WriteLine($"Tổng số lần thua: {soLanThua}");
            Console.WriteLine($"Số tiền còn lại: {tien:N0} VND");
         }
    }*/
}
  