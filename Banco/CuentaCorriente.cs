using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaCorriente : CuentaBancaria
    {
        private double limiteSobregiro = -100000;

        public CuentaCorriente(double saldoInicial) : base(saldoInicial)
        {
        }

        public override void Retirar(double monto)
        {
            try
            {
                if (monto <= 0)
                {
                    throw new ArgumentException("el monto debe ser mayor a 0");
                }

                //calcular como quedaria el saldo
                double saldoTemporal = saldo - monto;

                if (saldoTemporal < limiteSobregiro)
                {
                    throw new ArgumentException("se excede el limite de sobregiro");
                }

                saldo = saldoTemporal;

                Console.WriteLine("retiro realizado");
                Console.WriteLine("saldo actual: " + saldo);
            }
            catch (Exception a)
            {
                Console.WriteLine("Error: " + a.Message);
            }
        }
    }
}
