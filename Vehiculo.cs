using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Vehiculo
    {
        public Menu menu = new Menu();
        public int capacidadMaxima = 2;
        public List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        protected string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Año { get; set; }

        public Vehiculo(string placa, string marca, string modelo, string color, int año)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Año = año;
        }
        public virtual void AgregarVehiculo()
        {
            Console.Clear();
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();
            Console.Write("Ingrese la marca del vehículo: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ingrese el color del vehículo: ");
            string color = Console.ReadLine();
            Console.Write("Ingrese el año de lanzamiento del vehículo: ");
            int año = int.Parse(Console.ReadLine());
        }
    }
}
