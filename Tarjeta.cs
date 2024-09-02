using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Tarjeta
    {
        public bool verificación = false;
        private int NumeroTarjeta { get; set; }
        private string Nombre { get; set; }
        private string Fecha { get; set; }
        private int CVV { get; set; }
        public Tarjeta(int numeroTarjeta, string nombre, string fecha, int cVV)
        {
            NumeroTarjeta = 119002;
            Nombre = "PABLO JOSE";
            Fecha = "09/29";
            CVV = 465;
        }
        public bool VerificarTarjeta()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Ingrese el número de tarjeta: ");
                int numeroTarjeta = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del titular: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la fecha de vencimiento (MM/YY): ");
                string fecha = Console.ReadLine();
                Console.Write("Ingrese el código de seguridad (***): ");
                int cVV = int.Parse(Console.ReadLine());
                if (numeroTarjeta == NumeroTarjeta && nombre == Nombre && fecha == Fecha && cVV == CVV)
                {
                    Console.WriteLine("\nTarjeta verificada correctamente.");
                    Console.ReadLine();
                    return true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se pudo realizar el pago, datos incorrectos.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            return false;
        }
    }
}
