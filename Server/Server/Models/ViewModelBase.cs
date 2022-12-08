using Server.Code;
using Server.Models.Data;

namespace Server.Models
{
    public class ViewModelBase
    {
        public Dictionary<string,string[]> Persons => Database.GetCategoryAndPersons();
    }
}
