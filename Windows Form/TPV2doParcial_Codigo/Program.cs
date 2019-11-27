using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPV2doParcial_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter archivo;

            archivo = new StreamWriter("archivo.txt");

            String palabras;

            palabras = Console.ReadLine();

            archivo.WriteLine(palabras);

            archivo.Close();

        }
    }
}
