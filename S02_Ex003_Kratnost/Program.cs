//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();
Console.WriteLine("Введите последовательно два числа: ");
int aNum = int.Parse(Console.ReadLine());
int bNum = int.Parse(Console.ReadLine());
if (bNum % aNum == 0)
{
  Console.WriteLine("да");
}
else {
  Console.Write("Нет, остаток ");
  Console.WriteLine(bNum % aNum);
}