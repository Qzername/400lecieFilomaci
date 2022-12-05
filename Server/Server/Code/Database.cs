namespace Server.Code
{
    public static class Database
    {
        public static string[] Persons;

        static Database()
        {
            List<string> personsList = new List<string>();

            foreach (string path in Directory.GetDirectories("./Data/"))
                personsList.Add(path.Split('/')[^1]);

            Persons = personsList.ToArray();
        }
    }
}
