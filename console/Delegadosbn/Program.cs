using System;
    
public delegate int Numbers(int num1, int num2, int num3, int num4, int num5);

namespace Delegate
{
    class Program
    {

        static int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
        static int suma = 0, prom = 0, mayor = 0;

        public static int sacarSuma(int num1, int num2, int num3, int num4, int num5)
        {
            suma = num1 + num2 + num3 + num4 + num5;
            return suma;
        }

        public static int sacarPromedio(int num1, int num2, int num3, int num4, int num5)
        {
            prom = (num1 + num2 + num3 + num4 + num5) / 5;
            return prom;
        }


        public static int sacarMayor(int num1, int num2, int num3, int num4, int num5)
        {
            if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3 && num2 >= num4 && num2 >= num5)
            {
                mayor = num2;
            }
            else if (num3 >= num1 && num3 >= num2 && num3 >= num4 && num3 >= num5)
            {
                mayor = num3;
            }
            else if (num4 >= num1 && num4 >= num2 && num4 >= num3 && num4 >= num5)
            {
                mayor = num4;
            }
            else if (num5 >= num1 && num5 >= num2 && num5 >= num3 && num5 >= num4)
            {
                mayor = num5;
            }

            return mayor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el valor 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor 3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor 4: ");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el valor 5: ");
            num5 = int.Parse(Console.ReadLine());

           Numbers nums1 = new Numbers(sacarSuma);
           Numbers nums2 = new Numbers(sacarPromedio);
           Numbers nums3 = new Numbers(sacarMayor);
           nums1(num1, num2, num3, num4, num5);
           nums2(num1, num2, num3, num4, num5);
           nums3(num1, num2, num3, num4, num5);

            Console.WriteLine("La suma es: {0}", suma);
            Console.WriteLine("El promedio es: {0}", prom);
            Console.WriteLine("El mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
}
