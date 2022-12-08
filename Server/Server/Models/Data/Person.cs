using static System.Net.Mime.MediaTypeNames;

namespace Server.Models.Data
{
    public struct Person
    {
        public string Name;
        public string Category;
        public string ShortText;
        public string LongText;

        public Person(string name, string category)
        {
            Name = name;
            Category = category;

            string[] files = Directory.GetFiles($"./Data/{category}/{name}/");

            LongText = File.ReadAllText(files[0]);

            if (files.Length == 1)
                ShortText = string.Empty;
            else
                ShortText = File.ReadAllText(files[1]);
        }
    }
}
