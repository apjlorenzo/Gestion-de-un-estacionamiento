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
        public Moto(string placa, string marca, string modelo, string color, int año, DateTime horaEntrada,string sidecar) : base (placa,marca,modelo,color,año,horaEntrada)
        {
            SideCar = sidecar;
        }
        public override void AgregarVehiculo()
        {
            if (listaVehiculos.Count < 2)
            {
                Console.Clear();
                Console.WriteLine(".::::::::::::Agregar Moto::::::::::::.");
                Console.WriteLine("______________________________________");
                base.AgregarVehiculo();
                Console.Write("¿La motocicleta tiene sidecar? (SI/NO): ");
                string sidecar = Console.ReadLine().ToUpper();
                if (sidecar == "SI" || sidecar == "NO")
                {
                    listaVehiculos.Add(new Moto(placa, marca, modelo, color, año, horaEntrada, sidecar));
                    menu.MensajeRegistrar();
                    menu.MensajeContinuar();
                }
                else
                {
                    Console.Write("Ingrese Si o No: ");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El estacionamiento está lleno.");
                menu.MensajeContinuar();
            }
        }
        public void RetirarVehiculo()
        {
            listaVehiculos.Add(new Auto("P11902", "Honda", "Navi", "Negro", 2024, DateTime.Now.AddHours(-2)));
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();
            Moto encontrar = listaVehiculos.OfType<Moto>().FirstOrDefault(p => p.Placa == placa);
            if (encontrar != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - encontrar.HoraEntrada;
                int horasEstacionado = (int)Math.Ceiling(tiempoEstacionado.TotalHours);

                // Calcular el costo total
                decimal costoTotal = Moto.CalcularCosto(horasEstacionado);

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
            return horasEstacionadas * 5.5m;
        }
        public void MostrarInfo()
        {
            foreach(Moto moto in listaVehiculos)
            {
                int i = 1;
                Console.WriteLine($"\nInformación de la moto No.{i}");
                Console.WriteLine("Placa: " + moto.Placa);
                Console.WriteLine("Marca: " + moto.Marca);
                Console.WriteLine("Modelo: " + moto.Modelo);
                Console.WriteLine("Color: " + moto.Color);
                Console.WriteLine("Año: " + moto.Año);
                Console.WriteLine("Sidecar: " + moto.SideCar);
                Console.WriteLine("Fecha de ingreso: " + moto.HoraEntrada);
            }
        }
    }
}
