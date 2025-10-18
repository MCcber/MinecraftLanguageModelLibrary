namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class Structure
    {
        public string? Identifier { get; set; } = "";
        public List<Prelim>? PrelimList { get; set; }
        public List<StructField>? StructFieldList { get; set; }
        public bool IsTop { get; set; } = true;
    }
}
