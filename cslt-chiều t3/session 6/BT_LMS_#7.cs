using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_6
{
    /*internal class BT_LMS_#7_1
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int size = 10;
            int[] numbers = CreateRandomArray(size, 1, 50);

            Console.WriteLine("=== MẢNG BAN ĐẦU ===");
            PrintArray(numbers);
            double avg = CalculateAverage(numbers);
            Console.WriteLine($"\n1. Giá trị trung bình của mảng: {avg:F2}");
            int searchValue = 25;
            bool contains = ContainsValue(numbers, searchValue);
            Console.WriteLine($"\n2. Mảng {(contains ? "có" : "không có")} chưa có giá trị {searchValue}");

            int target = numbers[3];
            int index = FindIndex(numbers, target);
            Console.WriteLine($"\n3. Chỉ số (index) của giá trị {target} la: {index}");

            int removeVal = target;
            int[] removedArray = RemoveElement(numbers, removeVal);
            Console.WriteLine($"\n4. Mảng sua khi xóa giá trị {removeVal}:");
            PrintArray(removedArray);

            FindMinMax(numbers, out int max, out int min);
            Console.WriteLine($"\n5. Giá trị lớn nhất: {max}, Giá trị nhỏ nhất: {min}");

            int[] reversedArray = ReverseArray(numbers);
            Console.WriteLine($"\n6. Mảng sau khi đảo ngược:");
            PrintArray(reversedArray);


            int[] dupArray = { 5, 12, 3, 5, 20, 12, 3, 8 };
            Console.WriteLine($"\n=== MẢNG KIỂM TRA TRÙNG LẶP ===");
            PrintArray(dupArray);


            FindDuplicates(dupArray);


            int[] uniqueArray = RemoveDuplicates(dupArray);
            Console.WriteLine($"\n8. Mảng sau khi loại bỏ các phần tử trùng lặp:");
            PrintArray(uniqueArray);
        }


        static int[] CreateRandomArray(int size, int minVal, int maxVal)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(minVal, maxVal + 1);
            }
            return arr;
        }


        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static double CalculateAverage(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        static bool ContainsValue(int[] arr, int value)
        {
            return Array.Exists(arr, element => element == value);
        }

        static int FindIndex(int[] arr, int value)
        {
            return Array.IndexOf(arr, value);
        }


        static int[] RemoveElement(int[] arr, int value)
        {
            int index = Array.IndexOf(arr, value);
            if (index == -1) return arr;

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i == index) continue;
                newArr[j++] = arr[i];
            }
            return newArr;
        }

        static void FindMinMax(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            foreach (int num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }
        }

        static int[] ReverseArray(int[] arr)
        {
            int[] newArr = (int[])arr.Clone();
            Array.Reverse(newArr);
            return newArr;
        }

        static void FindDuplicates(int[] arr)
        {
            var duplicates = arr.GroupBy(x => x)
                        .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .ToArray();

            if (duplicates.Length > 0)
            {
                Console.WriteLine($"7. Các giá trị trùng lặp trong mảng: {string.Join(", ", duplicates)}");
            }
            else
            {
                Console.WriteLine("7. Không có gía trị nào trùng lặp trong mảng.");
            }
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }*/

    /*internal class BT_LMS_2
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static bool LinearSearchWord(string sentence, string targetWord)
        {
            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':' };
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (string.Equals(word, targetWord, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== BUBBLE SORT ===");
            int[] numbers = new int[10];
            Console.WriteLine("Nhập vào 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Phần tử [{i + 1}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(numbers);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("\n=== LINEAR SEARCH ===");
            Console.Write("Nhập vào một câu: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhập vào từ cần tìm: ");
            string word = Console.ReadLine();

            bool found = LinearSearchWord(sentence, word);
            if (found)
                Console.WriteLine($"Từ '{word}' CÓ xuất hiện trong câu.");
            else
                Console.WriteLine($"Từ '{word}' KHÔNG xuất hiện trong câu.");
        }
    }*/


   
    /*(internal class BT_LMS_3
    {
          static void Main(string[] args)
          {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("================ CHƯƠNG TRÌNH THAO TÁC TRÊN MA TRẬN ================\n");
                Console.Write("Nhập số hàng (N): ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Nhập số cột (M): ");
                int m = int.Parse(Console.ReadLine());
                int[,] matrix = CreateRandomMatrix(n, m, 1, 50);

                Console.WriteLine("\n--- 1. Ma trận vừa khởi tạo ngẫu nhiên ---");
                PrintMatrix(matrix);

                Console.WriteLine("\n--- 2. In hàng / cột thứ i ---");
                Console.Write($"Nhập chỉ số hàng i muốn in (từ 0 đến {n - 1}): ");
                int rowIndex = int.Parse(Console.ReadLine());
                PrintRow(matrix, rowIndex);

                Console.Write($"Nhập chỉ số cột i muốn in (từ 0 đến {m - 1}): ");
                int colIndex = int.Parse(Console.ReadLine());
                PrintColumn(matrix, colIndex);

                Console.WriteLine("\n--- 3. Giá trị lớn nhất của toàn ma trận ---");
                int maxVal = FindMaxMatrix(matrix);
                Console.WriteLine($"=> Giá trị lớn nhất (Max) = {maxVal}");

                Console.WriteLine("\n--- 4. Tìm Min của hàng / cột thứ i ---");
                Console.Write($"Nhập chỉ số hàng i để tìm Min (từ 0 đến {n - 1}): ");
                int minRowIdx = int.Parse(Console.ReadLine());
                Console.WriteLine($"=> Min của hàng {minRowIdx} = {FindMinOfRow(matrix, minRowIdx)}");

                Console.Write($"Nhập chỉ số cột i để tìm Min (từ 0 đến {m - 1}): ");
                int minColIdx = int.Parse(Console.ReadLine());
                Console.WriteLine($"=> Min của cột {minColIdx} = {FindMinOfCol(matrix, minColIdx)}");

                Console.WriteLine("\n--- 5. Ma trận chuyển vị (Transpose) ---");
                int[,] transposed = TransposeMatrix(matrix);
                PrintMatrix(transposed);

                Console.WriteLine("\n--- 6. Đường chéo chính / phụ ---");
                PrintDiagonals(matrix);

                Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
                Console.ReadKey();
          }

        public static int[,] CreateRandomMatrix(int rows, int cols, int minVal = 1, int maxVal = 50)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(minVal, maxVal + 1);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintRow(int[,] matrix, int rowIndex)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rowIndex < 0 || rowIndex >= rows)
            {
                Console.WriteLine($"Chỉ số hàng {rowIndex} vượt quá phạm vi!");
                return;
            }

            Console.Write($"Các phần tử trên hàng {rowIndex}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[rowIndex, j]} ");
            }
            Console.WriteLine();
        }

        public static void PrintColumn(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (colIndex < 0 || colIndex >= cols)
            {
                Console.WriteLine($"Chỉ số cột {colIndex} vượt quá phạm vi!");
                return;
            }

            Console.Write($"Các phần tử trên cột {colIndex}: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, colIndex]} ");
            }
            Console.WriteLine();
        }

        public static int FindMaxMatrix(int[,] matrix)
        {
            int max = matrix[0, 0];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }
            return max;
        }
        public static int FindMinOfRow(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            int min = matrix[rowIndex, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[rowIndex, j] < min)
                    min = matrix[rowIndex, j];
            }
            return min;
        }

        public static int FindMinOfCol(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int min = matrix[0, colIndex];
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, colIndex] < min)
                    min = matrix[i, colIndex];
            }
            return min;
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }
            return transposed;
        }

        public static void PrintDiagonals(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("=> Ma trận không phải ma trận vuông (N != M) nên không có đường chéo chính/phụ.");
                return;
            }

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{matrix[i, rows - 1 - i]} ");
            }
            Console.WriteLine();
        }
    }*/
}