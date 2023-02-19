// Задача 1
// Реализовать перемешивание массива

// Задача 2
// Дан массив, наполненный числами от 1 до N. Составить частотный словарь.

//int[] Mix(int[] array, int loop)
//{
//int[] mix = new int[array.Length];
//int posA = 0;
//int posB = 0;
//int tmpValue = 0;
//for (int index = 1; index < loop; index++)
//{
//posA = new Random().Next(0, array.Length);
//posB = new Random().Next(0, array.Length);
//tmpValue = mix[posA];
//mix[posA] = mix[posB];
//mix[posB] = tmpValue;
//}
//return mix;
//}

int[,] FrequencyDictionary(int[] array, int min = 1, int max = 100)
{
  int size = max - min + 1;
  int index, item;
  int[,] dictionary = new int[size, 2];

  for (index = 0; index < size; index++)
  {
    dictionary[index, 0] = min;
    for (item = 0; item < array.Length; item++)
    {
      if (array[item] == min)
      {
        dictionary[index, 1] = dictionary[index, 1] + 1;
      }
    }
    min++;
  }
  Console.WriteLine("Частотный словарь: ");
  for (index = 0; index < size; index++)
  {
    if (dictionary[index, 1] > 0)
    {
      Console.WriteLine(dictionary[index, 0] + " > " + dictionary[index, 1]);
    }
  }
  return dictionary;
}
//вызов
int[] test = { 2, 34, 5, 32, 1, 2, 56, 7, 34, 2, 55, 6, 7, 7, 9, 34, -8, 0, -9 };
FrequencyDictionary(test, -9, 56);