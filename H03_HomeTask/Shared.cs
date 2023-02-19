public class ThirdDuelMethod
{
  public static void NumIsPalindrom(long num, int way)
  {
    bool proof = false;

    if (num < 0)
    {
      proof = false;
    }
    if (CorrectNumberLen(num, 1) == true)
    {
      proof = true;
    }
    if (way > -1 && way <= 4)
    {
      switch (way)
      {
        case 0:
          {
            PalindromSpeed();
            break;
          }
        case 1:
          {
            proof = WereWolf(num);
            break;
          }
        case 2:
          {
            proof = Mirror(num);
            break;
          }
        case 3:
          {
            proof = ChineseReader(num);
            break;
          }
        case 4:
          {
            proof = ReturnFire(num);
            break;
          }
      }
      if (way > 0) Console.WriteLine("Число " + num + " палиндром? -> " + proof + " (использован " + way + "-й метод)");
    }
    else
    {
      Console.WriteLine("Такой способ решения пока не придуман...");
    }
  }
  public static void DistanceBetweenPointsXYZ(int point)
  {
    int[,] coordinates = new int[point, 3];
    coordinates = FillPointsXYZ(point);
    double distance = 0.0;
    double x;
    double y;
    double z;
    string txtL, txtR;
    Console.WriteLine("Таблица расстояний (D)");
    for (int index = 0; index < point; index++)
    {
      for (int item = index + 1; item < point; item++)
      {
        x = Math.Pow(Convert.ToDouble(coordinates[item, 0] - coordinates[index, 0]), 2.0);
        y = Math.Pow(Convert.ToDouble(coordinates[item, 1] - coordinates[index, 0]), 2.0);
        z = Math.Pow(Convert.ToDouble(coordinates[item, 2] - coordinates[index, 0]), 2.0);
        distance = Math.Sqrt(x + y + z);
        txtL = "A" + index + "(" + coordinates[index, 0] + ", " + coordinates[index, 1] + ", " + coordinates[index, 2] + ")";
        txtR = "A" + item + "(" + coordinates[item, 0] + ", " + coordinates[item, 1] + ", " + coordinates[item, 2] + ")";
        Console.WriteLine("D (" + txtL + " -> " + txtR + ") = " + distance);
      }
    }
  }
  public static void TableOfCubes(int limit)
  {
    int direction = 1;
    if (limit < 0) direction = -1;
    int num = 1;
    double cube;
    Console.WriteLine("Таблица кубов чисел от 1 до " + limit);
    while (Math.Abs(num) <= Math.Abs(limit))
    {
      cube = Math.Pow(Convert.ToDouble(num), 3.0);
      Console.WriteLine(num + "^3 = " + cube);
      num = num + direction;
    }
  }

  //Первый способ - переворот числа (создание зеркального отражения) и сравнение с исходным
  private static bool WereWolf(long num)//Оборотень
  {
    int size = Convert.ToInt32((Math.Floor(Math.Log10(num)) + 1));
    int loop = 1;
    long order = num;
    long altnum = 0;

    while (loop <= size)
    {
      altnum = altnum * 10 + order % 10;
      order = order / 10;
      loop++;
    }
    return num.Equals(altnum);
  }
  //Второй способ - попарное сравнение симметрично расположенных знаков в числе
  private static bool Mirror(long num)//Зеркало
  {
    int size = Convert.ToInt32((Math.Floor(Math.Log10(num)) + 1));
    long altnum = num;
    long leftDigit = 0;
    long rightDigit = 0;

    while (size > 1)
    {
      leftDigit = altnum / Convert.ToInt64(Math.Pow(10, Convert.ToInt64(size - 1)));
      rightDigit = altnum % 10;

      if (leftDigit != rightDigit)
      {
        return false;
      }

      altnum = Convert.ToInt64(altnum / 10 % Math.Pow(10.0, Convert.ToInt64(size - 2)));
      size = size - 2;
    }
    return true;
  }
  //Третий способ - переворот строки
  private static bool ChineseReader(long num)//Китайский чтец
  {
    string numAs = Convert.ToString(num);
    return numAs.SequenceEqual(numAs.Reverse());
  }
  //Четвертый способ - переворот массива
  private static bool ReturnFire(long num)//Ответный огонь
  {
    long altnum = num;
    int size = Convert.ToInt32((Math.Floor(Math.Log10(num)) + 1));
    int[] directFire = new int[size];
    int[] returnFire = new int[size];
    for (int index = size - 1; index >= 0; index--)
    {
      directFire[index] = Convert.ToInt32(altnum % 10);
      returnFire[index] = Convert.ToInt32(altnum % 10);
      altnum = altnum / 10;
    }
    Array.Reverse(returnFire);
    return directFire.SequenceEqual(returnFire);
  }
  private static bool CorrectNumberLen(long num, int size)
  {
    if (size == Convert.ToInt32((Math.Floor(Math.Log10(num)) + 1)))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  //Заполнение массива координат
  private static int[,] FillPointsXYZ(int size)//
  {
    int[,] points = new int[size, 3];
    for (int index = 0; index < size; index++)
    {
      points[index, 0] = new Random().Next(-100, 100);//x
      points[index, 1] = new Random().Next(-100, 100);//y
      points[index, 2] = new Random().Next(-100, 100);//z
    }
    return points;
  }
  public static bool TaskIsValid(int num)
  {
    int[] tasks = { 19, 21, 23 };
    for (int index = 0; index < tasks.Length; index++)
    {
      if (tasks[index] == num)
      {
        return true;
      }
    }
    return false;
  }
  public static void PalindromSpeed(int limit = 1500000)
  {
    DateTime start;
    int loop;
    start = DateTime.Now;
    int trueResult = 0;
    for (loop = 1; loop <= limit; loop++)
    {
      if (WereWolf(loop) == true) trueResult++;
    }

    Console.Write("Найдено " + trueResult + " чисел-палиндромов.\n Время выполнения " + limit + " итераций метода Оборотень: ");
    Console.WriteLine(DateTime.Now - start);
    //
    start = DateTime.Now;
    trueResult = 0;
    for (loop = 1; loop <= limit; loop++)
    {
      if (Mirror(loop) == true) trueResult++;
    }
    Console.Write("Найдено " + trueResult + " чисел-палиндромов.\n Время выполнения " + limit + " итераций метода Зеркало: ");
    Console.WriteLine(DateTime.Now - start);
    //
    start = DateTime.Now;
    trueResult = 0;
    for (loop = 1; loop <= limit; loop++)
    {
      if (ChineseReader(loop) == true) trueResult++;
    }
    Console.Write("Найдено " + trueResult + " чисел-палиндромов.\n Время выполнения " + limit + " итераций метода Китайский чтец: ");
    Console.WriteLine(DateTime.Now - start);
    //
    start = DateTime.Now;
    trueResult = 0;
    for (loop = 1; loop <= limit; loop++)
    {
      if (ReturnFire(loop) == true) trueResult++;
    }
    Console.Write("Найдено " + trueResult + " чисел-палиндромов.\n Время выполнения " + limit + " итераций метода Ответный огонь: ");
    Console.WriteLine(DateTime.Now - start);
  }
}