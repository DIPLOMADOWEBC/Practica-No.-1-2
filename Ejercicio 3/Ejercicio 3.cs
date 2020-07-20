using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 3:  Realizar un programa que permita ingresar n números enteros por el teclado y se desea conocer:
            /*
             
                a) La cantidad de números positivos.
                b) La cantidad de números negativos.
                c) La cantidad de números pares.
                d) La cantidad de números impares
              
             */

            int valor = 0, x = 1, n = 0, pares = 0, impares = 0, negativos = 0, positivos = 0;

            Console.WriteLine("\nOPERACIONES & COMPARACION\n");
            Console.Write("CANTIDAD DE NUMEROS A EVALUAR: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            while (x <= n)
            {
                Console.Write("INGRECE {0} VALOR: ", x);
                valor = int.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    positivos++;
                    if (valor % 2 == 0)
                        pares++;
                    else
                        impares++;
                }
                else
                {
                    negativos++;
                    if (valor % -2 == 0)
                        pares++;
                    else
                        impares++;
                }
                x++;
            }

            Console.WriteLine("CANTIDAD DE POSITIVOS: {0}", positivos);
            Console.WriteLine("CANTIDAD DE NEGATIVOS: {0}", negativos);
            Console.WriteLine("CANTIDAD DE PARES: {0}", pares);
            Console.WriteLine("CANTIDAD DE IMPARES: {0}", impares);

            Console.ReadKey();
            #endregion
        }
    }
}
