/*using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_3
{
    internal class BT_1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số thứ nhất: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập phép tính (+, -, *, x, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                case 'x':
                case 'X':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Lỗi: Không thể chia cho 0!");
                    break;
                default:
                    Console.WriteLine("Phép tính không hợp lệ.");
                    break;
            }
        }
    }
}
*/