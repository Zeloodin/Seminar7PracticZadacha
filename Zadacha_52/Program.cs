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

// int[,] arrayNums = ;

double[] nums = ArrayMy.Fill2DArrayToNumbers(ArrayMy.Create2DArray(15,15));
int[] numsToInt = ConvertArrayToInt32(nums);


int[,] ConvertArray2DToInt32<T>(T inputArray2D, string convertToType = "ToInt32")
{
    int rowsCount = inputArray2D.GetUpperBound(0) + 1;   // Колличество строк
    int collumsCount = inputArray2D.Length / rowsCount;  // Колличество столбцов
    int[,] convertedInputArray = new int[rowsCount,collumsCount];

    for (int row = 0; row < rowsCount; row++)
    {
        for (int collum = 0; collum < collumsCount; collum++)
        {
            convertedInputArray[row,collum] = Convert.convertToType(inputArray2D[row,collum]);
        }
    }
    return convertedInputArray;
}

ArrayMy.WriteArray2D(nums);
ArrayMy.WriteArray2D(numsToInt);