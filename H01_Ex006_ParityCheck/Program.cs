// Программа на вход принимает число и выдаёт, является ли число чётным.
Console.Clear();
int num;
Console.WriteLine("Введите целое число: ");
num = int.Parse(Console.ReadLine());
Console.Write(num);

if (num % 2 == 0)
{
  Console.WriteLine(" -> да");
}
else
{
  Console.WriteLine(" -> нет");
}