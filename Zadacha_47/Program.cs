// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 
//  ________________________
//  | 0,5   7    -2   -0,2 |
//  |                      |
//  | 1    -3,3   8   -9,9 |
//  |                      |
//  | 8     7,8  -7,1  9   |
//  ________________________

using MyClassLibrary;

int m = 3, n = 4;
double[,] array2DNumbers = ArrayMy.Create2DArray(m, n);
array2DNumbers = ArrayMy.Fill2DArrayToNumbers(array2DNumbers, -10, 10, 1);

ArrayMy.WriteArray2D(array2DNumbers);