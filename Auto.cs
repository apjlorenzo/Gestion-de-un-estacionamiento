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
            Console.Clear();
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine().ToUpper();
            Auto encontrar = listaVehiculos.OfType<Auto>().FirstOrDefault(p => p.Placa == placa);
            if (encontrar != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - encontrar.HoraEntrada;
                int horasEstacionado = (int)Math.Ceiling(tiempoEstacionado.TotalHours);

                // Calcular el costo total
                decimal costoTotal = Auto.CalcularCosto(horasEstacionado);

                Console.Clear();
                Console.WriteLine("FACTURA:");
                Console.WriteLine("Estacionamiento ELPATITO");
                Console.WriteLine(fechaFactura = DateTime.Now);
                Console.WriteLine("\nInformación del auto: ");
                Console.WriteLine("Placa: "+encontrar.Placa);
                Console.WriteLine("Marca: "+encontrar.Marca);
                Console.WriteLine("Modelo: "+encontrar.Modelo);
                Console.WriteLine("Color: "+encontrar.Color);
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
                Console.WriteLine("\nVehículo no encontrado.");
            }
        }
        static decimal CalcularCosto(int horasEstacionado)
        {
            return horasEstacionado * 10;
        }
        
        public override void MostrarInfo()
        {
            base.MostrarInfo();
        }
        public void Agregar()
        {
            listaVehiculos.Add(new Auto("P11902", "Toyota", "Corrolla", "Rojo", 2024, DateTime.Now.AddHours(-1)));
        }
        public void Limpiar()
        {
            listaVehiculos.Clear();
        }
        public void MostrarEspacios()
        {
            Console.WriteLine($"Espacios disponibles: {2-listaVehiculos.Count}");
        }
    }
}
