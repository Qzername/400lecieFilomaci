using Server.Code;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

public class Program
{

    static HttpClient client = new HttpClient();

    public static void Main()
    {
        Console.WriteLine("Website Converter");
        CopyFilesRecursively("./Copy/wwwroot/", "./Final/");

        DownloadPage("http://20.25.191.186:5000/");
        DownloadPage("http://20.25.191.186:5000/Map");
        DownloadPage("http://20.25.191.186:5000/List/Osoby");
        DownloadPage("http://20.25.191.186:5000/List/Miejsca");

        var categories = Database.GetCategoryAndPersons();

        foreach (var category in categories) 
            foreach(var person in category.Value)
                DownloadPage($"http://20.25.191.186:5000/Person/{person}");
    }

    static void DownloadPage(string url)
    {
        var response = client.GetAsync(url).Result;
        string result = response.Content.ReadAsStringAsync().Result;

        result = result.Replace("<link rel=\"stylesheet\" href=\"/css/main.css\">", "<link rel=\"stylesheet\" href=\"./css/main.css\">");

        url = url.Remove(0, "http://20.25.191.186:5000".Length);

        if (url == "/")
            url = "/Index";

        url = url.Replace("%20", " ");
        url += ".html";

        Directory.CreateDirectory("./Final/" + Path.GetDirectoryName(url));
        File.WriteAllText("./Final/" + url, result);

        Console.WriteLine(url);
    }

    private static void CopyFilesRecursively(string sourcePath, string targetPath)
    {
        //Now Create all of the directories
        foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
        {
            Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
        }

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
        {
            File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
        }
    }
}