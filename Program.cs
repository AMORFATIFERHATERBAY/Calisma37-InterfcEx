using System;
using System.Collections.Generic;
using System.Collections;

namespace Calisma37_InterfcEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            int[] dizi = new int[11] {55, 3, 6, 5, 9, 4, 8, 12, 69, 48, 0 };

            Koleksiyon k = new Koleksiyon(dizi);

            ArrayList list = new ArrayList();



            foreach (var sayi in k)
            {
                list.Add((int)sayi);
            }   

            list.Sort();

            foreach (object i in list)
                Console.Write((int)i + " ");

            Console.WriteLine();
        }
    }
}
