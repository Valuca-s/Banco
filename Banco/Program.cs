// See https://aka.ms/new-console-template for more information
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear banco
            Banco banco = new Banco();

            //crear cuentas
            CuentaAhorros ahorros = new CuentaAhorros(1000);
            CuentaCorriente corriente = new CuentaCorriente(500);
            //agregando cuentas al banco
            banco.AgregarCuenta(ahorros);
            banco.AgregarCuenta(corriente);

            int opcion = 0;

            while (opcion != 7)
            {
                try
                {
                    Console.WriteLine("\n===== MENU BANCO =====");
                    Console.WriteLine("1 - Depositar en Cuenta Ahorros");
                    Console.WriteLine("2 - Retirar de Cuenta Ahorros");
                    Console.WriteLine("3 - Consultar saldo Cuenta Ahorros");
                    Console.WriteLine("4 - Depositar en Cuenta Corriente");
                    Console.WriteLine("5 - Retirar de Cuenta Corriente");
                    Console.WriteLine("6 - Consultar saldo Cuenta Corriente");
                    Console.WriteLine("7 - Salir");

                    Console.Write("Ingrese una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            //depositar ahorros
                            Console.Write("monto a depositar: ");
                            double depAhorros = double.Parse(Console.ReadLine());

                            ahorros.Depositar(depAhorros);

                            break;

                        case 2:
                            //retirar ahorros
                            Console.Write("monto a retirar:");
                            double retAhorros = double.Parse(Console.ReadLine());
                            ahorros.Retirar(retAhorros);
                            break;

                        case 3:

                            //mostrar saldo de ahorros
                            Console.WriteLine("saldo: " + ahorros.ConsultarSaldo());
                            break;

                        case 4:
                            //depositar corriente
                            Console.Write("monto a depostitar: ");
                            double retCorriente = double.Parse(Console.ReadLine());

                            corriente.Depositar(retCorriente);
                            break;

                        case 5:
                            //retirar del corriente 
                            Console.Write("monto a retirar");
                            double retiroCorriente = double.Parse(Console.ReadLine());

                            corriente.Retirar(retiroCorriente);
                            break;

                        case 6:
                            //mostrar saldo corriente
                            Console.WriteLine("saldo: " + corriente.ConsultarSaldo());

                            break;

                        case 7:
                            //salir del programa
                            Console.WriteLine("saliendo del sistema...");
                            break;

                        default:
                            Console.WriteLine("opcion incorrecta");
                            break;
                    }
                }
                catch (FormatException)
                {
                    //error si el usuario ingresa un valor no numérico
                    Console.WriteLine("Error: ingrese un numero valido");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}