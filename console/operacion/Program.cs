using System;
using System.Collections;

namespace operacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacion;

            Console.WriteLine("Dame el acomodo: ");
            operacion = Console.ReadLine();

            Stack pila = new Stack();

            foreach (var s in operacion)
            {
                pila.Push(s);
            }

            

        }
    }
}
