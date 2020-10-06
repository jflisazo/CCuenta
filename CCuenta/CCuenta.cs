using System;

namespace CCuenta
{
    class CCuenta
    {
        //Atributos
        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInteres;

        //Propiedades y métodos
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Error: cadena vacía");
                    return;
                }
                nombre = value;
            }
        }

        public string Cuenta
        {
            get
            {
                return cuenta;
            }
            set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Error: cuenta no válida");
                    return;
                }
                cuenta = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
        }

        public void ingreso (double cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("Error: cantidad negativa");
                return;
            }
            saldo = saldo + cantidad;
        }

        public void reintegro (double cantidad)
        {
            if (saldo - cantidad == 0)
            {
                Console.WriteLine("Error: no dispone de saldo");
            }
            saldo = saldo - cantidad;
        }

        public double TipoDeInteres
        {
            get
            {
                return tipoDeInteres;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: tipo no válido");
                    return;
                }
                tipoDeInteres = value;
            }
        }
            
            
    }
}
