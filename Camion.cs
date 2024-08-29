using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Camion : Vehiculo
    {
        public string Tipo { get; set; }
        public string Capacidad { get; set; }
        public string Tamaño { get; set; }
        public Camion(string placa, string marca, string modelo, string color, int año, string tipo, string capacidad, string tamaño) : base (placa,marca,modelo,color,año)
        {
            Tipo = tipo;
            Capacidad = capacidad;
            Tamaño = tamaño;
        }
    }
}
