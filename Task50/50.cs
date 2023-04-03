/*
Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] array = new int [3,4 ];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($" {array[i, j], 1} ");
    }
    Console.WriteLine();
}
Console.Write($"Введите строку: ");
int x = Convert.ToInt32(Console.ReadLine()) -1;
Console.Write($"Введите столбец: ");
int y = Convert.ToInt32(Console.ReadLine()) -1;
Console.WriteLine();

try
{
    Console.WriteLine(array[x, y]);
}
catch
{
    Console.WriteLine($"Такого значаения НеТ ");
}