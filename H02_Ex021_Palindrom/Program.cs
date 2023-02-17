// H02_Ex021_Palindrom
//Первый способ - переворот числа (создание зеркального отражения) и сравнение с исходным
bool palindromWereWolf(long numW)//Оборотень
{
  if (numW < 0) return false;
  if (numW == 0) return true;

  int size = Convert.ToInt32((Math.Floor(Math.Log10(numW)) + 1));
  int loop = 1;
  long order = numW;
  long altnumW = 0;

  while (loop <= size)
  {
    altnumW = altnumW * 10 + order % 10;
    order = order / 10;
    loop++;
  }
  return numW.Equals(altnumW); //.SequenceEqual(altnumW);
  //if (altnumW == numW)
  //{
   // return true;
  //}
  //else
  //{
    //return false;
  //}
}
//Второй способ - попарное сравнение симметрично расположенных знаков в числе
bool palindromMirror(long numM)//Зеркало
{
  if (numM < 0) return false;
  if (numM == 0) return true;

  int size = Convert.ToInt32((Math.Floor(Math.Log10(numM)) + 1));
  long altnumM = numM;
  long leftDigit = 0;
  long rightDigit = 0;

  while (size > 1)
  {
    leftDigit = altnumM / Convert.ToInt64(Math.Pow(10, Convert.ToInt64(size - 1)));
    rightDigit = altnumM % 10;

    if (leftDigit != rightDigit) return false;

    altnumM = Convert.ToInt64(altnumM / 10 % Math.Pow(10.0, Convert.ToInt64(size - 2)));
    size = size - 2;
  }
  return true;
}
//Третий способ - переворот строки
bool palindromChineseReader(long numC)//Китайский чтец
{
  if (numC < 0) return false;
  if (numC == 0) return true;
  string numAs = Convert.ToString(numC);
  return numAs.SequenceEqual(numAs.Reverse());
}
//Четвертый способ - переворот массива
bool palindromReturnFire(long numF)//Ответный огонь
{
  if (numF < 0) return false;
  if (numF == 0) return true;
  long altnumF = numF;
  int size = Convert.ToInt32((Math.Floor(Math.Log10(numF)) + 1));
  int[] directFire = new int[size];
  int[] returnFire = new int[size];
  for (int index = size - 1; index >= 0; index--)
  {
    directFire[index] = Convert.ToInt32(altnumF % 10);
    returnFire[index] = Convert.ToInt32(altnumF % 10);
    altnumF = altnumF / 10;
  }
  Array.Reverse(returnFire);
  return directFire.SequenceEqual(returnFire);
}

Console.Clear();
Console.WriteLine("ПАЛИНДРОМ (вар. ПАЛИНДРОМОН) - знакосочетание одинаково читающееся в обоих направлениях.");
Console.Write("Введите число для проверки на палиндром: ");
long testMe = long.Parse(Console.ReadLine());
//вызов метода palindromWereWolf
Console.Write("Результат метода Оборотень: ");
Console.WriteLine(palindromWereWolf(testMe));
//вызов метода palindromMirror
Console.Write("Результат метода Зеркало: ");
Console.WriteLine(palindromMirror(testMe));
//вызов метода palindromChineseReader
Console.Write("Результат метода Китайский чтец: ");
Console.WriteLine(palindromChineseReader(testMe));
//вызов метода palindromReturnFire
Console.Write("Результат метода Ответный огонь: ");
Console.WriteLine(palindromReturnFire(testMe));

//ПРОВЕРКИ СКОРОСТИ ВЫПОЛНЕНИЯ МЕТОДОВ

//Оборотень
//DateTime startW = DateTime.Now;
//for (long i = 1; i <= 1000000000; i++)
//{
//palindromWereWolf(i);
//}
//Console.Write("Время выполнения 1 млрд итераций метода Оборотень: ");
//Console.WriteLine(DateTime.Now - startW);

//Зеркало
//DateTime startM = DateTime.Now;
//for (long i = 1; i <= 1000000000; i++)
//{
//palindromMirror(i);
//}
//Console.Write("Время выполнения 1 млрд итераций метода Зеркало: ");
//Console.WriteLine(DateTime.Now - startM);

//Китайский чтец
//DateTime startС = DateTime.Now;
//for (long i = 1; i <= 1000000000; i++)
//{
//palindromChineseReader(i);
//}
//Console.Write("Время выполнения 1 млрд итераций метода Китайский чтец: ");
//Console.WriteLine(DateTime.Now - startС);

//Ответный огонь
//DateTime startF = DateTime.Now;
//for (long i = 1; i <= 1000000000; i++)
//{
//palindromReturnFire(i);
//}
//Console.Write("Время выполнения 1 млрд итераций метода Ответный огонь: ");
//Console.WriteLine(DateTime.Now - startF);

//Время выполнения 1 млрд итераций метода Оборотень: 00:00:54.5017464
//Время выполнения 1 млрд итераций метода Зеркало: 00:01:04.5629665
//Время выполнения 1 млрд итераций метода Китайский чтец: 00:02:11.3845807
//Время выполнения 1 млрд итераций метода Ответный огонь: 00:01:56.7032024