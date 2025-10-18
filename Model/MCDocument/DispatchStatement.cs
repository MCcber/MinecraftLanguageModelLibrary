namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class DispatchStatement
    {
        public Prelim? Prelim { get; set; }
        public List<MCDocumentAttribute>? AttributeList { get; set; }
        public string? ResourceLocation { get; set; }
        public IndexBody? IndexBody { get; set; } = new();
        public List<string>? TypeParameterBlock { get; set; }
        public MCDocumentType? Type { get; set; }= new();
    }
}
