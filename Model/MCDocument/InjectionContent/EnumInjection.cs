using MinecraftLanguageModelLibrary.Model.MCDocument.EnumContent;

namespace MinecraftLanguageModelLibrary.Model.MCDocument.InjectionContent
{
    public class EnumInjection
    {
        public Enumeration Enumeration { get; set; } = new();
        public string Path { get; set; } = "";
        public List<EnumField> EnumFieldList { get; set; } = [];
    }
}
