using System;
using System.Text;

namespace SortingAlgorithms
{
    class Dayso
    {
        private int[] arr;
        private int size;
        private bool allowNegativeNumbers; //Cho phép sử dụng sô âm

        public Dayso(int size)
        {
            this.size = size;
            arr = new int[size];
        }

        public void NhapTuBanPhim()
        {
            Console.OutputEncoding = Encoding.UTF8; // Cho phép sử dụng Unicode
            Console.WriteLine("Nhập các phần tử của dãy số:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Phần tử {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void SinhNgauNhien(bool allowNegativeNumbers)
        {
            this.allowNegativeNumbers = allowNegativeNumbers;
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                if (allowNegativeNumbers)
                    arr[i] = random.Next(-99, 100); // Sinh số ngẫu nhiên từ -99 đến 99
                else
                    arr[i] = random.Next(0, 100); // Sinh số ngẫu nhiên từ 0 đến 99
            }
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Dãy số:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        // Đóng gói thuộc tính arr để tránh truy cập trực tiếp từ bên ngoài lớp
        public int[] GetArray()
        {
            return arr;
        }
        // Đóng gói thuộc tính size để tránh truy cập trực tiếp từ bên ngoài lớp
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
    }


    class RadixSort
    {
        public static void Sort(int[] arr)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Triển khai thuật toán Radix Sort tại đây
            Console.WriteLine("Đang sắp xếp theo phương pháp Phân lô...");
        }
    }

    class MergeSort
    {
        public static void Sort(int[] arr)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Triển khai thuật toán Merge Sort tại đây
            Console.WriteLine("Đang sắp xếp theo phương pháp Trộn trực tiếp...");
        }
    }

    class ThucThi
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử của dãy số: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                Console.Write("Nhập số lượng phần tử của dãy số: ");
            }

            Dayso dayso = new Dayso(size);

            Console.WriteLine("\nChọn cách nhập dãy số:");
            Console.WriteLine("1. Từ bàn phím");
            Console.WriteLine("2. Sinh ngẫu nhiên");

            int choiceNhap;
            do
            {
                Console.Write("Lựa chọn của bạn: ");
                while (!int.TryParse(Console.ReadLine(), out choiceNhap) || (choiceNhap != 1 && choiceNhap != 2))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                    Console.Write("Lựa chọn của bạn: ");
                }

                switch (choiceNhap)
                {
                    case 1:
                        dayso.NhapTuBanPhim();
                        break;
                    case 2:
                        {
                            bool allowNegativeNumbers = false;
                            Console.WriteLine("\nCó sinh số âm trong dãy số không?");
                            Console.WriteLine("1. Có");
                            Console.WriteLine("2. Không");
                            int choiceSinhSoAm;
                            do
                            {
                                Console.Write("Lựa chọn của bạn: ");
                                while (!int.TryParse(Console.ReadLine(), out choiceSinhSoAm) || (choiceSinhSoAm != 1 && choiceSinhSoAm != 2))
                                {
                                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                                    Console.Write("Lựa chọn của bạn: ");
                                }
                            } while (choiceSinhSoAm != 1 && choiceSinhSoAm != 2);

                            allowNegativeNumbers = (choiceSinhSoAm == 1);
                            dayso.SinhNgauNhien(allowNegativeNumbers);
                            break;
                        }
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                        break;
                }
            } while (choiceNhap != 1 && choiceNhap != 2);

            Console.WriteLine("\nDãy số sau khi nhập:");
            dayso.Xuat();

            Console.WriteLine("\nChọn thuật toán sắp xếp:");
            Console.WriteLine("1. Radix Sort");
            Console.WriteLine("2. Merge Sort");

            int choiceSort;
            do
            {
                Console.Write("Lựa chọn của bạn: ");
                while (!int.TryParse(Console.ReadLine(), out choiceSort) || (choiceSort != 1 && choiceSort != 2))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                    Console.Write("Lựa chọn của bạn: ");
                }

                switch (choiceSort)
                {
                    case 1:
                        RadixSort.Sort(dayso.GetArray());
                        break;
                    case 2:
                        MergeSort.Sort(dayso.GetArray());
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            } while (choiceSort != 1 && choiceSort != 2);

            Console.WriteLine("\nDãy số sau khi sắp xếp:");
            dayso.Xuat();
        }
    }

}
