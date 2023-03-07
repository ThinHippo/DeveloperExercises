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

int[,] PascalsTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  if (row > 3)
  {
    int newRow = 0;
    int newColumn = 0;
    for (int i = 1; i < row - 1; i++)//строки треугольника
    {
      for (int j = 0; j < i; j++)//столбцы треугольника
      {
        newRow = i + 1;
        newColumn = j + 1;
        triangle[newRow, newColumn] = triangle[i, j] + triangle[i, newColumn];
      }
    }
  }
  return triangle;
}
void PrintTriangle(string [] arrIn)
{
  for (int i = 0; i < arrIn.GetLength(0); i++)
  {
    Console.WriteLine(arrIn[i]);
  }
}
string[] TriangleAsTriangle(int[,] arrIn)
{
  string[] asTriangle = new string[arrIn.GetLength(0)];
  string row = string.Empty;
  for (int i = 0; i < asTriangle.Length; i++)
  {
    for (int j = 0; j <= i; j++)
    {
      row = row + $"{arrIn[i, j],7}";
    }
    asTriangle[i] = row;
    row = string.Empty;
  }
  return asTriangle;
}
void PrintAsTriangle(string[] arr)
{
  string emptyText=string.Empty;
  int maxlen = arr[arr.Length - 1].Length / 2;
  int pad = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    emptyText=string.Empty;
    pad = maxlen - arr[i].Length / 2;
    emptyText=emptyText.PadLeft(pad);
    arr[i] =  emptyText + arr[i];
  }
  for (int i = 0; i < arr.Length; i++)
  {
    Console.WriteLine(arr[i]);
  }

}

//вызов
Console.Clear();
int[,] testArray = PascalsTriangle(25);
//PrintTriangle(testArray);
PrintAsTriangle(TriangleAsTriangle(testArray));