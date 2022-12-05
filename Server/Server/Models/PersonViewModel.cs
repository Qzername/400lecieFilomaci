namespace Server.Models
{
    public class PersonViewModel : ViewModelBase 
    {
        public string PersonName { get; set; }
        public string Text { get; set; }
        public PersonViewModel(string personName, string text)
        {
            PersonName = personName;
            Text = text;
        }
    }
}