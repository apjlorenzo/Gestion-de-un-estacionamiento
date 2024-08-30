using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Camion : Vehiculo
    {
        public string Tamaño { get; set; }
        public Camion(string placa, string marca, string modelo, string color, int año, string tamaño) : base (placa,marca,modelo,color,año)
        {
            Tamaño = tamaño;
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < capacidadMaxima)
            {
                Console.Clear();
                Console.WriteLine(".::::::::::::Agregar Camión::::::::::::.");
                Console.WriteLine("______________________________________");
                base.AgregarVehiculo();
                Console.Write("Ingrese el tamaño del  camión (Grande/Muy Grande): ");
                string tamaño = Console.ReadLine();
                listaVehiculos.Add(new Moto(Placa, Marca, Modelo, Color, Año, tamaño));
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
