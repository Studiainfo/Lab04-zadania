Console.Write("Podaj wysokość choinki (2-10): ");
int wysokosc = int.Parse(Console.ReadLine()!);

for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
{
    int spacje = wysokosc - wiersz;
    int gwiazdki = 2 * wiersz - 1;

    for (int s = 1; s <= spacje; s++)
    {
        Console.Write(" ");
    }

    for (int g = 1; g <= gwiazdki; g++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int s = 1; s <= wysokosc - 1; s++)
{
    Console.Write(" ");
}
Console.WriteLine("*");