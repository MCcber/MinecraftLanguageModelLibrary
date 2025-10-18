namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class StructField
    {
        public bool IsReference { get; set; }
        public bool IsOptional { get; set; }
        public StructKey? StructKey { get; set; } = new();
        public MCDocumentType? Type { get; set; } = new();
        public List<Prelim>? PrelimList { get; set; }
        public List<MCDocumentAttribute>? AttributeList { get; set; }
    }
}