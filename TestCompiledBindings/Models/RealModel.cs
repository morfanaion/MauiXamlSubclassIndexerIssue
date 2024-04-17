namespace TestCompiledBindings.Models
{
    public class RealModel : BaseModel
    {
        public string Text => base[nameof(Text)];
    }
}
