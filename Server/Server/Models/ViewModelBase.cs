using Server.Code;

namespace Server.Models
{
    public class ViewModelBase
    {
        public string[] Persons => Database.Persons;
    }
}
