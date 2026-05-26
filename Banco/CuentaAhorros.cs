using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{    //hereda de cuenta bancaria
    public class CuentaAhorros : CuentaBancaria
    {
        //contador de retiros (max 3)
        private int retiros = 0;

        public CuentaAhorros(double saldoInicial) : base(saldoInicial)
        {
        }

        //implementacion del metodo retirar 
        public override void Retirar(double monto)
        {
            try
            {
                if (monto <= 0) //verifica que el monto sea valido
                {
                    throw new ArgumentException("el monto debe ser mayor a 0");
                }

                if (retiros >= 3)
                {
                    throw new ArgumentException("el limite de 3 retiros se a alcanzado");
                }

                if (monto > saldo)
                {
                    throw new ArgumentException("fondos insuficientes");
                }

                saldo -= monto; //resta el dinero del 
                retiros++; // aumenta el contador de retiros

                Console.WriteLine("retiro realizado");
                Console.WriteLine("saldo actual: " + saldo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
        }
    }
}

