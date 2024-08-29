using Proyecto_1;

DateOnly time = new DateOnly();
Menu menu = new Menu();
Vehiculo vehiculo = new Vehiculo(null,null,null,null,0);
bool condicionUno = true;
try
{
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
                                    vehiculo.AgregarVehiculo();
                                    menu.MensajeRegistrar();
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
                    Console.Clear();
                    Console.WriteLine(time);
                    Console.ReadKey();
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