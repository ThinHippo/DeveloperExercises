//
Console.Clear();

int MaxDigit()
{
  int num = new Random().Next(10, 100);

  int fDigit = num / 10;
  int sDigit = num % 10;

  Console.WriteLine(num);
  if (fDigit > sDigit)
  {
    return fDigit;
  }
  else if (fDigit < sDigit)
  {
    return sDigit;
  }
  else
  {
    return sDigit;
  }
}

Console.WriteLine (MaxDigit());