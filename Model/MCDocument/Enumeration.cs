using MinecraftLanguageModelLibrary.Model.MCDocument.EnumContent;
using static MinecraftLanguageModelLibrary.Model.MCDocument.MCDocumentEnum;

namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class Enumeration
    {
        public Prelim? Prelim { get; set; }
        public EnumMemberType? MemberType { get; set; }
        public string? Name { get; set; }
        public List<EnumField>? EnumFieldList { get; set; }
        public bool IsTop { get; set; } = true;
    }
}
