using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("___________________________________");
            Console.WriteLine("::::::::::MENU::::::::::");
            Console.WriteLine("1.REGISTRAR VEHÍCULOS");
            Console.WriteLine("2.RETIRAR VEHÍCULOS");
            Console.WriteLine("3.MOSTRAR VEHÍCULOS ESTACIONADOS");
            Console.WriteLine("4.MOSTRAR ESPACIOS DISPONIBLES");
            Console.WriteLine("5.SALIR");
            Console.WriteLine("___________________________________");
            Console.Write("Ingrese una opción: ");
        }
        public void MenuRegistrar()
        {
            Console.Clear();
            Console.WriteLine("___________________________________");
            Console.WriteLine(":::::::::REGISTRAR VEHÍCULOS::::::::");
            Console.WriteLine("1.Registrar Auto");
            Console.WriteLine("2.Registrar Moto");
            Console.WriteLine("3.Registrar Camión");
            Console.WriteLine("4.Salir");
            Console.WriteLine("___________________________________");
            Console.Write("Ingrese una opción: ");
        }
        public void MensajeRegistrar()
        {
            Console.Clear();
            Console.WriteLine("Vehículo registrado correctamente.");
            Console.Write("\nPresione una tecla para continuar: ");
            Console.ReadKey();
        }
    }
}
