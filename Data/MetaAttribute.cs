namespace MinecraftLanguageModelLibrary.Data
{
    public class MetaAttribute
    {
        /// <summary>
        /// identifier
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 可能是 string、McdocObject 等
        /// </summary>
        public object? Value { get; set; }
    }
}