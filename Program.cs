// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj liczbę: ");
int a = Int32.Parse(Console.ReadLine());
/*
if (a % 2 == 0)
{
    Console.WriteLine($"Liczba {a} jest parzysta");
}
else
{
    Console.WriteLine($"Liczba {a} nie jest parzysta"); */
}
if (a < 0)
{
    Console.WriteLine($"Liczba {a}  jest ujemna");
}
else
{
    Console.WriteLine($"Liczba {a} jest dodatnia");
}
