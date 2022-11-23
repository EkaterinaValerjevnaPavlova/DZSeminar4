/*
Задача 29: Напишите программу, которая задаёт массив 
из N элементов и выводит их на экран. 
Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [N];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0,100);
}

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PtintArray(numbers);
