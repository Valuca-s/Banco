using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Banco
{
    //clase que administra multiples cuentas
    public class Banco
    {
        //lista donde se guardan las cuentas
        private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

        //metodo para agregar cuentas al banco
        public void AgregarCuenta(CuentaBancaria cuenta)
        {
            cuentas.Add(cuenta);

            Console.WriteLine("cuenta agregada correctamente");
        }

        //metodo para monstrar los saldos
        public void MostrarSaldos()
        {
            try
            {
                //verifica si hay cuentas registradas
                if(cuentas.Count == 0)
                {
                    throw new ArgumentException("no hay cuentas registradas");
                }
                
                //recorre las cuentas
                foreach (var cuenta in cuentas)
                {
                    //muestra el saldo de cada una de las cuentas
                    Console.WriteLine("saldo: " + cuenta.ConsultarSaldo());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            } 
        }   
    }
}
