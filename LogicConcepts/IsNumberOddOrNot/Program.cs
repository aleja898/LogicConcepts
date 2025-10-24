// See https://aka.ms/new-console-template for more information
var numberString = string.Empty;
do
{
    Console.Write("Ingresa el número o presione 'S' para salir: ");
    numberString = Console.ReadLine();
    if (numberString == "S" || numberString == "s")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, es impar");
        }
    }
    else
        {
            Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero";
        }
} while (numberString != "S");
Console.WriteLine("GAME OVER");