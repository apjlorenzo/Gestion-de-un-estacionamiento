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
            Console.Clear();
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine().ToUpper();
            Camion encontrar = listaVehiculos.OfType<Camion>().FirstOrDefault(p => p.Placa == placa);
            if (encontrar != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - encontrar.HoraEntrada;
                int horasEstacionado = (int)Math.Ceiling(tiempoEstacionado.TotalHours);

                // Calcular el costo total
                decimal costoTotal = Camion.CalcularCosto(horasEstacionado);

                Console.Clear();
                Console.WriteLine("FACTURA:");
                Console.WriteLine("Estacionamiento ELPATITO");
                Console.WriteLine(fechaFactura = DateTime.Now);
                Console.WriteLine("\nInformación del Camión: ");
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
            return horasEstacionadas * 20;
        }
        public void MostrarInfo()
        {
            foreach (Camion camion in listaVehiculos)
            {
                Console.WriteLine($"\nInformación del vehiculo:");
                Console.WriteLine("Placa: " + camion.Placa);
                Console.WriteLine("Marca: " + camion.Marca);
                Console.WriteLine("Modelo: " + camion.Modelo);
                Console.WriteLine("Color: " + camion.Color);
                Console.WriteLine("Año: " + camion.Año);
                Console.WriteLine("Tamaño: " + camion.Tamaño);
                Console.WriteLine("Fecha de ingreso: " + camion.HoraEntrada);

            }
        }
        public void Agregar()
        {
            listaVehiculos.Add(new Camion("C11904", "JAC", "D700 L", "Blanco", 2024, DateTime.Now.AddHours(-3), null));
        }
        public void Limpiar()
        {
            listaVehiculos.Clear();
        }
        public void MostrarEspacios()
        {
            if (listaVehiculos.Count != 0)
            {
                Console.WriteLine("Espacios disponibles: " + listaVehiculos.Count);
            }
            else
            {
                Console.WriteLine("Espacios disponibles: 2");
            }
        }
    }
}
