// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 
// Например, задан массив:
// 
// 1   4   7   2
// 
// 5   9   2   3
// 
// 8   4   2   4
// 
// 17 -> такого числа в массиве нет


// input: 1 2
// 1 = позиция строки.
// 2 = позиция ряда.
// output: 2 из массива, по координатам.

// новый массив ArraySaveFindAll, который хранит координаты значений в указанном массиве 
// {
// {"1", 0, 0}, {"4", 0, 1}, {"7", 0, 2}, {"2", 0, 3},
// {"5", 1, 0}, {"9", 1, 1}, {"2", 1, 2}, {"3", 1, 3},
// {"8", 2, 0}, {"4", 2, 1}, {"2", 2, 2}, {"4", 2, 3}
// }

// массив ArraySaveFindAll, отсортированн по возрастанию.
// {
// {"1", 0, 0}, {"2", 0, 3}, {"2", 1, 2}, {"2", 2, 2},
// {"3", 1, 3}, {"4", 0, 1}, {"4", 2, 1}, {"4", 2, 3},
// {"5", 1, 0}, {"7", 0, 2}, {"8", 2, 0}, {"9", 1, 1}
// }

using MyClassLibrary;


// Для проверки
// int[,] testArray = new int[,]
// {
// {1, 4, 7, 2},
// {5, 9, 2, 3},
// {8, 4, 2, 4}
// };

double[,] testArray = ArrayMy.Fill2DArrayToNumbers(ArrayMy.Create2DArray(25,25), lengthOfDigitAfterDecimalPoint: 0, fromMinNumber: -100, toMaxNumber: 100);

ArrayMy.WriteArray2D(testArray);
Console.Write("Введите позицию строки: ");
int rowPosition = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите позицию столбца: ");
int collumPosition = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write($"Позиция в массиве [{rowPosition}, {collumPosition}]: ");
ArrayMy.WriteArray2D(ArrayMy.SearchInArray2D(inputArray: testArray, elementToFind: "", mode: 3, inputRow: rowPosition, inputCollum: collumPosition));

Console.Write("Введите значение для поиска в массиве: ");
string elementFind = Convert.ToString(Console.ReadLine());
ArrayMy.WriteArray2D(ArrayMy.SearchInArray2D(inputArray: testArray, elementToFind: elementFind, mode: 0, inputRow: rowPosition, inputCollum: collumPosition));



