// Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число (F): ");
double numF = double.Parse(Console.ReadLine());
Console.Write("Введите второе число (S): ");
double numS = double.Parse(Console.ReadLine());

if (numF > numS)
{
  Console.Write("Максимальное число: ");
  Console.WriteLine(numF);
  Console.Write("Минимальное число: ");
  Console.WriteLine(numS);
}
else if (numF < numS)
{
  Console.Write("Максимальное число: ");
  Console.WriteLine(numS);
  Console.Write("Минимальное число: ");
  Console.WriteLine(numF);
}
else
{
  Console.WriteLine("Числа равны");
}