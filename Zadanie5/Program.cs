

int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool ucieczka = false;

while (zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0 && !ucieczka)
{
    Console.WriteLine();
    Console.WriteLine($"=== Tura {numerTury} ===");
    Console.WriteLine($"Bohater: {zdrowieBohatera} HP | Przeciwnik: {zdrowiePrzeciwnika} HP | Mikstury: {liczbaMikstur}");
    Console.WriteLine("1 - Atak");
    Console.WriteLine("2 - Mikstura");
    Console.WriteLine("3 - Ucieczka");
    Console.Write("Wybierz akcję: ");

    string akcja = Console.ReadLine()!;

    switch (akcja)
    {
        case "1":
            zdrowiePrzeciwnika -= 12;
            Console.WriteLine("Atakujesz i zadajesz 12 punktów obrażeń.");
            break;
        case "2":
            if (liczbaMikstur > 0)
            {
                zdrowieBohatera += 15;
                liczbaMikstur--;
                Console.WriteLine("Używasz mikstury i odzyskujesz 15 punktów życia.");
            }
            else
            {
                Console.WriteLine("Nie masz już mikstur. Tracisz turę.");
            }
            break;
        case "3":
            ucieczka = true;
            continue;
        default:
            Console.WriteLine("Nieznana opcja.");
            continue;
    }

    if (zdrowiePrzeciwnika > 0)
    {
        zdrowieBohatera -= 7;
        Console.WriteLine("Przeciwnik zadaje ci 7 punktów obrażeń.");
    }

    numerTury++;
}

Console.WriteLine();
if (ucieczka)
{
    Console.WriteLine("Uciekłeś z walki.");
}
else if (zdrowieBohatera <= 0)
{
    Console.WriteLine("Porażka! Bohater poległ.");
}
else
{
    Console.WriteLine("Zwycięstwo! Pokonałeś przeciwnika.");
}
