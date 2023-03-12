//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] Create2dArray ()
{
    Console.Write("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input minimal possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input maximal possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] CreatedArray = new int [rows , columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            CreatedArray [i , j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return CreatedArray;
}
void Show2dArray (int [,]array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RowSmallestSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array [0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}
int [,] newArray = Create2dArray ();
Show2dArray(newArray);
RowSmallestSum(newArray);

