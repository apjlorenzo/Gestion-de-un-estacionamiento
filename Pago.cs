using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Pago : Tarjeta
    {
        public string Placa { get; set; }
        public double Monto { get; set; }

        public Pago(int numerotarjeta, string nombre, string fecha, int cvv,string placa, double monto) : base (numerotarjeta, nombre, fecha, cvv)
        {
            Placa = placa;
            Monto = monto;
        }
        public void MostrarFactura()
        {
            Console.WriteLine("");
        }
    }
}
