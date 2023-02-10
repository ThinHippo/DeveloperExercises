// Программа вывода уникального приветствия для конкретного имени
Console.WriteLine("Познакомимся?");
Console.WriteLine("Напишите своё имя: ");
string username = Console.ReadLine ();

if (username.ToLower() == ("маша"))
{
  Console.WriteLine("Машка, привет! Давно не виделись!");
}
else
{
  Console.Write(" здравствуй, ");
  Console.WriteLine(username.ToUpper());
}