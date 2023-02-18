// Домашнее задание после второго семинара по основам C#
using static HomeMethod;

void RunTask(int task)
{
  string[] about ={"Задача 10: Напишите программу, которая принимает на вход трёхзначное число \n и на выходе показывает вторую цифру этого числа.",
"Задача 13: Напишите программу, которая выводит третью цифру заданного числа или \n сообщает, что третьей цифры нет.",
"Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным."};

  switch (task)
  {
    case 10://решение 10 задачи
      {
        Console.WriteLine(about[0]);
        Console.Write("Введите число (по условию задачи трёхзначное): ");
        long num10 = long.Parse(Console.ReadLine());
        Console.Write("Введите искомую позицию (по условию задачи 2): ");
        int pos10 = int.Parse(Console.ReadLine());
        int result = DigitInPosition(num10, pos10);
        if (result >= 0)
        {
          Console.WriteLine("В числе " + num10 + " в позиции " + pos10 + " находится цифра " + result);
        }
        else
        {
          Console.WriteLine("Введены некорректные данные");
        }
        break;
      }
    case 13://решение 13 задачи
      {
        Console.WriteLine(about[1]);
        Console.Write("Введите число: ");
        long num13 = long.Parse(Console.ReadLine());
        Console.Write("Введите искомую позицию (по условию задачи 3): ");
        int pos13 = int.Parse(Console.ReadLine());
        if (PositionInTheRange(num13, pos13) == true)
        {
          int result = DigitInPosition(num13, pos13);
          Console.WriteLine("В числе " + num13 + " в позиции " + pos13 + " находится цифра " + result);
        }
        else
        {
          Console.WriteLine("Указанная позиция " + pos13 + " выходит за пределы разрядности числа " + num13);
        }
        break;
      }
    case 15://решение 15 задачи
      {
        Console.WriteLine(about[2]);
        Console.Write("Укажите, какой сегодня день недели по счёту: ");
        int numDay = int.Parse(Console.ReadLine());
        if (WeekdayNumInRange(numDay) == true)
        {
          if (TodayIsWeekend(numDay) == true)
          {
            Console.WriteLine("Радуемся вместе! Сегодня выходной! Без всяких условностей...");
          }
          else
          {
            Console.WriteLine("Ура! Сегодня рабочий день!");
          }
        }
        else
        {
          Console.WriteLine("В наших краях неделя состоит из семи дней...");
        }
        break;
      }
  }
}
//вызов процедуры
Console.Clear();
Console.WriteLine("Практическое задание - решить задачи 10, 13, 15.");
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







