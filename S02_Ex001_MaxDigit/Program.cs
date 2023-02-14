//
Console.Clear();
int num = new Random().Next(10, 100);

int fDigit = num / 10;
int sDigit = num % 10;
Console.WriteLine(num);
if (fDigit > sDigit)
{
  Console.WriteLine(fDigit);
}
else if (fDigit < sDigit)
{
  Console.WriteLine(sDigit);
}
else
{
  Console.Write("Оба числа равны ");
  Console.WriteLine(sDigit);
}