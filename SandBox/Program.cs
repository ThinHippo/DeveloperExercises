//Песочница
static byte[] StringToByteArray(string text)
{
  byte [] author=new byte[text.Length];
  for (int i=0;i<author.Length;i++)
  {
    author[i]=Convert.ToByte(text[i]);
  }
  Console.Write(string.Join(", ",author));
  Console.WriteLine();
  return author;
}
//вызов
Console.Clear();
string me="Copyright by Alexey Khudiakov 2023";
byte[] asbyte=StringToByteArray(me);
string hex=Convert.ToHexString(asbyte);
string newme=string.Empty;
Console.Write(hex);
asbyte=Convert.FromHexString(hex);
//string as=Convert.ToHexString(asbyte)

//PrintArray(NegativeArray(testArr));