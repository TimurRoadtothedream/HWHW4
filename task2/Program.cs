// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int n = 0;

while (N > 0)
{
    n = N % 10;
    sum = sum + n;
    N = N/10;
}
Console.WriteLine($"Сумма всех чисел равна: {sum}");
