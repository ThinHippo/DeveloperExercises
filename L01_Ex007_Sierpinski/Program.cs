// Демонстрация использование оператора цикла While с построением треугольника Серпинского
Console.Clear();
int xa = 45, ya = 1;
int xb = 1, yb = 30;
int xc = 90, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya;
int index = 0;
int what;

while (index < 50000)
{
  what = new Random().Next(0, 3);

  if (what == 0)
  {
    x = (x + xa)/2;
    y = (y + ya)/2;
  }

  if (what == 1)
  {
    x = (x + xb)/2;
    y = (y + yb)/2;
  }

  if (what == 2)
  {
    x = (x + xc)/2;
    y = (y + yc)/2;
  }
  Console.SetCursorPosition(x, y);
  Console.WriteLine("*");
  index++;
}