using MinecraftLanguageModelLibrary.Model.MCDocument.UnAttributedTypeContent;
using static MinecraftLanguageModelLibrary.Model.MCDocument.MCDocumentEnum;

namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class UnAttributedType
    {
        public KeyWordType? KeyWordType { get; set; }
        public StringType? StringType { get; set; }
        public LiteralType? LiteralType { get; set; }
        public NumericType? NumericType { get; set; }
        public PrimitiveArrayType? PrimitiveArrayType { get; set; }
        public ListType? ListType { get; set; }
        public TupleType? TupleType { get; set; }
        public Enumeration? EnumType { get; set; }
        public Structure? Structure { get; set; }
        public ReferenceType? ReferenceType { get; set; }
        public DispatchType? DispatchType { get; set; }
        public UnionType? UnionType { get; set; }
        public IndexOnAType? IndexOnAType { get; set; }
    }
}
