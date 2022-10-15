// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
      Console.WriteLine(); 
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int m, int n)
{
  int[,] resultMatrix = InitializateArray(m, n);

  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  } 
  return resultMatrix;
}



//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите количество строк 1-ой матрицы m: ");
int n = GetNumberFromConsole("Введите количество столбцов 1-ой матрицы и количество строк 2-ой матрицы n: ");
int p = GetNumberFromConsole("Введите количесиво столбцов 2-ой матрицы p: ");
int[,] matrix1 = InitializateArray(m,n);
int[,] matrix2 = InitializateArray(n,p);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в матрицах: ");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в матрицах: ");
FillArray(matrix1, minValue, maxValue);
FillArray(matrix2, minValue, maxValue);
Console.WriteLine("Заданные матрицы: ");
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц: ");
PrintArray( MultiplyMatrix(matrix1, matrix2, m, n));
