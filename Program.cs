using Proyecto_1;

Menu menu = new Menu();
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