using System.Xml.Linq;

namespace OdtFileConverter
{
    public class Program
    {
        public static void Main()
        {
            Directory.Delete("./ConvertedFiles/", true);
            Directory.CreateDirectory($"./ConvertedFiles/img/");
            Directory.CreateDirectory("./ConvertedFiles/");

            int i = 0;

            char[] characters = { '\\', '/' }; 

            foreach (string file in Directory.GetFiles("./Aplikacja/","",SearchOption.AllDirectories))
            {
                bool isImage = file.EndsWith(".jpg") || file.EndsWith(".png");
                bool isOdt = file.EndsWith(".odt");

                if (!isImage && !isOdt) continue;

                string nameWithDesc = file.Split(characters).Last().Split('.')[0];
                Console.WriteLine($"\n{++i} - Converting file...\n{file}\n{nameWithDesc}\n");

                if (isImage)
                {
                    string category = file.Split(characters)[^2];

                    Directory.CreateDirectory($"./ConvertedFiles/img/{category}/");

                    if (File.Exists($"./ConvertedFiles/img/{category}/{nameWithDesc}.jpg"))
                        continue;

                    File.Copy(file, $"./ConvertedFiles/img/{category}/{nameWithDesc}.jpg");
                    continue;
                }

                string[] splited = nameWithDesc.Split("-");
                string name = splited[0];
                string description = splited.Length > 1 ? splited[1] : string.Empty;

                if (description == " długi opis")
                    description = "-long";
                else if (description == " krótki opis")
                    description = "-short";
                else if (description != string.Empty)
                    description = string.Empty;

                Directory.CreateDirectory($"./ConvertedFiles/person/{name}/");
                File.WriteAllText($"./ConvertedFiles/person/{name}/{name}{description}.html", ODTTools.GetTextFromOdt(file));
            }

            Console.WriteLine("Done.");
        }
    }
}