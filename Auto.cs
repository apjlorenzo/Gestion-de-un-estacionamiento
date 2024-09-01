using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Auto : Vehiculo
    {
        public Auto(string placa, string marca, string modelo, string color, int año, DateTime horaEntrada) : base (placa,marca,modelo,color,año,horaEntrada)
        {
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < 2)
            {
                Console.Clear();
                Console.WriteLine(".::::::::::::Agregar Auto::::::::::::.");
                Console.WriteLine("______________________________________");
                base.AgregarVehiculo();
                listaVehiculos.Add(new Auto(placa, marca, modelo, color, año, horaEntrada));
                menu.MensajeRegistrar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El estacionamiento está lleno.");
            }
        }
        public void RetirarVehiculo()
        {
            listaVehiculos.Add(new Auto("P11902", "Toyota", "Corrolla", "Rojo", 2024, DateTime.Now.AddHours(-1)));
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();
            Auto encontrar = listaVehiculos.OfType<Auto>().FirstOrDefault(p => p.Placa == placa);
            if (encontrar != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - encontrar.HoraEntrada;
                int horasEstacionado = (int)Math.Ceiling(tiempoEstacionado.TotalHours);

                // Calcular el costo total
                decimal costoTotal = Auto.CalcularCosto(horasEstacionado);

                // Mostrar el resultado
                Console.WriteLine("Información del auto: ");
                Console.WriteLine("Placa: "+encontrar.Placa);
                Console.WriteLine("Marca: "+encontrar.Marca);
                Console.WriteLine("Modelo: "+encontrar.Modelo);
                Console.WriteLine("Color: "+encontrar.Color);
                Console.WriteLine($"Tiempo estacionado: {horasEstacionado} horas");
                Console.WriteLine($"El costo total es: Q{costoTotal}");

                listaVehiculos.Remove(encontrar);
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
        static decimal CalcularCosto(int horasEstacionado)
        {
            return horasEstacionado * 10.25m;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
        }
    }
}
