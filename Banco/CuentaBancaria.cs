using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class CuentaBancaria
    {
        public int NumeroCuenta { get; set; }
        public string Titular { get; protected set; }
        //saldo de la cuenta
        protected double saldo;

        //constructor para inicializar el saldo
        public CuentaBancaria(double saldoInicial)
        {
            saldo = saldoInicial;
        }

        //metodo abstracto para retirar (cada cuenta lo imprementa distinto)
        public abstract void Retirar(double monto);

        //metodo para depositar dinero
        public virtual void Depositar(double monto)
        {
            try
            {
                //validacion de datos
                if (monto <= 0)
                {
                    throw new ArgumentException("el deposito debe ser mayor a 0");
                }

                saldo += monto;
                Console.WriteLine("deposito realizado. Saldo " + saldo);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        //consultar saldo
        public double ConsultarSaldo()
        {
            return saldo;
        }
    } 
}

        



    

