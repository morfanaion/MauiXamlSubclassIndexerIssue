namespace BusinessLibrary.Models
{
    public class BaseModel
    {
        public string Text1 => "It runs, it shows, but there is an error in the logs";

        public virtual string Text4 => "BaseModelText";

        public virtual string this[string text]
        {
            get { return text; }
        }
    }
}
