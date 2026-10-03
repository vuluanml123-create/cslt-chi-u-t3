using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_chiều_t3.session_9
{
    internal class BT_LMS__9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHƯƠNG TRÌNH XỬ LÝ CHUỖI C# (BÀI TẬP #9) ===\n");

            Console.Write("1. Nhập vào một chuỗi: ");
            string str = Console.ReadLine();
            Console.WriteLine($"   -> Chuỗi vừa nhập: \"{str}\"\n");

            int length = GetStringLength(str);
            Console.WriteLine($"2. Độ dài của chuỗi (không dùng .Length): {length}\n");

            Console.Write("3. Các ký tự riêng lẻ trong chuỗi: ");
            SeparateCharacters(str);
            Console.WriteLine();

            Console.Write("4. In các ký tự theo thứ tự đảo ngược: ");
            PrintReverse(str);
            Console.WriteLine();

            int wordCount = CountWords(str);
            Console.WriteLine($"5. Tổng số từ trong chuỗi: {wordCount}\n");

            Console.Write("6. Nhập chuỗi thứ 2 để so sánh: ");
            string str2 = Console.ReadLine();
            int compareResult = CompareStrings(str, str2);
            if (compareResult == 0)
                Console.WriteLine("   -> Hai chuỗi GIỐNG NHAU.");
            else
                Console.WriteLine($"   -> Hai chuỗi KHÁC NHAU (Độ lệch mã ASCII/độ dài: {compareResult}).\n");

            CountCharTypes(str);

            CountVowelsAndConsonants(str);

            Console.Write("\n9&10. Nhập chuỗi con cần tìm: ");
            string subStr = Console.ReadLine();
            int pos = FindSubstringPosition(str, subStr);
            if (pos != -1)
            {
                Console.WriteLine($"   -> Chuỗi con CÓ xuất hiện trong chuỗi ban đầu.");
                Console.WriteLine($"   -> Vị trí (chỉ số) bắt đầu xuất hiện đầu tiên: {pos}");
            }
            else
            {
                Console.WriteLine("   -> Chuỗi con KHÔNG xuất hiện trong chuỗi.");
            }

            Console.Write("\n11. Nhập 1 ký tự để kiểm tra: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            CheckCharacterCase(ch);

            if (pos != -1)
            {
                int occCount = CountSubstringOccurrences(str, subStr);
                Console.WriteLine($"\n12. Số lần chuỗi con \"{subStr}\" xuất hiện trong chuỗi: {occCount}");
            }
       
            if (pos != -1)
            {
                Console.Write("\n13. Nhập chuỗi muốn chèn vào trước \"{0}\": ", subStr);
                string insertStr = Console.ReadLine();
                string resultStr = InsertBeforeFirstOccurrence(str, subStr, insertStr);
                Console.WriteLine($"   -> Chuỗi sau khi chèn: \"{resultStr}\"");
            }

            Console.WriteLine("\n=== HOÀN THÀNH BÀI TẬP ===");
        }

        // ---------------- YÊU CẦU 2: LẤY ĐỘ DÀI CHUỖI ----------------
        static int GetStringLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            return length;
        }

        // ---------------- YÊU CẦU 3: TÁCH TỪNG KÝ TỰ ----------------
        static void SeparateCharacters(string str)
        {
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        // ---------------- YÊU CẦU 4: IN ĐẢO NGƯỢC ----------------
        static void PrintReverse(string str)
        {
            int len = GetStringLength(str);
            for (int i = len - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        // ---------------- YÊU CẦU 5: ĐẾM SỐ TỪ ----------------
        static int CountWords(string str)
        {
            int count = 0;
            bool inWord = false;
            int len = GetStringLength(str);

            for (int i = 0; i < len; i++)
            {
                if (str[i] != ' ' && str[i] != '\t' && str[i] != '\n')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return count;
        }

        // ---------------- YÊU CẦU 6: SO SÁNH 2 CHUỖI ----------------
        static int CompareStrings(string str1, string str2)
        {
            int len1 = GetStringLength(str1);
            int len2 = GetStringLength(str2);
            int minLen = len1 < len2 ? len1 : len2;

            for (int i = 0; i < minLen; i++)
            {
                if (str1[i] != str2[i])
                {
                    return str1[i] - str2[i];
                }
            }
            return len1 - len2;
        }

        // ---------------- YÊU CẦU 7: ĐẾM CHỮ CÁI, CHỮ SỐ, KÝ TỰ ĐẶC BIỆT ----------------
        static void CountCharTypes(string str)
        {
            int alphabets = 0, digits = 0, specials = 0;

            foreach (char c in str)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    alphabets++;
                else if (c >= '0' && c <= '9')
                    digits++;
                else if (c != ' ' && c != '\t' && c != '\n')
                    specials++;
            }

            Console.WriteLine("7. Thống kê loại ký tự:");
            Console.WriteLine($"   - Chữ cái (Alphabets): {alphabets}");
            Console.WriteLine($"   - Chữ số (Digits): {digits}");
            Console.WriteLine($"   - Ký tự đặc biệt (Special characters): {specials}\n");
        }

        // ---------------- YÊU CẦU 8: ĐẾM NGUYÊN ÂM / PHỤ ÂM ----------------
        static void CountVowelsAndConsonants(string str)
        {
            int vowels = 0, consonants = 0;

            foreach (char c in str)
            {
                char lowerC = char.ToLower(c);
                if (lowerC >= 'a' && lowerC <= 'z')
                {
                    if (lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("8. Thống kê nguyên âm và phụ âm (tiếng Anh):");
            Console.WriteLine($"   - Số nguyên âm (Vowels): {vowels}");
            Console.WriteLine($"   - Số phụ âm (Consonants): {consonants}");
        }

        // ---------------- YÊU CẦU 10: TÌM VỊ TRÍ CHUỖI CON ----------------
        static int FindSubstringPosition(string mainStr, string subStr)
        {
            int mainLen = GetStringLength(mainStr);
            int subLen = GetStringLength(subStr);

            if (subLen == 0) return 0;
            if (subLen > mainLen) return -1;

            for (int i = 0; i <= mainLen - subLen; i++)
            {
                bool match = true;
                for (int j = 0; j < subLen; j++)
                {
                    if (mainStr[i + j] != subStr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }
            return -1;
        }

        // ---------------- YÊU CẦU 11: KIỂM TRA CHỮ CÁI & HOA/THƯỜNG ----------------
        static void CheckCharacterCase(char ch)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"   -> Ký tự '{ch}' LÀ chữ cái (Viết THƯỜNG / Lowercase).");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"   -> Ký tự '{ch}' LÀ chữ cái (Viết HOA / Uppercase).");
            }
            else
            {
                Console.WriteLine($"   -> Ký tự '{ch}' KHÔNG PHẢI là chữ cái.");
            }
        }

        // ---------------- YÊU CẦU 12: ĐẾM SỐ LẦN XUẤT HIỆN CỦA CHUỖI CON ----------------
        static int CountSubstringOccurrences(string mainStr, string subStr)
        {
            int count = 0;
            int mainLen = GetStringLength(mainStr);
            int subLen = GetStringLength(subStr);

            if (subLen == 0 || mainLen < subLen) return 0;

            for (int i = 0; i <= mainLen - subLen; i++)
            {
                bool match = true;
                for (int j = 0; j < subLen; j++)
                {
                    if (mainStr[i + j] != subStr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                    i += subLen - 1;
                }
            }
            return count;
        }

        // ---------------- YÊU CẦU 13: CHÈN CHUỖI CON VÀO TRƯỚC LẦN XUẤT HIỆN ĐẦU TIÊN ----------------
        static string InsertBeforeFirstOccurrence(string mainStr, string target, string toInsert)
        {
            int pos = FindSubstringPosition(mainStr, target);
            if (pos == -1) return mainStr;

            string result = "";

            for (int i = 0; i < pos; i++)
            {
                result += mainStr[i];
            }

            result += toInsert;

            for (int i = pos; i < GetStringLength(mainStr); i++)
            {
                result += mainStr[i];
            }

            return result;
        }
    }
}
