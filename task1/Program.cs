// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());
int i = 1;
int result = 1;

while (i <= b)
{
    result = (result * a);
    i++;
}
    Console.WriteLine($"a в степени b равен {result}");