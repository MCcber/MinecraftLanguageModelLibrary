namespace MinecraftLanguageModelLibrary.Data
{
    /// <summary>
    /// MCDocument元类型
    /// </summary>
    public enum MetaTypeKind
    {
        None,
        Byte,Short,Int, Long, Float, Double, String, Boolean,
        Definition,
        Entry,
        Add,
        Remove,
        Composite,
        CompositeRGB,
        CompositeARGB,
        DecRGB,
        DecRGBA,
        HexRGB,
        HexARGB,
        Identifier,
        Any,
        Literal,
        Struct,
        ByteArray,
        IntArray,
        LongArray,
        UUIDArray,
        List,
        Tuple,
        Enum,
        Union,
        Reference,
        Dispatch,
        Indexed,
        Generic
    }

    public enum MetaValueKind
    {
        //字面量（数字、字符串、布尔、引用）
        Literal,
        //类型表达式（对应typeSentence）
        Type,
        //( ... )
        Tuple,
        //[ ... ]
        List,
        //{ ... }或混合
        Object,
        Enum
    }
}
