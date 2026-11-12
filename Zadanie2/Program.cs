Console.Write("Ile trwała podróż: ");
int liczbaDni = int.Parse(Console.ReadLine()!);

int sumaZlota = 0;
int udaneDni = 0;

for (int dzien = 1; dzien <= liczbaDni; dzien++)
{
    Console.Write($"Złoto w dniu {dzien}: ");
    int zloto1 = int.Parse(Console.ReadLine()!);

    sumaZlota += zloto1;

    if (zloto1 > 10)
    {
        udaneDni++;
    }
}
Console.WriteLine();
Console.WriteLine($"Łącznie znaleziono: {sumaZlota}");
Console.WriteLine($"Dni z wynikiem powyżej 10: {udaneDni}");