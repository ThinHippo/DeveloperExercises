//S02_Ex003_MultipleOfOneNumber
void checkMultipleOfOneNumber(int a, int b)
{
  if (b % a == 0)
  {
    Console.WriteLine("Число " + b + " кратно " + a);
  }
  else
  {
    Console.WriteLine("Число " + b + " не кратно " + a + " (остаток " + b % a + ")");
  }
}
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();
Console.WriteLine("Введите последовательно два числа: ");
int aNum = int.Parse(Console.ReadLine());
int bNum = int.Parse(Console.ReadLine());

checkMultipleOfOneNumber(aNum, bNum);