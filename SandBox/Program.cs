//Песочница




void FillArrayRnd(int[,] arrIn, int minValue = 0, int maxValue = 100)
{
  for (int i = 0; i < arrIn.GetLength(0); i++)
  {
    for (int j = 0; j < arrIn.GetLength(1); j++)
    {
      arrIn[i, j] = new Random().Next(minValue, maxValue);
    }
  }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.WriteLine("arr[" + i + "," + j + "] = " + arr[i, j]);
    }
  }
}

void ReplaceFirstAndLastArrayRow(int[,] arrIn)
{
  int tmpValue = 0;
  for (int j = 0; j < arrIn.GetLength(1); j++)
  {
    tmpValue = arrIn[0, j];
    arrIn[0, j] = arrIn[arrIn.GetLength(0) - 1, j];
    arrIn[arrIn.GetLength(0) - 1, j] = tmpValue;
  }
}

bool CorrectArraySize(int[,] arrIn)
{
  return arrIn.GetLength(0) == arrIn.GetLength(1);
}
int[,] ReplaceRowAndColumnInArray(int[,] arrIn)
{
  int[,] transformArray = new int[arrIn.GetLength(0), arrIn.GetLength(1)];
  for (int i = 0; i < arrIn.GetLength(0); i++)
  {
    for (int j = 0; j < arrIn.GetLength(1); j++)
    {
      transformArray[j, i] = arrIn[i, j];
    }
  }
  return transformArray;
}

//Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Задача 3: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
//Дополнительно: Сохранить треугольник в файл.






//вызов
Console.Clear();
int[,] testArray = new int[3, 3];
FillArrayRnd(testArray);
Console.WriteLine("Исходный массив: ");
PrintArray(testArray);
ReplaceFirstAndLastArrayRow(testArray);
Console.WriteLine("Массив после замены строк: ");
PrintArray(testArray);
if (!CorrectArraySize(testArray)) Console.WriteLine("Количество строк и столбцов в массиве не равны.");
int [,] newArray=ReplaceRowAndColumnInArray(testArray);
Console.WriteLine("Массив после замены трансформации строк и столбцов: ");
PrintArray (newArray);
//Console.Write("Произведение чисел: ");
//Console.WriteLine(RowMultiplication(testOutA, 1));
//Console.WriteLine(ColumnMultiplication(testOutA, 0));