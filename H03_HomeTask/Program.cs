// Домашнее задание после третьего семинара по основам C#
using static ThirdDuelMethod;

void RunTask(int task)
{
  string[] about ={"Задача 19: Напишите программу, которая принимает на вход пятизначное число \n и проверяет, является ли оно палиндромом.",
                    "Задача 21: Напишите программу, которая принимает на вход координаты двух точек \n и находит расстояние между ними в 3D пространстве.",
                    "Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу \n кубов чисел от 1 до N."};

  switch (task)
  {
    case 19://
      {
        Console.WriteLine(about[0]);
        Console.Write("Введите число (по условию задачи пятизначное): ");
        long num19 = long.Parse(Console.ReadLine());
        Console.WriteLine("Эта задача решена несколькими способами: \n 1. Оборотень \n 2. Зеркало \n 3. Китайский чтец \n 4. Ответный огонь");
        Console.Write("Выберите номер способа решения (0 - сравнить производительность): ");
        int how = int.Parse(Console.ReadLine());
        NumIsPalindrom(num19, how);
        break;
      }
    case 21://
      {
        Console.WriteLine(about[1]);
        Console.Write("Укажите количество точек между которыми необходимо вычислить расстояние (по условию задачи две): ");
        int num21 = int.Parse(Console.ReadLine());
        DistanceBetweenPointsXYZ(num21);
        break;
      }
    case 23://
      {
        Console.WriteLine(about[2]);
        Console.Write("Введите число: ");
        int num23 = int.Parse(Console.ReadLine());
        TableOfCubes(num23);
        break;
      }
  }
}
  //вызов процедуры RunTask
  Console.Clear();
  Console.WriteLine("Практическое задание - решить задачи 19, 21, 23.");
  Console.Write("Выберите номер задачи: ");
  int exNum = int.Parse(Console.ReadLine());
  if (TaskIsValid(exNum) == true)
  {
    RunTask(exNum);
  }
  else
  {
    Console.WriteLine("Пока задачи " + exNum + " нет в списке решённых. Возможно получится выбрать в следующий раз...");
  }