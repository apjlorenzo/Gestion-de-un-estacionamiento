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
                                    menu.MensajeContinuar();    
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
                    bool continuarTres = true;
                    while (continuarTres)
                    {
                        menu.MenuRetirar();
                        int opcionRetirar = int.Parse(Console.ReadLine());
                        switch (opcionRetirar)
                        {
                            case 1:
                                auto.RetirarVehiculo();
                                Console.ReadKey();
                                break;
                            case 2:
                                moto.RetirarVehiculo();
                                Console.ReadKey();
                                break;
                            case 3:
                                camion.RetirarVehiculo(); 
                                Console.ReadKey();
                                break;
                            case 4:
                                continuarTres = false;
                                break;
                        } 
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Autos estacionados: ");
                    auto.MostrarInfo();
                    Console.WriteLine("___________________________");
                    Console.WriteLine("\nMotos estacionadas: ");
                    Console.WriteLine("--------------------------");
                    moto.MostrarInfo();
                    Console.WriteLine("___________________________");
                    Console.WriteLine("\nCamiones estacionados: ");
                    Console.WriteLine("--------------------------");
                    camion.MostrarInfo();
                    menu.MensajeContinuar();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Espacios disponibles para autos");
                    auto.MostrarEspacios();
                    Console.WriteLine("Espacios disponibles para motos");
                    moto.MostrarEspacios();
                    Console.WriteLine("Espacios disponibles para camiones");
                    camion.MostrarEspacios();
                    menu.MensajeContinuar();
                    break;
                case 5:
                    condicionUno = false;
                    break;
                case 6:
                    auto.Agregar();
                    moto.Agregar();
                    camion.Agregar();
                    break;
                case 7:
                    auto.Limpiar();
                    moto.Limpiar();
                    camion.Limpiar();
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