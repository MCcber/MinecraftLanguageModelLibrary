namespace MinecraftLanguageModelLibrary.Data
{
    public class MetaType
    {
        /// <summary>
        /// 元类型
        /// </summary>
        public MetaTypeKind Kind { get; set; }

        /// <summary>
        /// 基础类型名,如 "int","float","string"，Struct 时是名字
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 别名结构名称
        /// </summary>
        public string? MetaTypeName { get; set; }

        /// <summary>
        /// 别名结构参数列表
        /// </summary>
        public Dictionary<string, MetaValue>? MetaTypeParameterNameList { get; set; }

        /// <summary>
        /// 字面量,当 Kind == Literal 时存储值
        /// </summary>
        public object? LiteralValue { get; set; }

        /// <summary>
        /// 结构体字段
        /// </summary>
        public List<MetaField>? FieldList { get; set; }

        /// <summary>
        /// List/List/Tuple 的元素类型
        /// </summary>
        public MetaType? ElementType { get; set; }
        
        /// <summary>
        /// 由调度器转化而来的常规节点
        /// </summary>
        public bool IsDispatchType { get; set; }

        /// <summary>
        /// 数组或列表长度
        /// </summary>
        public bool IsFixedLength { get; set; }

        /// <summary>
        /// 集合最小长度
        /// </summary>
        public int? MinLength { get; set; }

        /// <summary>
        /// 集合最大长度
        /// </summary>
        public int? MaxLength { get; set; }
        /// <summary>
        /// 成员最小值
        /// </summary>
        public int? MemberMinValue { get; set; }
        /// <summary>
        /// 成员最大值
        /// </summary>
        public int? MemberMaxValue { get; set; }
        
        /// <summary>
        /// 索引字符串列表
        /// </summary>
        public List<string>? IndexKeyList { get;set;  }

        /// <summary>
        /// 元组每个位置的具体类型
        /// </summary>
        public List<MetaType>? TupleElementTypeList { get; set; }

        /// <summary>
        /// 枚举,byte/short/int...
        /// </summary>
        public MetaType? EnumUnderlyingType { get; set; }
        /// <summary>
        /// 枚举成员列表
        /// </summary>
        public List<EnumMember>? EnumMemberList { get; set; }

        /// <summary>
        /// 联合列表
        /// </summary>
        public List<MetaType>? UnionOptionList { get; set; }

        /// <summary>
        /// 标识符
        /// </summary>
        public string? Identifier { get; set; }

        /// <summary>
        /// 引用，"::java::util::text::Text"
        /// </summary>
        public string? ReferencePath { get; set; }

        /// <summary>
        /// 分发
        /// </summary>
        public string? DispatcherResource { get; set; }

        /// <summary>
        /// 可能的分发目标类型集合
        /// </summary>
        public List<MetaType>? DispatcherCaseList { get; set; }

        /// <summary>
        /// 泛型 / 索引 (typeArgBlock 的参数)
        /// </summary>
        public List<MetaType>? TypeArgumentList { get; set; }

        /// <summary>
        /// Generic/Indexed 的基类型
        /// </summary>
        public MetaType? BaseType { get; set; }

        /// <summary>
        /// 通用属性 #[...] 注解
        /// </summary>
        public Dictionary<string, MetaValue>? AttributeList { get; set; }

        /// <summary>
        /// 文档注释
        /// </summary>
        public string? DocumentComments { get; set; }
    }
}