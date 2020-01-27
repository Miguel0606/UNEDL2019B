using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int pila1=0,pila2=0,pila3=0;

            Stack miPila1 = new Stack();
            miPila1.Push(1);
            miPila1.Push(1);
            miPila1.Push(1);
            miPila1.Push(2);
            miPila1.Push(3);

            Console.WriteLine("pila1:");

            foreach (int numero in miPila1)
            {
                Console.WriteLine(numero);
                pila1++;
            }

            Stack miPila2 = new Stack();
            miPila2.Push(2);
            miPila2.Push(3);
            miPila2.Push(4);

            Console.WriteLine("pila2:");

            foreach (int numero in miPila2)
            {
                pila2++;
                Console.WriteLine(numero);
            }

            Stack miPila3 = new Stack();
            miPila3.Push(1);
            miPila3.Push(4);
            miPila3.Push(1);
            miPila3.Push(1);

            Console.WriteLine("pila3:");

            foreach (int numero in miPila3)
            {
                pila3++;
                Console.WriteLine(numero);
            }

            Console.WriteLine("Tamaño pila1:");
            Console.WriteLine(pila1);
            Console.WriteLine("Tamaño pila2:");
            Console.WriteLine(pila2);
            Console.WriteLine("Tamaño pila3:");
            Console.WriteLine(pila3);

            Console.WriteLine("Resultado:");
            Console.WriteLine(pila1);

            Console.ReadKey();
        }
    }
}
