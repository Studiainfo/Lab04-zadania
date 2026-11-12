Console.Write("Rosnąco(while): ");
int a = 1;
while (a <= 10)
{
    Console.Write(a + " ");
    a++;
}
Console.WriteLine();

Console.Write("Rosnąco(do while): ");
int b = 1;
do
{
    Console.Write(b + " ");
    b++;
}
while(b <= 10);
Console.WriteLine();

Console.Write("Rosnąco(for): ");
for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.Write("Malejąco: ");
for (int i = 10; i >= 1; i--)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.Write("Parzyste: ");
for (int i = 0; i <= 20; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.WriteLine("Start!");