using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong sao");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
