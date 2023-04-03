/*
Задача 47. Задайте двумерный массив размером m × n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double [,] Array = new double[3,4];
Random rand= new Random();
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
     Array[i, j] =Math.Round(rand.Next(-100, 100) *0.1, 1);
            Console.Write($" {Array[i, j],1} ");
    }
    
    Console.WriteLine();
}



