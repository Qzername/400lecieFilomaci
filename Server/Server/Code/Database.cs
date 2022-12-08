using Server.Models.Data;

namespace Server.Code
{
    public static class Database
    {
        static Person[] Persons;

        /// <summary>
        /// Key = Category
        /// Value = Persons in that category
        /// </summary>
        static Dictionary<string, string[]> PersonsDictionary;

        static char[] splitChars = new char[]
        {
            '\\',
            '/'
        };

        static Database()
        {
            List<Person> personsList = new List<Person>();
            PersonsDictionary = new Dictionary<string, string[]>();

            foreach (string categoryPath in Directory.GetDirectories("./Data/"))
            {
                string categoryName = categoryPath.Split(splitChars)[^1];
                List<string> persons = new List<string>();

                foreach (string path in Directory.GetDirectories(categoryPath))
                {
                    string[] rawData = path.Split(splitChars);
                    string personName = rawData[^1];

                    personsList.Add(new Person(personName, categoryName));
                    persons.Add(personName);
                }

                PersonsDictionary.Add(categoryName, persons.ToArray());
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

        public static Person[] GetPersons() => Persons;

        public static Dictionary<string, string[]> GetCategoryAndPersons() => PersonsDictionary;
    }
}
