// Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
int step = 2;
int mult = 1;
if (n <= 0)
{
  step = 0;
  mult = -1;
  n = n * mult;
}
//if (n % 2 != 0) Строки 13-16 излишни. Спасибо за комментарий Дмитрию Тихонову
//{
  //n = --n;
//}
while (step <= n)
{
  Console.Write(step * mult);
  if (step < n)
  {
    Console.Write("; ");
  }
  step = step + 2;
}