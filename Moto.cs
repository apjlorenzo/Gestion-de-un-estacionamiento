using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    internal class Moto : Vehiculo
    {
        public string SideCar { get; set; }
        public Moto(string placa, string marca, string modelo, string color, int año, string sidecar) : base (placa,marca,modelo,color,año)
        {
            SideCar = sidecar;
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < capacidadMaxima)
            {
                Console.Clear();
                Console.WriteLine(".::::::::::::Agregar Moto::::::::::::.");
                Console.WriteLine("______________________________________");
                base.AgregarVehiculo();
                Console.Write("Ingrese el tipo de motocicleta: ");
                string tipo = Console.ReadLine();
                Console.Write("¿La motocicleta tiene sidecar?: ");
                string sidecar = Console.ReadLine();
                listaVehiculos.Add(new Moto(Placa, Marca, Modelo, Color, Año, tipo));
                menu.MenuRegistrar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El estacionamiento está lleno.");
            }
        }
    }
}
