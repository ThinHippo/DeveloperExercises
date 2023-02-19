//Песочница
int DigitInPosition(long num, int position)
{
  num = Math.Abs(num);//отрицательные числа берём по модулю
  long digits = Convert.ToInt64((Math.Floor(Math.Log10(num)) + 1));//переменная проверки разрядности
  int digit=-1;
  if (position <= digits && position > 0)
  {
    //Изменяем значение digits в зависисмости от запрошенной позиции
    digits = Convert.ToInt64(Math.Pow(10, digits) / Math.Pow(10, position));
    //Корректный результат
    digit=Convert.ToInt32(num / digits % 10);
    return digit;//Convert.ToInt32(num / digits % 10);
  }
  
    return digit;
}

Console.Clear();
Console.Write("Введите число: ");
long num10 = long.Parse(Console.ReadLine());
Console.Write("Введите искомую позицию: ");
int pos10 = int.Parse(Console.ReadLine());
int result = DigitInPosition(num10, pos10);
if (result >= 0)
{
  Console.WriteLine("В числе " + num10 + " в позиции " + pos10 + " находится цифра " + result);
}
else
{
  Console.WriteLine("Введены некорректные значения");
}