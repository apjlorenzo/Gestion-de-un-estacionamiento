using Proyecto_1;


Menu menu = new Menu();
Auto auto = new Auto(null, null, null, null, 0,0,null,null);
bool condicionUno = true;
try
{
    Console.WriteLine(":::.Bienvenido al sistema de estacionamiento.:::");
    Console.WriteLine("________________________________________________");
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
                                    break;
                                case 3:
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
                    break;
                case 3:
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