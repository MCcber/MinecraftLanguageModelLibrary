namespace MinecraftLanguageModelLibrary.Data
{
    public class MetaNamedValue
    {
        public string Name { get; set; } = string.Empty;
        public MetaValue Value { get; set; } = new();
    }
}
