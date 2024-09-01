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
        public Camion(string placa, string marca, string modelo, string color, int año, DateTime horaEntrada, string tamaño) : base(placa, marca, modelo, color, año, horaEntrada)
        {
            Tamaño = tamaño;
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < 2)
            {
                Console.Clear();
                Console.WriteLine(".::::::::::::Agregar Camión::::::::::::.");
                Console.WriteLine("______________________________________");
                base.AgregarVehiculo();
                Console.Write("Ingrese el tamaño del  camión (Grande/Pequeño): ");
                string tamaño = Console.ReadLine();
                listaVehiculos.Add(new Camion(placa, marca, modelo, color, año, horaEntrada, tamaño));
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
            listaVehiculos.Add(new Auto("P11902", "JAC", "D700 L", "Rojo", 2024, DateTime.Now.AddHours(-3)));
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();
            Camion encontrar = listaVehiculos.OfType<Camion>().FirstOrDefault(p => p.Placa == placa);
            if (encontrar != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - encontrar.HoraEntrada;
                int horasEstacionado = (int)Math.Ceiling(tiempoEstacionado.TotalHours);

                // Calcular el costo total
                decimal costoTotal = Camion.CalcularCosto(horasEstacionado);

                // Mostrar el resultado
                Console.WriteLine($"El vehículo con placa {encontrar.Placa} estuvo estacionado {horasEstacionado} horas.");
                Console.WriteLine($"El costo total es: Q{costoTotal}");

                listaVehiculos.Remove(encontrar);
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
        static decimal CalcularCosto(int horasEstacionadas)
        {
            return horasEstacionadas * 20.25m;
        }
        public void MostrarInfo()
        {
            foreach (Camion camion in listaVehiculos)
            {
                int i = 1;
                Console.WriteLine($"\nInformación del vehiculo No.{i}:");
                Console.WriteLine("Placa: " + camion.Placa);
                Console.WriteLine("Marca: " + camion.Marca);
                Console.WriteLine("Modelo: " + camion.Modelo);
                Console.WriteLine("Color: " + camion.Color);
                Console.WriteLine("Año: " + camion.Año);
                Console.WriteLine("Tamaño: " + camion.Tamaño);
                Console.WriteLine("Fecha de ingreso: " + camion.HoraEntrada);

            }
        }
    }
}
