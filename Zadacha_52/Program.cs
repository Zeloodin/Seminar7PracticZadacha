// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//
// Например, задан массив:
//
// 1  4  7  2
//
// 5  9  2  3
//
// 8  4  2  4
//
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//

using MyClassLibrary;


int[,] arrayNums = ConvertMy.ConvertArray2DToInt32(ArrayMy.Fill2DArrayToNumbers(ArrayMy.Create2DArray(3,3)));



ArrayMy.WriteArray2D(arrayNums);

Console.WriteLine("Среднее арифметическое каждого столбца: "+
              $"{String.Join("; ",ArrayMy.Array2DSumRowsAverage(arrayNums, 1))}.");
Console.WriteLine("Среднее арифметическое каждого ряда: "+
              $"{String.Join("; ",ArrayMy.Array2DSumCollumsAverage(arrayNums, 1))}.");

