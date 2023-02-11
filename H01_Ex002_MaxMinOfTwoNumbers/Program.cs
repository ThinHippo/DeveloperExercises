// Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
double numF, numS;
//Числа вводит пользователь
Console.Write("Введите первое число (F): ");
numF = double.Parse(Console.ReadLine());
Console.Write("Введите второе число (S): ");
numS = double.Parse(Console.ReadLine());

//Числа случайные
//numF = (new Random().NextDouble()) * (new Random().Next(1, 10000));
//numS = (new Random().NextDouble()) * (new Random().Next(1, 10000));

//Console.Write("Первое число: ");
//Console.WriteLine(numF);
//Console.Write("Второе число: ");
//Console.WriteLine(numS);

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