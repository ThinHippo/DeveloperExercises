// Программа принимает на вход (три) числа и выдаёт максимальное из них.
Console.Clear();

int size; //= 3 (по условию задачи). По совету Дмитрия Тихонова всё-же сделаю чуть универсальнее
Console.Write("Введите количество чисел для сравнения: ");
size = int.Parse(Console.ReadLine());

double maxValue = 0;
double[] numbers = new double[size];

int index = 0;

Console.WriteLine("Введите последовательно числа для сравнения:");

for (index = 0; index < numbers.Length; index++)
{
  numbers[index] = double.Parse(Console.ReadLine());

  if (index == 0)
  {
    maxValue = numbers[index];
  }
  if (numbers[index] > maxValue)
  {
    maxValue = numbers[index];
  }

}
Console.Write("Максимальное число: ");
Console.WriteLine(maxValue);