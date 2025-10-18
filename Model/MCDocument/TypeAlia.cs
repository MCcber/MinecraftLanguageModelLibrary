namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class TypeAlia
    {
        public List<Prelim>? PrelimList { get; set; }
        public string? Identifier { get; set; } = "";
        public List<string>? TypeParameterBlock { get; set; }
        public MCDocumentType? TypeSentence { get; set; }
    }
}
