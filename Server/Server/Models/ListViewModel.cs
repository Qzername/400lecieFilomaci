namespace Server.Models
{
    public class ListViewModel : ViewModelBase
    {
        public string CategoryName;

        public ListViewModel(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
