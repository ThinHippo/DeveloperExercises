// Программа принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
int index = 0;
int size = 3;
double maxvalue = 0;
double[] numbers = new double[size];

Console.WriteLine("Введите последовательно три числа:");

for (index = 0; index < numbers.Length; index++)
{
  numbers[index] = double.Parse(Console.ReadLine());

  if (index == 0)
  {
    maxvalue = numbers[index];
  }
  if (numbers[index] > maxvalue)
  {
    maxvalue = numbers[index];
  }

}
Console.Write("Максимальное число: ");
Console.WriteLine(maxvalue);