// Программа на вход принимает число и выдаёт, является ли число чётным.
Console.Clear();
Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write(num);

if (num % 2 == 0)
{
  Console.WriteLine(" -> чётное");
}
else
{
  Console.WriteLine(" -> нечётное");
}