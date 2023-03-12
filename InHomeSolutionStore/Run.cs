using System.Reflection;
using static MathMethod;
using static ArrayMethod;
using static FileMethod;
public class TaskStarter
{
  public static void GoAndSee()
  {
    int goal;
    bool gooduser = false;
    TrueAboutThis();
    Console.WriteLine("В проекте собраны решения задач 4 - 9 семинаров курса 'Знакомство с языками программирования. C#.'\nДля выбора доступны задачи:\n" + MyTasksInString());
    do
    {
      Console.Write("Введите номер задачи (0 - для выхода из программы): ");
      gooduser = int.TryParse(Console.ReadLine(), out goal);
    }
    while (!gooduser);
    if (goal == 0)
    {
      Console.Clear();
      Console.WriteLine("Программа прервана пользователем.");
    }
    else
    {
      RunTask(goal);
    }
  }
  private static void RunTask(int task)
  {
    if (TaskIsValid(task))
    {
      string taskMethodName = "Task" + task;

      string runtask = (string)typeof(TaskStarter).InvokeMember(taskMethodName, BindingFlags.Static | BindingFlags.InvokeMethod | BindingFlags.NonPublic, null, null, null);
      Console.WriteLine(runtask + "\nДля возврата к выбору задач нажмите любую клавишу.");
      Console.ReadKey();
      GoAndSee();
    }
    else
    {
      Console.ReadKey();
      GoAndSee();
    }
  }
  private static string Task25()
  {
    Console.WriteLine("Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\nATTENTION: Использовать Math.Pow запрещено иерархом!");
    UserEntersNumber(out double num, "Введите число A: ");
    UserEntersNumber(out int power, "Введите число B: ");
    double result = NumberToPower(num, power);
    Console.WriteLine(num + "^" + power + " = " + result);
    return "Выполнение задачи 25 завершено.";
  }
  private static string Task27()
  {
    Console.WriteLine("Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.");
    UserEntersNumber(out long num, "Введите целое число: ");
    long result = AllDigitInNumberSumm(num);
    Console.WriteLine(num + ">" + result);
    return "Выполнение задачи 27 завершено.";
  }
  private static string Task29()
  {
    Console.WriteLine("Задача 29: Напишите метод, который формирует массив из N элементов из файла и выводит их на экран\n(разделители намеренно сделаны разными для исходного и считанного массива).");
    CreateArray(out int[] arrayOut, true, 10, 15);
    FillArray(arrayOut, false, -15, 123, false);
    string separatorOut = "||";
    string path = "arrayjourney.txt";
    string result = ArrayAsString(arrayOut, separatorOut);
    Console.WriteLine("Исходный массив: " + result);
    WriteStringToFile(path, result);
    result = ReadStringFromFile(path);
    Console.WriteLine("Строка в файле: " + result);
    ArrayViaSplit(out int[] arrayIn, result, separatorOut);
    string separatorIn = "//";
    result = ArrayAsString(arrayIn, separatorIn);
    Console.WriteLine("Считанный массив: " + result);
    return "Выполнение задачи 29 завершено.";
  }
  private static string Task34()
  {
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    CreateArray(out int[] trio, true, 5, 10);
    int min = 100;
    int max = 999;
    FillArray(trio, true, min, max, false);
    int count = ArrayItemCountByValueParity(trio, true);
    Console.WriteLine("Исходный массив [" + min + ", " + max + "]: " + ArrayAsString(trio, ", "));
    Console.WriteLine("Количество четных значений: " + count);
    return "Выполнение задачи 34 завершено.";
  }
  private static string Task36()
  {
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    CreateArray(out int[] arr, true, 10, 50);
    FillArray(arr, false, -50, 174, false);
    double result = ArrayItemSummByPositionParity(arr, false);
    Console.WriteLine("Исходный массив: " + ArrayAsString(arr));
    Console.WriteLine("Сумма элементов массива в нечётных позициях равна: " + result);
    return "Выполнение задачи 36 завершено.";
  }
  private static string Task38()
  {
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    CreateArray(out double[] doubles, true, 5, 15);
    FillArray(doubles, true, -15, 76, false);
    Console.WriteLine(ArrayAsString(doubles, ", "));
    double max = MaxValueInArray(doubles);
    double min = MinValueInArray(doubles);
    double result = max - min;
    Console.WriteLine("(" + max + ") - (" + min + ") = " + result);
    return "Выполнение задачи 38 завершено.";
  }
  private static string Task41()
  {
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел.\nПосчитать, сколько чисел больше 0 ввёл пользователь.");
    bool positiveCount = true;
    bool printNumbers = true;
    int countInUserNumbers = CountingNumbersBySignInUserEnters("Введите последовательно несколько чисел (для прекращения введите пустой символ):", positiveCount, printNumbers);
    string report = "положительных";
    if (!positiveCount) report = "отрицательных";
    Console.WriteLine("Введено " + report + " чисел: " + countInUserNumbers);
    return "Выполнение задачи 41 завершено.";
  }
  private static string Task43()
  {
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;" +
    "\nЗначения b1, k1, b2 и k2 задаются пользователем.");
    int graphCount = 2;
    double[,] graphs = new double[graphCount, graphCount];
    GetLineFunctionShiftAndAngle(graphs, "Введите значения угловых коэффициентов (k) и коэффициентов сдвига (b).");
    double[,] interseption = GetIntersectionPointsOfLines(graphs);
    Console.WriteLine("Пользователь определил функции:\n\ty={0}x{1}\n\ty={2}x{3}", graphs[0, 0], GetAdditionSymbol(graphs[0, 1]), graphs[1, 0], GetAdditionSymbol(graphs[1, 1]));
    if (interseption.GetLength(0) != 0)
    {
      Console.WriteLine("Координаты точки пересечения графиков функций = ({0};{1})", interseption[0, 0], interseption[0, 1]);
    }
    else
    {
      Console.WriteLine("Графики функций не имеют точки пересечения.");
    }
    return "Выполнение задачи 43 завершено.";
  }
  private static string Task47()
  {
    Console.WriteLine("Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
    CreateArray(out double[,] userArray, true);
    int minArrayValue = -50;
    int maxArrayValue = 50;
    int round = 3;
    FillArray(userArray, true, minArrayValue, maxArrayValue, round, false);
    PrintTabularView(userArray);
    return "Выполнение задачи 47 завершено.";
  }
  private static string Task50()
  {
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве," +
    "\nи возвращает значение этого элемента или же указание, что такого элемента нет.");
    int minSize = 5;
    int maxSize = 10;
    int minArrayValue = -100;
    int maxArrayValue = 100;
    CreateArray(out int[,] testArray, minSize, maxSize);
    FillArray(testArray, true, minArrayValue, maxArrayValue, false);

    Console.WriteLine("Для поиска значения элемента в массиве введите его адрес.");
    Console.WriteLine("(текущий размер массива {0}x{1})", testArray.GetLength(0), testArray.GetLength(1));
    UserEntersNumber(out int row, "Укажите индекс строки: ");
    UserEntersNumber(out int column, "Укажите индекс столбца: ");
    if (!GetArrayItemByPosition(testArray, row, column, out int value))
    {
      Console.WriteLine("Указанный адрес выходит за пределы размерности массива.");
    }
    else
    {
      Console.WriteLine("Значение элемента массива [{0},{1}] равно {2}", row, column, value);
    }
    PrintTabularView(testArray);
    return "Выполнение задачи 50 завершено.";
  }
  private static string Task52()
  {
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    int minSize = 5;
    int maxSize = 5;
    int minArrayValue = -10;
    int maxArrayValue = 10;
    CreateArray(out int[,] testArray, minSize, maxSize);
    FillArray(testArray,
            allowLimit: true,
            minValue: minArrayValue,
            maxValue: maxArrayValue,
            byUser: false);
    double[,] avgArray = CalculateAverageOfArrayItems(testArray, false);
    PrintTabularView(testArray);
    Console.WriteLine("\nСреднее арифметическое элементов по столбцам");
    PrintTabularView(avgArray);
    return "Выполнение задачи 52 завершено.";
  }
  private static string Task54()
  {
    Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    int minSize = 5;
    int maxSize = 10;
    int minArrayValue = -10;
    int maxArrayValue = 50;
    CreateArray(out int[,] unsorting, minSize, maxSize);
    FillArray(unsorting,
            allowLimit: true,
            minValue: minArrayValue,
            maxValue: maxArrayValue,
            byUser: false);
    Console.WriteLine("Исходный массив до сортировки строк: ");
    PrintTabularView(unsorting);
    int[,] aftersorting = unsorting;
    int minIndexForSorting = 0;
    int maxIndexForSorting = aftersorting.GetLength(0) - 1;
    ArraySortingByRowsOrColumns(aftersorting,
                                ascending: false,
                                row: true,
                                from: minIndexForSorting,
                                to: maxIndexForSorting);
    Console.WriteLine("Массив после сортировки строк: ");
    PrintTabularView(aftersorting);
    return "Выполнение задачи 54 завершено.";
  }
  private static string Task56()
  {
    Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n" +
    "Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.");
    int minSize = 5;
    int maxSize = 10;
    int minArrayValue = -20;
    int maxArrayValue = 50;
    CreateArray(out int[,] testArray, minSize, maxSize);
    FillArray(testArray,
            allowLimit: true,
            minValue: minArrayValue,
            maxValue: maxArrayValue,
            byUser: false);
    Console.WriteLine("Исходный массив: ");
    PrintTabularView(testArray);
    int indexRowWithMaxSumm = GetArrayRowOrColumnIndexByMinSumm(testArray);
    Console.WriteLine($"Наименьшая сумма элементов в строке: {indexRowWithMaxSumm}");
    return "Выполнение задачи 56 завершено.";
  }
  private static string Task60()
  {
    Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.\n" +
    "Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    int minArrayValue = 10;
    int maxArrayValue = 99;
    int rank = 3;
    int countValues = CountOfPossibleUniqValue(minArrayValue, maxArrayValue);
    Console.WriteLine($"Количество значений: {countValues}");
    int maxSize = MaxArraySizeByCountOfPossibleValues(rank, countValues);
    Console.WriteLine($"Максимальный размер массива: {maxSize}");
    if (maxSize > 0)
    {
      int minSize = new Random().Next(1, maxSize + 1);
      Console.WriteLine($"Минимальный размер массива: {minSize}");
      CreateArray(out int[,,] testArray, minSize, maxSize);
      FillArrayWithUniqValues(testArray, minArrayValue, maxArrayValue);
      PrintTabularView(testArray);
    }
    else Console.WriteLine("Задан некорректный диапазон уникальных значений");
    return "Выполнение задачи 60 завершено.";
  }
  private static string Task64()
  {
    Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.\n" +
    "Выполнить с помощью рекурсии.");
    UserEntersNumber(out int number, "Введите натуральное (целое положительное) число: ");
    Console.Write($"N={number}-> ");
    ShowNaturalNumbersInTheRange(number);
    return "\nВыполнение задачи 64 завершено.";
  }
  private static string Task66()
  {
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    UserEntersNumber(out int m, "Введите натуральное (целое положительное) число M: ");//меньшее
    UserEntersNumber(out int n, "Введите натуральное (целое положительное) число N: ");//большее
    int leftNumber = m;
    int rightNumber = n;
    if (n < m)
    {
      leftNumber = n;
      rightNumber = m;
    }
    int result = GetSummNaturalNumbersInTheRange(leftNumber, rightNumber, 0);
    Console.WriteLine($"M={m}; N={n}-> {result}");
    return "Выполнение задачи 66 завершено.";
  }
  private static string Task68()
  {
    Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.");
    UserEntersNumber(out long m, "Введите натуральное (целое положительное) число M: ");//меньшее
    UserEntersNumber(out long n, "Введите натуральное (целое положительное) число N: ");//большее
    long result = 0;
    Console.WriteLine($"Для наглядности возрастания функции значения будут рассчитаны для M={m} N=[0,{n}]");
    for(long i=0;i<=n;i++)
    {
      result = Accerman(m, i);
      Console.WriteLine($"M={m}; N={i} A(m,n)=" + result);
    }
    return "Выполнение задачи 68 завершено.";
  }

  //Проверки корректности выбранной задачи
  private static bool TaskIsValid(int num)
  {
    int[,] tasks = MyTasks();
    bool valid = false;
    for (int i = 0; i < tasks.GetLength(0); i++)
    {
      for (int j = 0; j < tasks.GetLength(1); j++)
      {
        if (tasks[i, j] == num && tasks[i, j] != 0) valid = true;
      }
    }
    if (!valid) Console.WriteLine("Задача №" + num + " в списке решённых не представлена. Возможно она решена в другом проекте, но это не точно...");
    return valid;
  }
  private static string MyTasksInString() => TaskAsString(MyTasks(), ", ");
  private static int[,] MyTasks()
  {
    int[,] tasks = { { 25, 27, 29 }, { 34, 36, 38 }, { 41, 43, 0 }, { 47, 50, 52 }, { 54, 56, 60 }, { 64, 66, 68 } };
    return tasks;
  }
  private static string TaskAsString(int[,] tasks, string separator = ", ")
  {
    string outstring = string.Empty;
    for (int i = 0; i < tasks.GetLength(0); i++)
    {
      outstring = outstring + $"Семинар {i + 4} Задачи: ";
      for (int j = 0; j < tasks.GetLength(1); j++)
      {
        if (tasks[i, j] == 0)
        {
          continue;
        }
        outstring = $"{outstring}{$"{tasks[i, j]}{separator}"}";
      }
      outstring = $"{outstring}\n";
    }
    return outstring;
  }
  private static void TrueAboutThis()
  {
    string hex = "436F7079726967687420627920416C65786579204B68756469616B6F762032303233";
    byte[] tmp = Convert.FromHexString(hex);
    string fact = string.Empty;
    for (int i = 0; i < tmp.Length; i++)
    {
      fact = fact + Convert.ToChar(tmp[i]);
    }
    Console.Clear();
    Console.WriteLine(fact);
  }
}