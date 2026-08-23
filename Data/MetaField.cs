namespace MinecraftLanguageModelLibrary.Data
{
    public class MetaField
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 类型
        /// </summary>
        public required MetaType Type { get; set; }

        /// <summary>
        /// 是否必选
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// tripleDot '...'，表示扩展基类字段
        /// </summary>
        public bool IsSpread { get; set; }

        /// <summary>
        /// 文档注释
        /// </summary>
        public string? DocumentComments { get; set; }

        /// <summary>
        /// 字段属性
        /// </summary>
        public Dictionary<string, MetaValue>? AttributeList { get; set; }
    }
}