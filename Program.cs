// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().NextDouble() * 10;
//         Console.Write(matrix[i, j] + "\t");
       
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] matrix = new int[5, 2];
// Console.WriteLine("Введите индекс элемента (строка)");
// int findIndexRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс элемента (столбец)");
// int findIndexColumns = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// if(findIndexColumns > (matrix.GetLength(1) - 1) || findIndexRows > (matrix.GetLength(0)- 1))
//     {
//         Console.WriteLine("Такого числа в массиве нет");
//     }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//           if (i == findIndexRows && j == findIndexColumns)
//         {
//             Console.WriteLine($"Значение элемента находящегося на указанных индексах - {matrix[i, j]}");
//         }  
//     }
// }






// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// int [] sum = new int [columns];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//          sum[i] += matrix[j, i]; 
//     }
// }
// for(int i = 0; i < columns; i ++)
// {
//     Console.Write((sum[i] / rows) + " ");
// }