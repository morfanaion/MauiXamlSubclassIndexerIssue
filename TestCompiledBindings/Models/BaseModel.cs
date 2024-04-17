namespace TestCompiledBindings.Models
{
    public class BaseModel
    {
        public virtual string this[string text]
        {
            get { return text; }
        }
    }
}
