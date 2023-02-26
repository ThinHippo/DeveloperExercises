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
    int size = UserEntersArraySize(allowLimit, minSize, maxSize, msg);
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
      if (withLimit) Console.WriteLine("Размер массива определён диапазоном от " + minSize + " до " + maxSize + " включительно.");
      Console.WriteLine(msg);
      gooduser = int.TryParse(Console.ReadLine(), out size);
      if (gooduser && withLimit) gooduser = (size >= minSize && size <= maxSize);
    }
    while (!gooduser);
    return size;
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

  //Формирование строки из значений массива
  public static string ArrayAsString(int[] arr, string separator = ", ") => string.Join(separator, arr);
  public static string ArrayAsString(double[] arr, string separator = ", ") => string.Join(separator, arr);
  public static string ArrayAsString(string[] arr, string separator) => string.Join(separator, arr);

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