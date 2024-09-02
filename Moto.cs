using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Console.Clear();
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine().ToUpper();
            Moto encontrar = listaVehiculos.OfType<Moto>().FirstOrDefault(p => p.Placa == placa);
            if (encontrar != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - encontrar.HoraEntrada;
                int horasEstacionado = (int)Math.Ceiling(tiempoEstacionado.TotalHours);

                // Calcular el costo total
                decimal costoTotal = Moto.CalcularCosto(horasEstacionado);

                Console.Clear();
                Console.WriteLine("FACTURA:");
                Console.WriteLine("Estacionamiento ELPATITO");
                Console.WriteLine(fechaFactura = DateTime.Now);
                Console.WriteLine("\nInformación de la moto: ");
                Console.WriteLine("Placa: " + encontrar.Placa);
                Console.WriteLine("Marca: " + encontrar.Marca);
                Console.WriteLine("Modelo: " + encontrar.Modelo);
                Console.WriteLine("Color: " + encontrar.Color);
                Console.WriteLine($"Tiempo estacionado: {horasEstacionado} horas");
                Console.WriteLine($"El costo total: Q{costoTotal}");
                menu.MensajeContinuar();

                Console.Clear();
                Console.WriteLine("Seleccione el método de pago Efectivo o Tarjeta (1/2):");
                int metodo = int.Parse(Console.ReadLine());
                if (metodo == 1)
                {
                    Pago pago = new Pago(costoTotal);
                    pago.ProcesarPagoEfectivo();
                    listaVehiculos.Remove(encontrar);
                    Console.WriteLine("Vehículo removido del sistema.");
                }
                else if (metodo == 2)
                {
                    if (tarjeta.VerificarTarjeta())
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Pago realizado correctamente.");
                        Console.ResetColor();
                        Console.WriteLine("\nVehículo removido del sistema.");
                        listaVehiculos.Remove(encontrar);
                    }
                }
                else
                {
                    Console.WriteLine("No es una opción válida.");
                }
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
        static decimal CalcularCosto(int horasEstacionadas)
        {
            return horasEstacionadas * 5;
        }
        public void MostrarInfo()
        {
            foreach(Moto moto in listaVehiculos)
            {
                Console.WriteLine($"\nInformación de la moto:");
                Console.WriteLine("Placa: " + moto.Placa);
                Console.WriteLine("Marca: " + moto.Marca);
                Console.WriteLine("Modelo: " + moto.Modelo);
                Console.WriteLine("Color: " + moto.Color);
                Console.WriteLine("Año: " + moto.Año);
                Console.WriteLine("Sidecar: " + moto.SideCar);
                Console.WriteLine("Fecha de ingreso: " + moto.HoraEntrada);
            }
        }
        public void Agregar()
        {
            listaVehiculos.Add(new Moto("P11903", "Honda", "Navi", "Negro", 2024, DateTime.Now.AddHours(-2), null));
        }
        public void Limpiar()
        {
            listaVehiculos.Clear();
        }
        public void MostrarEspacios()
        {
            Console.WriteLine($"Espacios disponibles: {2 - listaVehiculos.Count}");
        }
    }
}
