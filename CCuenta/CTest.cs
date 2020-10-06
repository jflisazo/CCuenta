using System;
using System.Collections.Generic;
using System.Text;

namespace CCuenta
{
    class CTest
    {
        public static void Main()
        {
            CCuenta cuenta01 = new CCuenta();
            cuenta01.Nombre = "Un nombre";
            cuenta01.Cuenta = "Una cuenta";
            cuenta01.TipoDeInteres = 2.5;

            cuenta01.ingreso(12000);
            cuenta01.reintegro(3000);

            Console.WriteLine(cuenta01.Nombre);
            Console.WriteLine(cuenta01.Cuenta);
            Console.WriteLine(cuenta01.Saldo);
            Console.WriteLine(cuenta01.TipoDeInteres);
        }
                
    }
}
