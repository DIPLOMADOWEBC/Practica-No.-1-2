using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1 Desarrollar un programa que imprima los múltiplos de 3 del 1 al 200 (Utilizar la Sentencia while)
            int num = 1;
            Console.WriteLine("\nNUMEROS MULTIPLO DE 3\n");
            while (num <= 200)
            {
                if (num % 3 == 0)
                    Console.WriteLine(num);
                num++;
            }
            Console.ReadKey();
            #endregion
        }
    }
}
