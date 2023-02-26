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
    Console.WriteLine("В проекте собраны решения задач 4-го и 5-го семинаров курса 'Знакомство с языками программирования. C#.'\nДля выбора доступны задачи: " + MyTasksInString());
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
      Console.WriteLine(runtask);
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
    double num = UserEntersDouble("Введите число A: ");
    int power = UserEntersInteger("Введите число B: ");
    double result = NumberToPower(num, power);
    Console.WriteLine(num + "^" + power + " = " + result);
    return "Выполнение задачи 25 завершено.";
  }
  private static string Task27()
  {
    Console.WriteLine("Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.");
    long num = UserEntersLong("Введите целое число: ");
    long result = AllDigitInNumberSumm(num);
    Console.WriteLine(num + ">" + result);
    return "Выполнение задачи 27 завершено.";
  }
  private static string Task29()
  {
    Console.WriteLine("Задача 29: Напишите метод, который формирует массив из N элементов из файла и выводит их на экран\n(разделители намеренно сделаны разными для исходного и считанного массива).");
    int[] arrayOut = CreateArrayInt(false, true);
    FillArray(arrayOut, false, -15, 123, false);
    string separatorOut = "||";
    string path = "arrayjourney.txt";
    string result = ArrayInString(arrayOut, separatorOut);
    Console.WriteLine("Исходный массив: " + result);
    WriteStringToFile(path, result);
    result = ReadStringFromFile(path);
    Console.WriteLine("Строка в файле: " + result);
    int[] arrayIn = IntArrayViaSplit(result, separatorOut);
    string separatorIn = "//";
    result = ArrayInString(arrayIn, separatorIn);
    Console.WriteLine("Считанный массив: " + result);
    return "Выполнение задачи 29 завершено.";
  }
  private static string Task34()
  {
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    int[] trio = CreateArrayInt();
    int min = 100;
    int max = 999;
    FillArray(trio, true, min, max, false);
    int count = ArrayItemCountByParity(trio, true);
    Console.WriteLine("Исходный массив [" + min + ", " + max + "]: " + ArrayInString(trio, ", "));
    Console.WriteLine("Количество четных значений: " + count);
    return "Выполнение задачи 34 завершено.";
  }
  private static string Task36()
  {
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    int[] arr = CreateArrayInt(false, false, 10, 50);
    FillArray(arr, false, -50, 174, false);
    double result = ArrayItemSummByParityPosition(arr, false);
    Console.WriteLine("Исходный массив: " + ArrayInString(arr));
    Console.WriteLine("Сумма элементов массива в нечётных позициях равна: " + result);
    return "Выполнение задачи 36 завершено.";
  }
  private static string Task38()
  {
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    double[] doubles = CreateArrayDouble();
    FillArray(doubles, true, -15, 76, false);
    Console.WriteLine(ArrayInString(doubles, ", "));
    double max = MaxValueInArray(doubles);
    double min = MinValueInArray(doubles);
    double result = max - min;
    Console.WriteLine("(" + max + ") - (" + min + ") = " + result);
    return "Выполнение задачи 38 завершено.";
  }
  //

  private static bool TaskIsValid(int num)
  {
    int[] tasks = MyTasks();
    for (int index = 0; index < tasks.Length; index++)
    {
      if (tasks[index] == num)
      {
        return true;
      }
    }
    Console.WriteLine("Задача №" + num + " в списке решённых не представлена. Возможно она решена в другом проекте, но это не точно...");
    return false;
  }
  private static string MyTasksInString() => ArrayInString(MyTasks(), ", ");
  private static int[] MyTasks()
  {
    int[] tasks = { 25, 27, 29, 34, 36, 38 };
    return tasks;
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