namespace BusinessLibrary.Models
{
    public class SubModel : BaseModel
    {
        public string Text2 => "This however works just fine";
        public override string Text4 => "SubModelText";
    }
}
