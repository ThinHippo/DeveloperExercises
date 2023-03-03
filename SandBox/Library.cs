internal class Library
{
  public static byte[] StringToByteArray(string text)
  {
    byte[] author = new byte[text.Length];
    for (int i = 0; i < author.Length; i++)
    {
      author[i] = Convert.ToByte(text[i]);
    }
    Console.Write(string.Join(", ", author));
    Console.WriteLine();
    return author;
  }
  //Tetris
  public static void Tetris()
  {

  }
}