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
        public Auto(string placa, string marca, string modelo, string color, int año, int puertas) : base (placa,marca,modelo,color,año)
        {
            Puertas = puertas;   
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < capacidadMaxima)
            {
                Console.Clear();
                Console.WriteLine(".::::::::::::Agregar Auto::::::::::::.");
                Console.WriteLine("______________________________________");
                base.AgregarVehiculo();
                Console.Write("Ingrese el número de puertas del vehículo: ");
                int puertas = int.Parse(Console.ReadLine());
                listaVehiculos.Add(new Auto(Placa, Marca, Modelo, Color, Año, puertas));
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
