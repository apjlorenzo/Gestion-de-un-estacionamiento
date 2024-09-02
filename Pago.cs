using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Pago
    {
        public decimal MontoTotal { get; set; }
        public decimal Monto { get; set; }
        public decimal Cambio { get; set; }
        public Pago(decimal montoTotal)
        {
            MontoTotal = montoTotal;
        }

        public void ProcesarPagoEfectivo()
        {
            do
            {
                Console.Write("Ingrese el monto entregado por el cliente: Q");
                Monto = Convert.ToDecimal(Console.ReadLine());

                if (Monto < MontoTotal)
                {
                    Console.WriteLine($"Monto insuficiente. Debe entregar al menos Q{MontoTotal}.");
                }

            } while (Monto < MontoTotal);

            Cambio = Monto - MontoTotal;
            DesglosarCambio(Cambio);
        }

        private void DesglosarCambio(decimal cambio)
        {
            decimal[] billetes = { 200, 100, 50, 20, 10, 5, 1 };
            int[] cantidadBilletes = new int[billetes.Length];
            if (cambio == 0)
            {
                Console.WriteLine("\nNo hay cambio.");
                Console.WriteLine("\nVehículo removido del sistema.");
            }
            else
            {
                for (int i = 0; i < billetes.Length; i++)
                {
                    cantidadBilletes[i] = (int)(cambio / billetes[i]);
                    cambio %= billetes[i];
                }

                Console.WriteLine("\nCambio a devolver:");
                for (int i = 0; i < billetes.Length; i++)
                {
                    if (cantidadBilletes[i] > 0)
                    {
                        if (billetes[i] == 1)
                        {
                            Console.WriteLine($"{cantidadBilletes[i]} moneda(s) de: Q{billetes[i]}:");
                        }
                        else
                        {
                            Console.WriteLine($"{cantidadBilletes[i]} billete(s) de: Q{billetes[i]}:");
                        }
                    }
                }
            }
        }
    }
}
