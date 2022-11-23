/*
Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число 
A в натуральную степень B.
Без использования функции Math.Pow.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Write("Введите число A: ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int namberB = Convert.ToInt32(Console.ReadLine());

int exp = namberA;
for (int i = 1; i<namberB; i++)
{
    exp *= namberA;
}
Console.Write(exp);

