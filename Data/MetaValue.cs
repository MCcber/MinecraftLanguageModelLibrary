namespace MinecraftLanguageModelLibrary.Data
{
    public class MetaValue
    {
        public MetaValueKind Kind { get; set; }
        //存放int/long/float/double/decimal/string/bool
        public object? LiteralValue { get; set; }
        //当Kind == Type时有效
        public MetaType? TypeValue { get; set; }
        //当Kind == Tuple/Array时有效
        public List<MetaValue>? Items { get; set; }
        //当Kind == Object时有效
        public List<MetaNamedValue>? Members { get; set; }
        //调试用
        public string? RawText { get; set; }
    }
}