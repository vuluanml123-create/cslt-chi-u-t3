using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_5
{
    /*internal class BT_1
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(" Nhập số thứ nhất(a): ");
            int a = int.Parse (Console.ReadLine());
            Console.Write(" Nhập số thứ hai(b): ");
            int b = int.Parse (Console.ReadLine());
            int result = TinhTong(a, b);
            Console.WriteLine($" Tổng của {a} và {b} là: {result}");
        }
    }*/

    /*internal class BT_2
    {
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên(n): ");
            int n = int.Parse(Console.ReadLine()!);
            bool isEven = KiemTraChan(n);
            if (isEven)
            {
                Console.WriteLine($"{n} là số chẵn,");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ.");
            }
        }
    }*/

    /*internal class BT_3
        {
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;     
            Console.Write("Nhập số thứ nhất (a): ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập số thứ hai (b): ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập số thứ ba (c): ");
            int c = int.Parse(Console.ReadLine()!);

            int max = TimMax(a, b, c);
            Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
        }
    }*/

    /*internal class BT_4
    {
        public static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số nguyên n (n >= 0): ");
            int n = int.Parse(Console.ReadLine()!);

            long result = TinhGiaiThua(n);
            Console.WriteLine($"Giai thừa của {n} ({n}!) là: {result}");
        }
    }*/

    /*internal class BT_5
    {
        public static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine()!;

            string result = DaoNguocChuoi(input);
            Console.WriteLine($"Chuỗi sau khi đảo ngược là: {result}");
        }
    }*/

    /*internal class BT_6
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine()!);

            bool isPrime = KiemTraNguyenTo(n);
            if (isPrime)
                Console.WriteLine($"{n} là số nguyên tố.");
            else
                Console.WriteLine($"{n} không phải là số nguyên tố.");
        }
    }*/

    /*internal class BT_8
    {
        public static int DemNguyenAm(string s)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (vowels.Contains(c)) count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào một chuỗi: ");
            string s = Console.ReadLine()!;

            int count = DemNguyenAm(s);
            Console.WriteLine($"Số lượng nguyên âm trong chuỗi là: {count}");
        }
    }*/

    /*internal class BT_9
    {
        public static double TinhLuyThua(double x, int y)
        {
            double result = 1;
            int exp = Math.Abs(y);
            for (int i = 0; i < exp; i++)
            {
                result *= x;
            }
            return y < 0 ? 1 / result : result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập cơ số x: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.Write("Nhập số mũ y: ");
            int y = int.Parse(Console.ReadLine()!);

            double result = TinhLuyThua(x, y);
            Console.WriteLine($"Kết quả {x}^{y} = {result}");
        }
    }*/

    /*internal class BT_10
    {
        public static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int sum = 0;
            foreach (int num in arr) sum += num;
            return (double)sum / arr.Length;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            double result = TinhTrungBinh(arr);
            Console.WriteLine($"Giá trị trung bình của mảng là: {result}");
        }
    }*/

    /*internal class BT_19
    {
        public static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập năm cần kiểm tra: ");
            int year = int.Parse(Console.ReadLine()!);

            bool isLeap = KiemTraNamNhuan(year);
            if (isLeap)
                Console.WriteLine($"Năm {year} là năm nhuận.");
            else
                Console.WriteLine($"Năm {year} không phải là năm nhuận.");
        }
    }*/
}
