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

        //special case
        string css = File.ReadAllText("./Final/css/main.css");
        css = css.Replace("url(\"/img/2.jpg\");", "url(\"../img/2.jpg\");");
        File.WriteAllText("./Final/css/main.css", css);
    }

    static void DownloadPage(string url)
    {
        var response = client.GetAsync(url).Result;
        string result = response.Content.ReadAsStringAsync().Result;

        url = url.Remove(0, "http://20.25.191.186:5000".Length);

        if (url == "/")
            url = "/index";

        url = url.Replace("%20", " ");
        url += ".html";

        string folderRecap = string.Empty;

        for (int i = 0; i < url.Count(x => x == '/')-1; i++)
            folderRecap += "../";

        result = result.Replace("src=\"/", "src=\"./" + folderRecap);
        result = result.Replace("href=\"/", "href=\"./" + folderRecap);
        result = result.Replace("<head>", "<head>\r\n        <meta charset=\"UTF-8\">");
        //result = result.Replace("\">\r\n                            <img", $"Index.html\">\r\n                            <img");
        result = result.Replace("\">Zobacz więcej", ".html\">Zobacz więcej");
        result = result.Replace("\">\r\n                                                                <button", ".html\">\r\n                                                                <button");

        Directory.CreateDirectory("./Final/" + Path.GetDirectoryName(url));
        File.WriteAllText("./Final/" + url, result);
        File.Delete("./Final/favicon.ico");

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