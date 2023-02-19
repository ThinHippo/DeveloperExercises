int checkKratnost(int a, int b)
{
  return (b % a);
}
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();
Console.WriteLine("Введите последовательно два числа: ");
int aNum = int.Parse(Console.ReadLine());
int bNum = int.Parse(Console.ReadLine());
int result;
result = checkKratnost(aNum, bNum);
if (result == 0)
{
  Console.WriteLine("Число " + bNum + " кратно " + aNum);
}
else
{
  Console.WriteLine("Число " + bNum + " не кратно " + aNum + " (остаток " + result + ")");
}