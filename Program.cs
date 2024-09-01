using Proyecto_1;


Menu menu = new Menu();
DateTime time = DateTime.MinValue;
Auto auto = new Auto(null,null,null,null,0,time);
Moto moto = new Moto(null,null,null,null,0,time,null);
Camion camion = new Camion(null,null,null,null,0,time,null);
bool condicionUno = true;
try
{
    Console.WriteLine(".:::Bienvenido al sistema de gestión y cobro del estacionamiento:::.");
    Console.WriteLine("____________________________________________________________________");
    menu.MensajeContinuar();
    do
    {
        menu.MenuPrincipal();
        try
        {
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    bool continuarDos = true;
                    while (continuarDos)
                    {
                        menu.MenuRegistrar();
                        try
                        {
                            int opcionDos = int.Parse(Console.ReadLine());
                            switch (opcionDos)
                            {
                                case 1:
                                    auto.AgregarVehiculo();
                                    menu.MensajeContinuar();
                                    break;
                                case 2:
                                    moto.AgregarVehiculo();
                                    break;
                                case 3:
                                    camion.AgregarVehiculo();
                                    menu.MensajeContinuar();
                                    break;
                                case 4:
                                    continuarDos = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("No es una opción válida.");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese el tipo de vehículo a retirar: ");
                    int tipo = int.Parse(Console.ReadLine());
                    if (tipo == 1)
                    {
                        auto.RetirarVehiculo();
                    }
                    else if (tipo == 2)
                    {
                        moto.RetirarVehiculo();
                    }
                    else if (tipo == 3)
                    {
                        camion.RetirarVehiculo();
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Autos estacionados: :");
                    auto.MostrarInfo();
                    Console.WriteLine("\nMotos estacionadas: ");
                    moto.MostrarInfo();
                    Console.WriteLine("\nCamiones estacionados: ");
                    camion.MostrarInfo();
                    Console.ReadKey();
                    break;
                case 4:
                    break;
                case 5:
                    condicionUno = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("No es una opción válida.");
                    Console.ReadKey();
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }

    }
    while (condicionUno);

}
finally
{
    Console.WriteLine("\nGracias por utilizar nuestro sistema...");
}