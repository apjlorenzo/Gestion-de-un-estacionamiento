using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    internal class Moto : Vehiculo
    {
        public string Tipo { get; set; }
        public string SideCar { get; set; }
        public Moto(string placa, string marca, string modelo, string color, int año, string tipo, string sidecar) : base (placa,marca,modelo,color,año)
        {
            Tipo = tipo;
            SideCar = sidecar;
        }
    }
}
