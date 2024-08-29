using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Auto : Vehiculo
    {
        public int Puertas { get; set; }
        public string Transmision { get; set; }
        public string Tipo { get; set; }
        public Auto(string placa, string marca, string modelo, string color, int año, int puertas, string transmision, string tipo) : base (placa,marca,modelo,color,año)
        {
            Puertas = puertas;
            Transmision = transmision;
            Tipo = tipo;    
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < capacidadMaxima)
            {
                base.AgregarVehiculo();
                Console.Write("Ingrese el número de puertas del vehículo: ");
                int puertas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el tipo de transmisión del vehículo (Manual/Automático): ");
                string transmision = Console.ReadLine();
                Console.Write("Ingrese el tipo de auto: ");
                string auto = Console.ReadLine();
                listaVehiculos.Add(new Auto(Placa, Marca, Modelo, Color, Año, puertas, transmision, auto));
                menu.MensajeRegistrar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El estacionamiento está lleno.");
            }
        }
    }
}
