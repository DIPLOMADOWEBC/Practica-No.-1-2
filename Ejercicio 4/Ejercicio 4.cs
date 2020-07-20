using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 4:  En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
            /*

            Se pide realizar un programa que lea los datos de las cuentas corrientes e informe:
            a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
                --Estado de la cuenta: 
                    'Acreedor' si el saldo es >0.
                    'Deudor' si el saldo es <0.
              
             */
            //SE CONOCEN
            int numeroCuenta = 0;
            double saldoCuenta = 0, sumaAcreedores = 0;

            do
            {
                Console.Write("INGRECE NUMERO DE CUENTA: ");
                numeroCuenta = int.Parse(Console.ReadLine());
                if (numeroCuenta >= 0)
                {
                    Console.Write("INGRECE SALDO DE CUENTA: ");
                    saldoCuenta = double.Parse(Console.ReadLine());

                    Console.WriteLine("\n*** ESTADO DE CUENTA ***");
                    if (saldoCuenta > 0)
                    {
                        Console.WriteLine("Cuenta: {0} | Saldo: {1} | Es Acreedor", numeroCuenta, saldoCuenta);
                        sumaAcreedores += saldoCuenta;
                        Console.WriteLine("TOTAL ACREEDORES: {0}", sumaAcreedores);

                    }
                    else if (saldoCuenta < 0)
                        Console.WriteLine("Cuenta: {0} | Saldo: {1} | Es Deudor", numeroCuenta, saldoCuenta);
                    else if (saldoCuenta == 0)
                        Console.WriteLine("Cuenta: {0} | Saldo: {1} | Es Nulo", numeroCuenta, saldoCuenta);


                    Console.WriteLine("\n");
                }

            } while (numeroCuenta >= 0);

            Console.ReadKey();
            #endregion
        }
    }
}
