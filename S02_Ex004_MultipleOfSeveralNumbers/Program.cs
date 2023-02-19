bool MultipleOfSeveralNumbers(int checknumber, int[] numbers)
{
  bool result = true;
  for (int index = 0; index < numbers.Length; index++)
  {
    result = Convert.ToBoolean(Convert.ToInt32(result) * Convert.ToInt32 (checknumber % numbers[index] == 0));
  }

  return result;
}
  //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
  Console.Clear();
  Console.WriteLine("Введите число для проверки кратности: ");
  int a = int.Parse(Console.ReadLine());
  Console.WriteLine("Введите первый делитель: ");
  int b = int.Parse(Console.ReadLine());
  Console.WriteLine("Введите второй делитель: ");
  int d = int.Parse(Console.ReadLine());
  int [] nums= {b,d};

  Console.WriteLine(MultipleOfSeveralNumbers(a, nums));