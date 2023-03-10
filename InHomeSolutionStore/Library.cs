public static class ArrayMethod
{
  //Создание массива
  public static void CreateArray(out int[] array, bool allowLimit = true, int minSize = 3, int maxSize = 10)//random+int
  {
    int size;
    if (!allowLimit)
    {
      size = new Random().Next(minSize, maxSize + 1);
    }
    else
    {
      bool inLimit = false;
      do
      {
        size = new Random().Next(minSize, maxSize + 1);
        inLimit = (size >= minSize && size <= maxSize);
      }
      while (!inLimit);
    }
    array = new int[size];
  }
  public static void CreateArray(out double[] array, bool allowLimit = true, int minSize = 3, int maxSize = 10)//random+double
  {
    int size;
    if (!allowLimit)
    {
      size = new Random().Next(minSize, maxSize + 1);
    }
    else
    {
      bool inLimit = false;
      do
      {
        size = new Random().Next(minSize, maxSize + 1);
        inLimit = (size >= minSize && size <= maxSize);
      }
      while (!inLimit);
    }
    array = new double[size];
  }
  public static void CreateArray(out double[] array, bool allowLimit = true, int minSize = 3, int maxSize = 10, string msg = "Укажите размер массива: ")//user+double
  {
    int size = UserEntersArraySize(allowLimit, minSize, minSize, msg);
    array = new double[size];
  }
  public static void CreateArray(out int[] array, bool allowLimit = true, int minSize = 3, int maxSize = 10, string msg = "Укажите размер массива: ")//user+int
  {
    int size = UserEntersArraySize(allowLimit, minSize, maxSize, msg);
    array = new int[size];
  }
  private static int UserEntersArraySize(bool withLimit, int minSize, int maxSize, string msg)
  {
    int size;
    bool gooduser;
    do
    {
      if (withLimit) Console.WriteLine("\nРазмер определён диапазоном от " + minSize + " до " + maxSize + " включительно.");
      Console.Write(msg);
      gooduser = int.TryParse(Console.ReadLine(), out size);
      if (gooduser && withLimit) gooduser = (size >= minSize && size <= maxSize);
    }
    while (!gooduser);
    return size;
  }
  public static void CreateArray(out double[,] array, bool allowLimit = true, int minSize = 3, int maxSize = 10, string msg = "Укажите размер двумерного массива")
  {
    int rowSize = UserEntersArraySize(allowLimit, minSize, maxSize, "Введите количество строк: ");
    int columnSize = UserEntersArraySize(allowLimit, minSize, maxSize, "Введите количество столбцов: ");
    array = new double[rowSize, columnSize];
  }
  public static void CreateArray(out int[,] array, bool allowLimit = true, int minSize = 3, int maxSize = 10, string msg = "Укажите размер двумерного массива")
  {
    int rowSize = UserEntersArraySize(allowLimit, minSize, maxSize, "Введите количество строк: ");
    int columnSize = UserEntersArraySize(allowLimit, minSize, maxSize, "Введите количество столбцов: ");
    array = new int[rowSize, columnSize];
  }
  public static void CreateArray(out int[,] array, int minSize = 3, int maxSize = 10)
  {
    int rows = new Random().Next(minSize, maxSize + 1);
    int columns = new Random().Next(minSize, maxSize + 1);
    array = new int[rows, columns];
  }
  public static void CreateArray(out int[,,] array, int minSize = 3, int maxSize = 10)
  {
    int rows = new Random().Next(minSize, maxSize + 1);
    int columns = new Random().Next(minSize, maxSize + 1);
    int deep = new Random().Next(minSize, maxSize + 1);
    array = new int[rows, columns, deep];
  }
  //Заполнение массива
  public static void FillArray(int[] arr, bool allowLimit = false, int minValue = 0, int maxValue = 100, bool byUser = true, string msg = "Введите поочередно все элементы массива.")
  {
    for (int index = 0; index < arr.Length; index++)
    {
      switch (byUser)
      {
        case true:
          {
            UserFillArray(arr, allowLimit, minValue, maxValue, msg);
            break;
          }
        case false:
          {
            RandomFillArray(arr, minValue, maxValue);
            break;
          }
      }
    }
  }
  public static void FillArray(double[] arr, bool allowLimit = false, int minValue = 0, int maxValue = 100, bool byUser = true, string msg = "Введите поочередно все элементы массива.")
  {
    for (int index = 0; index < arr.Length; index++)
    {
      switch (byUser)
      {
        case true:
          {
            UserFillArray(arr, allowLimit, minValue, maxValue, msg);
            break;
          }
        case false:
          {
            RandomFillArray(arr, minValue, maxValue);
            break;
          }
      }
    }
  }
  public static void FillArray(double[,] arr, bool allowLimit = false, int minValue = 0, int maxValue = 100, int round = 3, bool byUser = true, string msg = "Введите поочередно все элементы массива.")
  {
    for (int index = 0; index < arr.Length; index++)
    {
      switch (byUser)
      {
        case true:
          {
            UserFillArray(arr, allowLimit, minValue, maxValue, round, msg);
            break;
          }
        case false:
          {
            RandomFillArray(arr, minValue, maxValue, round);
            break;
          }
      }
    }
  }
  public static void FillArray(int[,] arr, bool allowLimit = false, int minValue = 0, int maxValue = 100, bool byUser = true, string msg = "Введите поочередно все элементы массива.")
  {
    for (int index = 0; index < arr.Length; index++)
    {
      switch (byUser)
      {
        case true:
          {
            UserFillArray(arr, allowLimit, minValue, maxValue, msg);
            break;
          }
        case false:
          {
            RandomFillArray(arr, minValue, maxValue);
            break;
          }
      }
    }
  }
  private static void UserFillArray(int[] arr, bool withLimit, int minValue, int maxValue, string msg = "Введите поочередно все элементы массива.")
  {
    int value;
    bool gooduser;
    Console.WriteLine(msg);
    for (int index = 0; index < arr.Length; index++)
    {
      do
      {
        Console.Write("Введите " + index + " элемент: ");
        gooduser = int.TryParse(Console.ReadLine(), out value);
        if (gooduser && withLimit) gooduser = (value >= minValue && value <= maxValue);
      }
      while (!gooduser);
      arr[index] = value;
    }
  }
  private static void UserFillArray(double[] arr, bool withLimit, int minValue, int maxValue, string msg = "Введите поочередно все элементы массива.")
  {
    double value;
    bool gooduser;
    Console.WriteLine(msg);
    for (int index = 0; index < arr.Length; index++)
    {
      do
      {
        Console.Write("Введите " + index + " элемент: ");
        gooduser = double.TryParse(Console.ReadLine(), out value);
        if (gooduser && withLimit) gooduser = (value >= minValue && value <= maxValue);
      }
      while (!gooduser);
      arr[index] = value;
    }
  }
  private static void UserFillArray(double[,] arr, bool withLimit, int minValue, int maxValue, int round, string msg = "Введите поочередно все элементы массива.")
  {
    double value;
    bool gooduser;
    Console.WriteLine(msg);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        do
        {
          Console.Write("Введите элемент [{0;1}]: ", i, j);
          gooduser = double.TryParse(Console.ReadLine(), out value);
          if (gooduser && withLimit) gooduser = (value >= minValue && value <= maxValue);
        }
        while (!gooduser);
        arr[i, j] = Math.Round(value, round);
      }
    }
  }
  private static void UserFillArray(int[,] arr, bool withLimit, int minValue, int maxValue, string msg = "Введите поочередно все элементы массива.")
  {
    int value;
    bool gooduser;
    Console.WriteLine(msg);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        do
        {
          Console.Write("Введите элемент [{0;1}]: ", i, j);
          gooduser = int.TryParse(Console.ReadLine(), out value);
          if (gooduser && withLimit) gooduser = (value >= minValue && value <= maxValue);
        }
        while (!gooduser);
        arr[i, j] = value;
      }
    }
  }
  private static void RandomFillArray(int[] arr, int min, int max)
  {
    for (int index = 0; index < arr.Length; index++)
    {
      arr[index] = new Random().Next(min, max + 1);
    }
  }
  private static void RandomFillArray(double[] arr, int min, int max)
  {
    for (int index = 0; index < arr.Length; index++)
    {
      arr[index] = new Random().NextDouble() + new Random().Next(min, max);
    }
  }
  private static void RandomFillArray(double[,] arr, int min, int max, int round)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        arr[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), round);
      }
    }
  }
  private static void RandomFillArray(int[,] arr, int min, int max)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        arr[i, j] = new Random().Next(min, max + 1);
      }
    }
  }
  public static void FillArrayWithUniqValues(int[,] array, int min, int max)
  {
    int uniq = 0;
    int[] uniqs = new int[array.GetLength(0) * array.GetLength(1)];
    int entry = 0;
    for (int i = 0; i < uniqs.Length; i++)
    {
      do
      {
        uniq = new Random().Next(min, max + 1);
        entry = Array.IndexOf(uniqs, uniq);
      }
      while (entry != -1);
      uniqs[i] = uniq;
    }
    int u = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = uniqs[u];
        u++;
      }
    }
  }
  public static void FillArrayWithUniqValues(int[,,] array, int min, int max, int step = 1)
  {
    int[] values = GetUniqValues(min, max, step);
    int v = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int q = 0; q < array.GetLength(2); q++)
        {
          array[i, j, q] = values[v];
          v++;
        }
      }
    }
  }
  public static int[] GetUniqValues(int min, int max, int step = 1)
  {
    int[] values = new int[(max - min + 1) / step];
    for (int i = 0; i < values.Length; i++)
    {
      values[i] = min;
      min = min + step;
    }
    for (int i = 0; i < values.Length - 1; i++)
    {
      int position = new Random().Next(i + 1, values.Length);
      (values[i], values[position]) = (values[position], values[i]);
    }
    return values;
  }
  public static int CountOfPossibleUniqValue(int min, int max, int step = 1)
  {
    return (max - min + 1) / step;
  }
  public static int CountOfPossibleUniqValue(double min, double max, double step = 0.1)
  {
    return Convert.ToInt32((max - min + 1) / step);
  }
  public static int MaxArraySizeByCountOfPossibleValues(int rank, int countValues)
  {
    double root = 1.0 / rank;
    return Convert.ToInt32(Math.Pow(Convert.ToDouble(countValues), root));
  }
  //Сумма элементов массива в зависимости от знака числа (+/-)
  public static double ArrayItemSummByValuePositive(int[] arr, bool positive = true)//true - только положительные,false - только отрицательные
  {
    double result = 0;
    for (int index = 0; index < arr.Length; index++)
    {
      if (positive && arr[index] > 0) result = result + arr[index];
      if (!positive && arr[index] < 0) result = result + arr[index];
    }
    return result;
  }
  public static double ArrayItemSummByValuePositive(double[] arr, bool positive = true)//true - только положительные,false - только отрицательные
  {
    double result = 0;
    for (int index = 0; index < arr.Length; index++)
    {
      if (positive && arr[index] > 0) result = result + arr[index];
      if (!positive && arr[index] < 0) result = result + arr[index];
    }
    return result;
  }

  //Количество элементов массива в зависимости от четности значения
  public static int ArrayItemCountByValueParity(int[] arr, bool parity)//parity = true считаем чётные, false - нечетные
  {
    int result = 0;
    for (int index = 0; index < arr.Length; index++)
    {
      if (parity && arr[index] % 2 == 0) result++;//четные
      if (!parity && arr[index] % 2 != 0) result++;//нечетные
    }
    return result;
  }

  //Сумма значений массива в зависимости от четности индекса
  public static double ArrayItemSummByPositionParity(int[] arr, bool parity)
  {
    double result = 0;
    int index = 0;
    if (!parity) index = 1;
    while (index < arr.Length)
    {
      result = result + arr[index];
      index = index + 2;
    }
    return result;
  }
  public static double ArrayItemSummByPositionParity(double[] arr, bool parity)
  {
    double result = 0;
    int index = 0;
    if (!parity) index = 1;
    while (index < arr.Length)
    {
      result = result + arr[index];
      index = index + 2;
    }
    return result;
  }
  //Преобразование массива положительные значения в отрицательные и наоборот
  public static int[] NegativeArray(int[] arr)
  {
    int[] nArr = arr;
    for (int index = 0; index < nArr.Length; index++)
    {
      nArr[index] = nArr[index] * -1;
    }
    return nArr;
  }
  //Проверка вхождения числа в массив
  public static bool NumberInArray(int[] arr, int number)
  {
    for (int index = 0; index < arr.Length; index++)
    {
      if (arr[index] == number) return true;
    }
    return false;
  }
  public static bool NumberInArray(double[] arr, double number)
  {
    for (int index = 0; index < arr.Length; index++)
    {
      if (arr[index] == number) return true;
    }
    return false;
  }
  public static void ArraySortingByRowsOrColumns(int[,] array, bool ascending = true, bool row = true, int from = 0, int to = 0)
  {
    for (int i = from; i <= to; i++)
    {
      SortingSingleRowOrColumn(array, i, ascending, row);
    }
  }
  private static void SortingSingleRowOrColumn(int[,] array, int index, bool ascending = true, bool row = true)
  {
    if (row)
    {
      int[] tmpArray = new int[array.GetLength(1)];
      for (int i = 0; i < tmpArray.Length; i++)
      {
        tmpArray[i] = array[index, i];
      }
      Array.Sort(tmpArray);
      if (!ascending) Array.Reverse(tmpArray);
      for (int i = 0; i < tmpArray.Length; i++)
      {
        array[index, i] = tmpArray[i];
      }
    }
    else
    {
      int[] tmpArray = new int[array.GetLength(0)];
      for (int i = 0; i < tmpArray.Length; i++)
      {
        tmpArray[i] = array[i, index];
      }
      Array.Sort(tmpArray);
      if (!ascending) Array.Reverse(tmpArray);
      for (int i = 0; i < tmpArray.Length; i++)
      {
        array[i, index] = tmpArray[i];
      }
    }
  }
  //Вычисление среднего арифметического по строкам/столбцам двумерного массива
  public static double[,] CalculateAverageOfArrayItems(int[,] arr, bool row = true)
  {
    double[,] avgArr;
    double summ = 0;
    if (row)
    {
      avgArr = new double[arr.GetLength(0), 1];
      for (int i = 0; i < arr.GetLength(0); i++)
      {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          summ = summ + arr[i, j];
        }
        avgArr[i, 0] = summ / arr.GetLength(0);
      }
    }
    else
    {
      avgArr = new double[1, arr.GetLength(1)];
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        summ = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
          summ = summ + arr[i, j];
        }
        avgArr[0, j] = summ / arr.GetLength(1);
      }
    }
    return avgArr;
  }
  public static int[,] BuildPascalsTriangle(int row)
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
  //Формирование строки из значений массива
  public static string ArrayAsString(int[] arr, string separator = ", ") => string.Join(separator, arr);
  public static string ArrayAsString(double[] arr, string separator = ", ") => string.Join(separator, arr);
  public static string ArrayAsString(string[] arr, string separator) => string.Join(separator, arr);

  public static string ArrayAsString(int[,] arr, bool writeline = true, string separator = " ")
  {
    string output = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        output = output + separator + arr[i, j];
      }
      output = output + "\n";
    }
    if (writeline) Console.WriteLine(output);
    return output.Trim();
  }
  public static string ArrayAsString(double[,] arr, bool writeline = true, string separator = " ")
  {
    string output = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        output = output + separator + arr[i, j];
      }
      output = output + "\n";
    }
    if (writeline) Console.WriteLine(output);
    return output.Trim();
  }
  public static void PrintTabularView(int[,] arr)
  {
    int minLen = GetMaxLenItemInArray(arr) + 2;
    int padLeft = 0;
    string padIn = string.Empty;
    string padOut = " ";
    string[,] output = new string[arr.GetLength(0), arr.GetLength(1)];
    string tmpRow = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        padIn = string.Empty;
        padLeft = minLen - Convert.ToString(arr[i, j]).Length - 1;
        padIn = padIn.PadLeft(padLeft);
        output[i, j] = padIn + Convert.ToString(arr[i, j]) + padOut;
      }
    }
    for (int i = 0; i < output.GetLength(0); i++)
    {
      for (int j = 0; j < output.GetLength(1); j++)
      {
        tmpRow = tmpRow + output[i, j];
      }
      Console.WriteLine(tmpRow);
      tmpRow = string.Empty;
    }
  }
  public static void PrintTabularView(double[,] arr)
  {
    int minLen = GetMaxLenItemInArray(arr) + 2;
    int padLeft = 0;
    string padIn = string.Empty;
    string padOut = " ";
    string[,] output = new string[arr.GetLength(0), arr.GetLength(1)];
    string tmpRow = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        padIn = string.Empty;
        padLeft = minLen - Convert.ToString(arr[i, j]).Length - 1;
        padIn = padIn.PadLeft(padLeft);
        output[i, j] = padIn + Convert.ToString(arr[i, j]) + padOut;
      }
    }
    for (int i = 0; i < output.GetLength(0); i++)
    {
      for (int j = 0; j < output.GetLength(1); j++)
      {
        tmpRow = tmpRow + output[i, j];
      }
      Console.WriteLine(tmpRow);
      tmpRow = string.Empty;
    }
  }
  public static void PrintTabularView(int[,,] arr, bool withindex = true)
  {
    int minLen = GetMaxLenItemInArray(arr) + 2;
    string output = string.Empty;
    for (int q = 0; q < arr.GetLength(2); q++)
    {
      Console.WriteLine($"{q+1}-й слой массива:");
      for (int i = 0; i < arr.GetLength(0); i++)
      {
        output = string.Empty;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          output = $"{output}{arr[i, j, q],5}";
          if (withindex) output = $"{output}" + $"({i},{j},{q}) ";
        }
        Console.WriteLine(output);
      }
    }
  }
  private static int GetMaxLenItemInArray(int[,] arr)
  {
    int maxValue = arr[0, 0];
    int minValue = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        if (arr[i, j] > maxValue) maxValue = arr[i, j];
        if (arr[i, j] < minValue) minValue = arr[i, j];
      }
    }
    int maxLen = Convert.ToString(maxValue).Length + 1;
    if (Convert.ToString(minValue).Length > maxLen) maxLen = Convert.ToString(minValue).Length + 1;
    return maxLen;
  }
  private static int GetMaxLenItemInArray(int[,,] arr)
  {
    int maxValue = arr[0, 0, 0];
    int minValue = arr[0, 0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        for (int q = 0; q < arr.GetLength(2); q++)
        {
          if (arr[i, j, q] > maxValue) maxValue = arr[i, j, q];
          if (arr[i, j, q] < minValue) minValue = arr[i, j, q];
        }

      }
    }
    int maxLen = Convert.ToString(maxValue).Length + 1;
    if (Convert.ToString(minValue).Length > maxLen) maxLen = Convert.ToString(minValue).Length + 1;
    return maxLen;
  }
  private static int GetMaxLenItemInArray(double[,] arr)
  {
    double maxValue = arr[0, 0];
    double minValue = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        if (arr[i, j] > maxValue) maxValue = arr[i, j];
        if (arr[i, j] < minValue) minValue = arr[i, j];
      }
    }
    int maxLen = Convert.ToString(maxValue).Length + 1;
    if (Convert.ToString(minValue).Length > maxLen) maxLen = Convert.ToString(minValue).Length + 1;
    return maxLen;
  }
  //Получение массива через разделение строки
  public static void ArrayViaSplit(out string[] arr, string text, string separator = ", ")
  {
    arr = text.Split(separator);
  }
  public static void ArrayViaSplit(out int[] arr, string text, string separator)
  {
    ArrayViaSplit(out string[] arrString, text, separator);
    arr = new int[arrString.Length];
    int value = 0;
    for (int index = 0; index < arr.Length; index++)
    {
      if (int.TryParse(arrString[index], out value)) arr[index] = value;
    }
  }
  public static void ArrayViaSplit(out double[] arr, string text, string separator)
  {
    ArrayViaSplit(out string[] arrString, text, separator);
    arr = new double[arrString.Length];
    double value = 0;
    for (int index = 0; index < arr.Length; index++)
    {
      if (double.TryParse(arrString[index], out value)) arr[index] = value;
    }
  }

  //Максимальное значение в массиве
  public static double MaxValueInArray(double[] arr) => arr.Max();
  public static double MaxValueInArray(int[] arr) => arr.Max();

  //Минимальное значение в массиве
  public static double MinValueInArray(double[] arr) => arr.Min();
  public static double MinValueInArray(int[] arr) => arr.Min();

  //Поиск элемента по индексам
  public static bool GetArrayItemByPosition(int[,] array, int row, int column, out int item)
  {
    bool correct = true;
    item = 0;
    try
    {
      item = array[row, column];
    }
    catch
    {
      correct = false;
    }
    return correct;
  }
  public static int GetArrayRowOrColumnIndexByMinSumm(int[,] array, bool row = true, bool print = true)
  {
    int index = 0;
    long minSumm = 0;
    long tmpSumm = 0;
    if (row)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        tmpSumm = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          tmpSumm += array[i, j];
        }
        if (i == 0) minSumm = tmpSumm;
        if (tmpSumm < minSumm)
        {
         minSumm=tmpSumm;
         index = i; 
        } 
        if (print) Console.WriteLine($"Строка {i} сумма элементов {tmpSumm}");
      }
    }
    else
    {
      for (int i = 0; i < array.GetLength(1); i++)
      {
        tmpSumm = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
          tmpSumm += array[i, j];
        }
        if (i == 0) minSumm = tmpSumm;
        if (tmpSumm < minSumm) index = i;
        if (print) Console.WriteLine($"Столбец {i} сумма элементов {tmpSumm}");
      }
    }
    return index;
  }
}

//Математические функции
public class MathMethod
{
  //Возведение числа в степень
  public static double NumberToPower(double number, int power)
  {
    if (power == 0) return 1;
    int mult = 1;
    if (power < 0) mult = -1;
    power = power * mult;
    double result = 1;
    for (int i = 1; i <= power; i++)
    {
      result = result * number;
    }
    if (mult == -1) result = 1 / result;
    return result;
  }
  //Сумма всех цифр в числе
  public static long AllDigitInNumberSumm(long number)
  {
    long result = 0;
    while (number > 0)
    {
      result = result + number % 10;
      number = number / 10;
    }
    return result;
  }
  //Подсчет количества положельных/отрицательных значений из введенных пользователем
  public static int CountingNumbersBySignInUserEnters(string msg, bool positive = true, bool printnumbers = false)
  {
    Console.WriteLine(msg);
    int tmpCount = 0;
    double[] userNumbers = UserBuildArray();
    if (printnumbers) Console.WriteLine("Введены числа: " + string.Join(", ", userNumbers));
    if (userNumbers.Length > 0)
    {
      for (int i = 0; i < userNumbers.Length; i++)
      {
        if (positive && userNumbers[i] > 0) tmpCount++;
        if (!positive && userNumbers[i] < 0) tmpCount++;
      }
    }
    else
    {
      Console.WriteLine("Пользователь не ввёл ни одного числа");
    }
    return tmpCount;
  }
  private static double[] UserBuildArray()
  {
    bool gooduser = true;
    double tmpValue = 0;
    int tmpCount = 0;
    double[] returnArray = new double[0];
    do
    {
      gooduser = double.TryParse(Console.ReadLine(), out tmpValue);
      if (gooduser)
      {
        tmpCount++;
        Array.Resize(ref returnArray, tmpCount);
        returnArray[tmpCount - 1] = tmpValue;
      }
    }
    while (gooduser);
    return returnArray;
  }
  //Получение от пользователя значений угловых коэффициентов и коэффициентов сдвига для линейных функций
  public static void GetLineFunctionShiftAndAngle(double[,] lines, string msg)
  {
    Console.WriteLine(msg);
    double tmpValue = 0;
    string[] prompt = { "k", "b" };
    for (int i = 0; i < lines.GetLength(0); i++)
    {
      for (int j = 0; j < lines.GetLength(1); j++)
      {
        UserEntersNumber(out tmpValue, "Введите значение " + prompt[j] + "(" + (i + 1) + "): ");
        lines[i, j] = tmpValue;
      }
    }
  }
  //Получение координат точки пересечения графиков двух линенйых функций
  public static double[,] GetIntersectionPointsOfLines(double[,] lines, int firstLineIndex = 0, int secondLineIndex = 1)
  {
    double[,] points = new double[1, 2];
    if (lines[firstLineIndex, 0] != lines[secondLineIndex, 0])
    {
      points[0, 0] = (lines[secondLineIndex, 1] - lines[firstLineIndex, 1]) / (lines[firstLineIndex, 0] - lines[secondLineIndex, 0]);//X)
      points[0, 1] = (lines[firstLineIndex, 0] * points[0, 0] + lines[firstLineIndex, 1]);//Y
    }
    else
    {
      points = new double[0, 0];
    }
    return points;
  }
  //приведение числа к виду -n привыводе в консоль формул уравнений
  public static string GetAdditionSymbol(double number)
  {
    string symbol = string.Empty;
    if (number > 0) symbol = "+" + number;
    else
    {
      symbol = Convert.ToString(number);
    }
    return symbol;
  }
  //Пользователь вводит число
  public static void UserEntersNumber(out double value, string msg)
  {
    double dNum;
    bool gooduser = false;
    do
    {
      Console.Write(msg);
      gooduser = double.TryParse(Console.ReadLine(), out dNum);
    }
    while (!gooduser);
    value = dNum;
  }
  public static void UserEntersNumber(out int value, string msg)
  {
    int iNum;
    bool gooduser = false;
    do
    {
      Console.Write(msg);
      gooduser = int.TryParse(Console.ReadLine(), out iNum);
    }
    while (!gooduser);
    value = iNum;
  }
  public static void UserEntersNumber(out long value, string msg)
  {
    long lNum;
    bool gooduser = false;
    do
    {
      Console.Write(msg);
      gooduser = long.TryParse(Console.ReadLine(), out lNum);
    }
    while (!gooduser);
    value = lNum;
  }
  public static void ShowNaturalNumbersInTheRange(int number)
  {
    Console.Write($"{number}");
    number--;
    if (number > 0)
    {
      Console.Write(", ");
      ShowNaturalNumbersInTheRange(number);
    }
  }
  public static int GetSummNaturalNumbersInTheRange(int leftNumber, int rightNumber, int summ)
  {
    if (rightNumber >= leftNumber)
    {
      summ = summ + rightNumber;
      rightNumber--;
      return GetSummNaturalNumbersInTheRange(leftNumber, rightNumber, summ);
    }
    return summ;
  }
  public static int Accerman(int m, int n)
  {
    while (m != 0)
    {
      if (n == 0)
      {
        return Accerman(m - 1, 1);
      }
      else
      {
        return Accerman(m - 1, Accerman(m, n - 1));
              }
    }
    return n + 1;
  }
}

public class FileMethod
{
  //Считывание и сохранение в файл html-страницы
  public static string GetHtml(string url, string path)
  {
    string html = String.Empty;
    if (!File.Exists(path))
    {
      html = new HttpClient().GetStringAsync(url).Result;
      File.WriteAllText(path, html);
    }
    else
    {
      html = File.ReadAllText(path);
    }
    return html;
  }
  //Считывание текста из файла, между двумя тэгами
  public static string GetTitle(string page)
  {
    int posFirst = 0;
    int posLast = 0;
    string firstTag = "title>";
    string lastTag = "</" + firstTag;
    firstTag = "<" + firstTag;
    posFirst = page.IndexOf(firstTag) + firstTag.Length;
    posLast = page.IndexOf(lastTag);
    return page.Substring(posFirst, posLast - posFirst);
  }
  public static void WriteStringToFile(string path, string text, bool overwrite = true)
  {
    if (overwrite)
    {
      File.WriteAllText(path, text + Environment.NewLine);
    }
    else
    {
      File.AppendAllText(path, text + Environment.NewLine);
    }
  }
  public static string ReadStringFromFile(string path)
  {
    string result = string.Empty;
    if (File.Exists(path))
    {
      result = File.ReadAllText(path);
    }
    return result;
  }
}