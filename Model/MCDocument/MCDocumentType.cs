namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class MCDocumentType
    {
        public List<MCDocumentAttribute>? AttributeList { get; set; }
        public UnAttributedType? UnAttributedType { get; set; } = new();
        public List<IndexBody>? IndexBodyList { get; set; }
        public List<TypeArgBlock>? TypeArgBlockList { get; set; }
    }
}
