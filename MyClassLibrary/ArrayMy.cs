namespace MyClassLibrary;

public class ArrayMy
{
    /// Показывает одномерный массив.
    static public void WriteArray<T>(T[] inputArray, string spaceEnd = "")
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write(inputArray[i] + spaceEnd);
        }
    }

    /// Показывает двумерный массив.
    static public void WriteArray2D<T>(T[,] inputArrayND)
    {
        int rowsCount = inputArrayND.GetUpperBound(0) + 1;    // Колличество строк
        int collumsCount = inputArrayND.Length / rowsCount;        // Колличество столбцов

        for (int y = 0; y < rowsCount; y++)
        {
            for (int x = 0; x < collumsCount; x++)
            {
                Console.Write(inputArrayND[y, x] + " ");
            }
            Console.WriteLine();
        }
    }

    /// Создаёт двумерный массив.
    static public double[,] Create2DArray(int xCountRows, int yCountCollums)
    {
        double[,] array2D = new double[xCountRows, yCountCollums];
        return array2D;
    }

    /// Заполняет числами в двумерный массив.
    static public double[,] Fill2DArrayToNumbers(double[,] inputArray2D, int fromMinNumber, int toMaxNumber, int lengthOfDigitAfterDecimalPoint = 0)
    {
        int rowsCount = inputArray2D.GetUpperBound(0) + 1;    // Колличество строк
        int collumsCount = inputArray2D.Length / rowsCount;        // Колличество столбцов

        for (int xCountRows = 0; xCountRows < rowsCount; xCountRows++)
        {
            for (int yCountCollums = 0; yCountCollums < collumsCount; yCountCollums++)
            {
                if (lengthOfDigitAfterDecimalPoint != 0)
                {
                    inputArray2D[xCountRows, yCountCollums] = Convert.ToDouble(new Random()
                                                        .Next(fromMinNumber * lengthOfDigitAfterDecimalPoint
                                                        , toMaxNumber * lengthOfDigitAfterDecimalPoint)) / lengthOfDigitAfterDecimalPoint;
                }
                else
                {
                    inputArray2D[xCountRows, yCountCollums] = Convert.ToDouble(new Random().Next(fromMinNumber, toMaxNumber));
                }
            }
        }
        return inputArray2D;
    }
}
