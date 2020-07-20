using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 2:  Realizar un programa que dado un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe por pantalla:
            /*
             
             * Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
             * Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
             * Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
              
             */


            double salario = 0, newSalario = 0;
            int antiguedad = 0;

            Console.WriteLine("\nSALARIO & ANTIGUEDAD OPERADOR\n");
            Console.Write("INGRECE SALARIO: ");
            salario = double.Parse(Console.ReadLine());
            Console.Write("INGRECE ANTIGUEDAD(ANIOS): ");
            antiguedad = int.Parse(Console.ReadLine());

            if (salario < 500)
            {
                if (antiguedad >= 10)
                {
                    newSalario = (salario * 0.20) + salario;
                    Console.WriteLine("TIENE UNA ANTIGUEDAD: {0} CON SALARIO DE: {1}, SU NUEVO SALARIO CON AUMENTO DEL 20% ES: {2} ", antiguedad, salario, newSalario);
                }
                else
                {
                    newSalario = (salario * 0.05) + salario;
                    Console.WriteLine("TIENE UNA ANTIGUEDAD: {0} CON SALARIO DE: {1}, SU NUEVO SALARIO CON AUMENTO DEL 5% ES: {2} ", antiguedad, salario, newSalario);
                }
            }
            else
            {
                Console.WriteLine("ANTIGUEDAD EMPLEADO ES {0} CON SALARIO {1}, SALARIO NO SUFRE CAMBIOS", antiguedad, salario);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
