using Server.Models.Data;

namespace Server.Code
{
    public static class Database
    {
        static Person[] Persons;
        static char[] splitChars = new char[]
        {
            '\\',
            '/'
        };

        static Database()
        {
            List<Person> personsList = new List<Person>();

            foreach (string categoryPath in Directory.GetDirectories("./Data/"))
                foreach(string path in Directory.GetDirectories(categoryPath))
                {
                    Console.WriteLine(path);

                    string[] rawData = path.Split(splitChars); 
                    personsList.Add(new Person(rawData[^1], rawData[^2]));
                }

            Persons = personsList.ToArray();
        }

        public static bool DoesPersonExist(string name)
        {
            return Persons.Any(x => x.Name == name);
        }

        public static Person GetPerson(string name)
        {
            return Persons.Single(x => x.Name == name);
        }

        public static string[] GetPersonsNames()
        {
            return Persons.Select(x => x.Name).ToArray();
        }
    }
}
