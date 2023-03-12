/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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

void ОrderedString (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int [,] newArray = Create2dArray ();
Show2dArray(newArray);
ОrderedString(newArray);
Show2dArray(newArray);





