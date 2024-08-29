using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Tarjeta
    {
        public int NumeroTarjeta { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public int CVV { get; set; }
        public Tarjeta(int numeroTarjeta, string nombre, string fecha, int cVV)
        {
            NumeroTarjeta = numeroTarjeta;
            Nombre = nombre;
            Fecha = fecha;
            CVV = cVV;
        }
    }
}
