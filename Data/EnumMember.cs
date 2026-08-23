namespace MinecraftLanguageModelLibrary.Data
{
    public class EnumMember
    {
        public string? Name { get; set; }
        /// <summary>
        /// typedNumber 或 string
        /// </summary>
        public MetaValue? Value { get; set; }
        /// <summary>
        /// 数值单位
        /// </summary>
        public char? Unit { get; set; }
        public string? Documentation { get; set; }
        public string? Comments { get; set; }
        public Dictionary<string, MetaValue>? FeatureMap { get; set; }

        #region Equality
        public override bool Equals(object? obj) =>
            obj is EnumMember other
            && other.Name == Name
            && other.Value?.LiteralValue?.ToString() == Value?.LiteralValue?.ToString();

        public override int GetHashCode() =>
            HashCode.Combine(Name, Value?.LiteralValue?.ToString());
        #endregion
    }
}