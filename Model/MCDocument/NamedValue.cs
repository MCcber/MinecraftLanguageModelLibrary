namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class NamedValue
    {
        public string? Identifier { get; set; }
        public string? String { get; set; }
        public MCDocumentValue? Value { get; set; } = new();
        public MCDocumentTreeValue? TreeValue { get; set; } = new();
    }
}