public class HomeMethod
{
  public static int DigitInPosition(long num, int position)
  {
    num = Math.Abs(num);//отрицательные числа берём по модулю
    long digits = Convert.ToInt64((Math.Floor(Math.Log10(num)) + 1));//переменная проверки разрядности
    int digit = -1;
    if (PositionInTheRange(num, position) == true)
    {
      //Изменяем значение digits в зависисмости от запрошенной позиции
      digits = Convert.ToInt64(Math.Pow(10, digits) / Math.Pow(10, position));
      //Корректный результат
      digit = Convert.ToInt32(num / digits % 10);
      return digit;//Convert.ToInt32(num / digits % 10);
    }
    return digit;
  }
  public static bool CorrectNumberLen(long num, int size)
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
  public static bool PositionInTheRange(long num, int position)
  {
    if (position > 0 && position <= Convert.ToInt32((Math.Floor(Math.Log10(num)) + 1)))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public static bool TaskIsValid(int num)
  {
    int[] tasks = { 10, 13, 15 };
    for (int index = 0; index < tasks.Length; index++)
    {
      if (tasks[index] == num)
      {
        return true;
      }
    }
    return false;
  }
  public static bool TodayIsWeekend(int num)
  {
    if (num == 6 || num == 7)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
public static bool WeekdayNumInRange(int num)
{
  if (num>=1 && num<=7){
    return true;
  }
  else{
    return false;
  }
}
}