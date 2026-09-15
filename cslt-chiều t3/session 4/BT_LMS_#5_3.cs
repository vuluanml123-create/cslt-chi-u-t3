using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_4
{
    /*internal class Exercise6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng số hạng n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double sum = 0.0;
                Console.Write("Chuỗi Harmonic: ");
                for (int i = 1; i <= n; i++)
                {
                    if (i < n)
                        Console.Write($"1/{i} + ");
                    else
                        Console.Write($"1/{i}");

                    sum += 1.0 / i;
                }
                Console.WriteLine($"\nTổng chuỗi Harmonic với {n} số hạng là: {sum:F4}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
            }
        }
    }*/

 
    /*internal class Exercise7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị bắt đầu: ");
            int start = int.Parse(Console.ReadLine() ?? "1");
            Console.Write("Nhập giá trị kết thúc: ");
            int end = int.Parse(Console.ReadLine() ?? "100000");

            Console.Write($"Các số hoàn hảo trong khoảng từ {start} đến {end} là:");
            for (int num = start; num <= end; num++)
            {
                if (num <= 1) continue;

                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }*/

}

