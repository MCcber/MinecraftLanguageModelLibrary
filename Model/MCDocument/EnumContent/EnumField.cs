namespace MinecraftLanguageModelLibrary.Model.MCDocument.EnumContent
{
    public class EnumField
    {
        public List<Prelim>? PrelimList { get; set; }
        public List<MCDocumentAttribute>? AttributeList { get; set; }
        public string? Key { get; set; } = "";
        public EnumValue? Value { get; set; } = new();
    }
}
