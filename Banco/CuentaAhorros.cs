using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
     public class CuentaAhorros : CuentaBancaria
    {
        //contador de retiros (max 3)
        private int retiros = 0;

        public CuentaAhorros(double saldoInicial) : base(saldoInicial)
        {

        }

    }
}
