using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Pago
    {
        public string Placa { get; set; }
        public double Monto { get; set; }

        public Pago(string placa, double monto)
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
