//Песочница
string GetHtml(string url, string path)
{
  string html = String.Empty;
  if (!File.Exists(path))
  {
    html = new HttpClient().GetStringAsync(url).Result;
    File.WriteAllText(path, html);
  }
  else
  {
    html = File.ReadAllText(path);
  }
  return html;
}

string GetTitle(string page)
{
  int posFirst = 0;
  int posLast = 0;
  string firstTag = "title>";
  string lastTag = "</" + firstTag;
  firstTag = "<" + firstTag;
  posFirst = page.IndexOf(firstTag) + firstTag.Length;
  posLast = page.IndexOf(lastTag);
  return page.Substring(posFirst, posLast - posFirst);
}

string url = "https://google.com";
string localPath = "trampampam.html";
string html = GetHtml(url, localPath);
string urlTitle = string.Empty;
urlTitle = GetTitle(html);
Console.Clear();
System.Console.WriteLine(urlTitle);