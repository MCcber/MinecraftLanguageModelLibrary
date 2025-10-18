namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class MCDocumentTreeBody
    {
        public List<PositionalValue>? PositionalValueList { get; set; }
        public List<NamedValues>? NamedValueList { get; set; }
        public Tuple<List<PositionalValue>, List<NamedValue>>? PositionalValueAndNamedValue { get; set; }
    }
}