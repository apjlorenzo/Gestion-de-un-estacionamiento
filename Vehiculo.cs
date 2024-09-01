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
        public string placa;
        public string marca;
        public string modelo;
        public string color;
        public int año;
        public DateTime horaEntrada;
        public List<Vehiculo> listaVehiculos = new List<Vehiculo>(2);

        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Año { get; set; }
        public DateTime HoraEntrada { get; set; }
        public Vehiculo(string placa, string marca, string modelo, string color, int año, DateTime horaEntrada)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Año = año;
            HoraEntrada = horaEntrada;
        }
        public virtual void AgregarVehiculo()
        {
            horaEntrada = DateTime.Now;
            Console.Write("\nIngrese la placa del vehículo: ");
            placa = Console.ReadLine();
            Console.Write("Ingrese la marca del vehículo: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo: ");
            modelo = Console.ReadLine();
            Console.Write("Ingrese el color del vehículo: ");
            color = Console.ReadLine();
            Console.Write("Ingrese el año de lanzamiento del vehículo: ");
            año = int.Parse(Console.ReadLine());
        }
        public virtual void MostrarInfo()
        {
            foreach (Auto auto in listaVehiculos)
            {
                int i = 1;
                Console.WriteLine($"\nInformación del auto No.{i}:");
                Console.WriteLine("Placa: " + auto.Placa);
                Console.WriteLine("Marca: " + auto.Marca);
                Console.WriteLine("Modelo: " + auto.Modelo);
                Console.WriteLine("Color: " + auto.Color);
                Console.WriteLine("Año: " + auto.Año);
                Console.WriteLine("Fecha de ingreso: " + auto.HoraEntrada);

            }
        }
    }
}
