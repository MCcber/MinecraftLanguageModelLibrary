using System.Collections.Generic;

namespace MinecraftLanguageModelLibrary.Data
{
    /// <summary>
    /// 泛型解析的逐层绑定作用域。
    /// </summary>
    public sealed class TypeBindingScope
    {
        /// <summary>
        /// 上一层泛型作用域。子作用域解析不到时逐级向上查找，
        /// 用于处理 dispatch -> generic -> dispatch 这类嵌套链路。
        /// </summary>
        public TypeBindingScope? Parent { get; init; }

        /// <summary>
        /// 当前层形参名 -> 实参 MetaValue 的绑定表。
        /// </summary>
        public Dictionary<string, MetaValue> Bindings { get; } = [];

        /// <summary>
        /// 按当前层、父层顺序解析泛型形参实参。
        /// </summary>
        public bool TryResolve(string name, out MetaValue? value)
        {
            if (Bindings.TryGetValue(name, out value))
            {
                return true;
            }

            if (Parent is not null)
            {
                return Parent.TryResolve(name, out value);
            }

            value = null;
            return false;
        }
    }
}
