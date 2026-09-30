using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_8
{
    /*internal class BT_LMS_1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[][] jaggedArray = new int[][]
            {
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 2, 2 },
            new int[] { 3, 3, 3, 3 },
            new int[] { 4, 4 }
            };

            Console.WriteLine("Mảng răng cưa đã khởi tạo:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }*/

    /*internal class BT_LMS_2   
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hàng của mảng: ");
            int rows = int.Parse(Console.ReadLine()!);
            int[][] arr = new int[rows][];

            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Nhập số phần tử cho hàng {i}: ");
                int cols = int.Parse(Console.ReadLine()!);
                arr[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    arr[i][j] = rand.Next(1, 100);
                }
            }

            Console.WriteLine("\n--- Mảng ban đầu ---");
            PrintArray(arr);

            Console.WriteLine("\n--- 1. Giá trị lớn nhất ---");
            PrintMaxValues(arr);

            Console.WriteLine("\n--- 2. Sắp xếp tăng dần từng hàng ---");
            SortRowsAscending(arr);
            PrintArray(arr);

            Console.WriteLine("\n--- 3. Các số nguyên tố trong mảng ---");
            PrintPrimes(arr);

            Console.WriteLine("\n--- 4. Tìm kiếm vị trí ---");
            Console.Write("Nhập số cần tìm: ");
            int searchValue = int.Parse(Console.ReadLine()!);
            SearchNumber(arr, searchValue);
        }

        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Hàng {i}: " + string.Join(" ", arr[i]));
            }
        }

        static void PrintMaxValues(int[][] arr)
        {
            int globalMax = int.MinValue;
            bool hasElement = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 0) continue;
                int rowMax = arr[i][0];
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > rowMax) rowMax = arr[i][j];
                }
                Console.WriteLine($"Số lớn nhất của hàng {i}: {rowMax}");
                if (!hasElement || rowMax > globalMax)
                {
                    globalMax = rowMax;
                    hasElement = true;
                }
            }

            if (hasElement)
                Console.WriteLine($"=> Số lớn nhất toàn mảng: {globalMax}");
        }

        static void SortRowsAscending(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
            }
        }

        static void PrintPrimes(int[][] arr)
        {
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (IsPrime(arr[i][j]))
                    {
                        Console.Write($"{arr[i][j]} (vị trí [{i}][{j}]) | ");
                        found = true;
                    }
                }
            }
            if (!found) Console.Write("Không có số nguyên tố nào.");
            Console.WriteLine();
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false; for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void SearchNumber(int[][] arr, int target)
        {
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == target)
                    {
                        Console.WriteLine($"Tìm thấy {target} tại: Hàng {i}, Cột {j} (arr[{i}][{j}])");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine($"Không tìm thấy số {target} trong mảng.");
        }
    }*/

    struct Member
    {
        public string Id;
        public string Name;
        public int Tasks;

        public Member(string id, string name, int tasks)
        {
            Id = id;
            Name = name;
            Tasks = tasks;
        }
    }

    class BT_LMS_3
    {
        static Member[][] company = new Member[3][];

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            company[0] = new Member[5]; 
            company[1] = new Member[3]; 
            company[2] = new Member[6]; 
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n================ MENU QUẢN LÝ ================");
                Console.WriteLine("1. Khởi tạo dữ liệu mẫu");
                Console.WriteLine("2. In danh sách tất cả thành viên");
                Console.WriteLine("3. Tìm kiếm thông tin thành viên theo ID");
                Console.WriteLine("4. Tìm thành viên hoàn thành nhiều task nhất");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng (1-5): ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        InitializeData();
                        Console.WriteLine("--> Đã khởi tạo dữ liệu mẫu thành công!");
                        break;
                    case "2":
                        PrintAllMembers();
                        break;
                    case "3":
                        Console.Write("Nhập mã ID cần tìm: ");
                        string id = Console.ReadLine();
                        PrintMemberById(id);
                        break;
                    case "4":
                        PrintTopMember();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
        static void InitializeData()
        {
            company[0][0] = new Member("M101", "Nguyễn Văn A", 12);
            company[0][1] = new Member("M102", "Trần Thị B", 18);
            company[0][2] = new Member("M103", "Lê Văn C", 9);
            company[0][3] = new Member("M104", "Phạm Thị D", 15);
            company[0][4] = new Member("M105", "Hoàng Văn E", 22);

            company[1][0] = new Member("M201", "Vũ Thị F", 14);
            company[1][1] = new Member("M202", "Đặng Văn G", 25);
            company[1][2] = new Member("M203", "Bùi Thị H", 11);

            company[2][0] = new Member("M301", "Đỗ Văn I", 8);
            company[2][1] = new Member("M302", "Hồ Thị K", 19);
            company[2][2] = new Member("M303", "Ngô Văn L", 17); 
            company[2][3] = new Member("M304", "Dương Thị M", 30);
            company[2][4] = new Member("M305", "Lý Văn N", 21);
            company[2][5] = new Member("M306", "Trịnh Thị O", 16);
        }

        static void PrintAllMembers()
        {
            Console.WriteLine("\n---------------- DANH SÁCH THÀNH VIÊN ----------------");
            for (int i = 0; i < company.Length; i++)
            {
                Console.WriteLine($"\n[NHÓM {i + 1}] ({company[i].Length} thành viên):");
                Console.WriteLine($"{"ID",-10} | {"Họ và Tên",-20} | {"Số task đã làm",-15}");
                Console.WriteLine(new string('-', 50));
                for (int j = 0; j < company[i].Length; j++)
                {
                    Member m = company[i][j];
                    if (m.Id != null)
                    {
                        Console.WriteLine($"{m.Id,-10} | {m.Name,-20} | {m.Tasks,-15}");
                    }
                }
            }
        }

        static void PrintMemberById(string id)
        {
            bool found = false;
            for (int i = 0; i < company.Length; i++)
            {
                for (int j = 0; j < company[i].Length; j++)
                {
                    if (company[i][j].Id != null && company[i][j].Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"\n--> Tìm thấy thông tin thành viên:");
                        Console.WriteLine($"Nhóm:            Nhóm {i + 1}");
                        Console.WriteLine($"Mã số (ID):      {company[i][j].Id}");
                        Console.WriteLine($"Họ và tên:       {company[i][j].Name}");
                        Console.WriteLine($"Task hoàn thành: {company[i][j].Tasks}");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"\nKhông tìm thấy thành viên có ID: {id}");
            }
        }

        static void PrintTopMember()
        {
            int maxTasks = -1;
            Member topMember = new Member();
            int groupIndex = -1;
            bool foundAny = false;

            for (int i = 0; i < company.Length; i++)
            {
                for (int j = 0; j < company[i].Length; j++)
                {
                    if (company[i][j].Id != null && company[i][j].Tasks > maxTasks)
                    {
                        maxTasks = company[i][j].Tasks;
                        topMember = company[i][j];
                        groupIndex = i + 1;
                        foundAny = true;
                    }
                }
            }

            if (foundAny)
            {
                Console.WriteLine($"\n--> Thành viên xuất sắc nhất:");
                Console.WriteLine($"Nhóm:            Nhóm {groupIndex}");
                Console.WriteLine($"Mã số (ID):      {topMember.Id}");
                Console.WriteLine($"Họ và tên:       {topMember.Name}");
                Console.WriteLine($"Task hoàn thành: {topMember.Tasks}");
            }
            else
            {
                Console.WriteLine("\nChưa có dữ liệu thành viên trong hệ thống.");
            }
        }
    }
}