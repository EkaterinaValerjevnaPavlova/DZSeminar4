/*
Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (namber>0)
{
        sum += namber%10;
        namber /= 10;
}
Console.WriteLine($"сумма цифр в числе  {sum}");




