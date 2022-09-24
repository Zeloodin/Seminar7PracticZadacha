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

// m = 3 колличество строк
// n = 4 колличество рядов

// row      -   ряд      -   горизонталь   -   horizontal
// height   -   высота   -   вертикаль     -   vercical
// collum   -   столбец, колонна
// row      -   ряд
// string   -   строка.
// index    -   индекс

// длина  -  length.
// ширина -  width.


// 3D
// X = horizontal
// Y = horizontal
// Z = vercical

// 2D
// X = horizontal
// Y = vercical

// Стороны света        Cardinal direction
// С - Север   Сверху   N - North  Up      = 0°, 360°
// З - Запад   Слева    E - East   Left    = 90°
// Ю - Юг      Снизу    S - South  Down    = 180°
// В - Восток  Справа   W - West   Right   = 270°

using MyClassLibrary;

int m = 3, n = 4;
double[,] array2DNumbers = ArrayMy.Create2DArray(m, n);
array2DNumbers = ArrayMy.Fill2DArrayToNumbers(array2DNumbers, -10, 10, 1);

ArrayMy.WriteArray2D(array2DNumbers);