using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251022054
{
    internal class Bai2
    {
       static void Main2(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap mang: ");
            string[] inputs = Console.ReadLine()!.Split(' ');
            int soluong = inputs.Length;
            int[] arr = new int[soluong];
            for (int i=0; i< soluong;i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }
            long max1 = long.MinValue;
            long max2 = long.MinValue;
            for (int i=0; i<soluong;i++)
            {
                if (arr[i]>max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i]>max2 && arr[i]<max1)
                {
                    max2 = arr[i];
                }
            }
            if (max2 == long.MinValue)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine($"Gia tri lon nhat: {max1}; gia tri lon thu hai: {max2}");
            }
        }
    }
}
