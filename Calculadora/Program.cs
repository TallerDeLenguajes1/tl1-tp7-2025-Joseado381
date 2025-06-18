using EspacioCalculadora;

bool escape = true;
System.Console.WriteLine("Bienvenido a la calculadora");
//  La calculadora encadena datos osea si suma e ingrea 1 
//  este se convertira en el dato luego al ingresar el termino de nuevo 
//  se sumara el dato con el termino
Calculadora miCalculadora = new Calculadora();

do
{
    System.Console.WriteLine($"\nResultado actual (Dato): {miCalculadora.Resultado}");
    int operacion = 0;
    double termino;
    System.Console.WriteLine(@"
        +---------------------+
        |   [ Calculadora ]   |
        |---------------------|
        |  1. Sumar           |
        |  2. Restar          |
        |  3. Multiplicar     |
        |  4. Dividir         |
        |                     |
        |  0. Salir           |
        +---------------------+");
    bool bandera = int.TryParse(System.Console.ReadLine(), out operacion);
    if (operacion != 0)
    {
        if (operacion < 0 || operacion > 4)
        {
            System.Console.WriteLine("Ingrese una operacion valida");
            continue;
        }
        System.Console.WriteLine("Ingrese el termino");
        bool boolTermino = double.TryParse(System.Console.ReadLine(), out termino);
        if (!boolTermino)
        {
            System.Console.WriteLine("Ingrese un numero valido");
            continue;
        }

        switch (operacion)
        {
            case 1:
                miCalculadora.Sumar(termino);
                break;
            case 2:
                miCalculadora.Restar(termino);
                break;
            case 3:
                miCalculadora.Multiplicar(termino);
                break;
            case 4:
                miCalculadora.Dividir(termino);
                break;
            default:
                System.Console.WriteLine("Operacion no reconocida, intente de nuevo.");
                break;
        }

    }
    else
    {
        escape = false;
    }

} while (escape);