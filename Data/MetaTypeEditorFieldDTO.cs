using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Windows.Input;

namespace MinecraftLanguageModelLibrary.Data
{
    public class MetaTypeEditorFieldDTO : INotifyPropertyChanged, IDisposable
    {
        #region Property
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// 字段显示名
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// 别名结构名称
        /// </summary>
        public string? TypeName { get; set; }

        /// <summary>
        /// 当前节点的ID
        /// </summary>
        public string ID { get; set; } = string.Empty;

        public DocumentPath? Path { get; set; }

        /// <summary>
        /// 父节点的引用
        /// </summary>
        public MetaTypeEditorFieldDTO? Parent { get; set; }

        /// <summary>
        /// 模板引用
        /// </summary>
        public MetaTypeEditorFieldDTO? TemplateReference { get; set; }

        /// <summary>
        /// 别名结构参数列表
        /// </summary>
        public List<Tuple<string, MetaValue>>? TypeParameterNameList { get; set; }

        /// <summary>
        /// 特征表
        /// </summary>
        public Dictionary<string, MetaValue> FeatureMap { get; set; } = [];

        /// <summary>
        /// 由调度器解释而来的节点
        /// </summary>
        public bool IsInterpretFromDispatch { get; set; }

        /// <summary>
        /// 是否允许显示
        /// </summary>
        public bool IsVisible { get; set; } = true;

        private bool isSettingValue = false;
        private object? value = null;

        /// <summary>
        /// 基础类型值
        /// </summary>
        public object? Value
        {
            get => value;
            set
            {
                if(isSettingValue || Equals(this.value, value))
                {
                    return;
                }
                isSettingValue = true;
                this.value = value;
                OnPropertyChanged();
                isSettingValue = false;
            }
        }

        private bool isTrue = true;
        public bool IsTrue
        {
            get => isTrue;
            set
            {
                if (Equals(isTrue, value) || isSettingValue)
                {
                    return;
                }
                isSettingValue = true;
                isTrue = value;
                OnPropertyChanged(nameof(IsTrue));
                if (IsRequired && !value)
                {
                    isFalse = true;
                    OnPropertyChanged(nameof(IsFalse));
                }
                else if (!IsRequired && value) 
                {
                    isFalse = false;
                    OnPropertyChanged(nameof(IsFalse));
                }
                else if (IsRequired && value)
                {
                    isFalse = false;
                    OnPropertyChanged(nameof(IsFalse));
                }
                isSettingValue = false;
            }
        }

        private bool isFalse = false;
        public bool IsFalse
        {
            get => isFalse;
            set
            {
                if (Equals(isFalse, value) || isSettingValue)
                {
                    return;
                }
                isSettingValue = true;
                isFalse = value;
                OnPropertyChanged(nameof(IsFalse));
                if (IsRequired && !value)
                {
                    isTrue = true;
                    OnPropertyChanged(nameof(IsTrue));
                }
                else if (!IsRequired && value)
                {
                    isTrue = false;
                    OnPropertyChanged(nameof(IsTrue));
                }
                else if (IsRequired && value)
                {
                    isTrue = false;
                    OnPropertyChanged(nameof(IsTrue));
                }
                isSettingValue = false;
            }
        }

        public ICommand? AddItemCommand { get; set; }
        public ICommand? RemoveItemCommand { get; set; }
        public ICommand? ReFreshCommand { get; set; }

        /// <summary>
        /// 元素类型
        /// </summary>
        public MetaTypeEditorFieldDTO? ElementType { get; set; }
        /// <summary>
        /// "int", "string", "struct" 等
        /// </summary>
        public MetaTypeKind TypeKind { get; set; }

        /// <summary>
        /// 存储原始类型，在调度器转化为基础类型后仍保留原始类型以供编辑使用
        /// </summary>
        public MetaTypeKind OriginKind { get; set; }
        public string? Watermark { get; set; }
        /// <summary>
        /// 是否必选
        /// </summary>
        [JsonInclude]
        public bool IsRequired { get; private set; }

        /// <summary>
        /// 定义类节点按下回车事件
        /// </summary>
        public Action? DefinitionEnterKeyDown { get; set; }

        /// <summary>
        /// 联合体选项更新事件
        /// </summary>
        public Action? SelectedUnionItemUpdated { get; set; }
        public int SelectedUnionItemIndex { get; set; }

        /// <summary>
        /// 联合体类型名称列表
        /// </summary>
        public ObservableCollection<EnumMember>? UnionTypeNameList { get; set; }

        private EnumMember? selectedUnionTypeName;
        public EnumMember? SelectedUnionTypeName
        {
            get => selectedUnionTypeName;
            set
            {
                bool isInitializing = selectedUnionTypeName is null && value is not null;
                selectedUnionTypeName = value;
                if (UnionTypeNameList is not null && selectedUnionTypeName is not null)
                {
                    SelectedUnionItemIndex = UnionTypeNameList.IndexOf(selectedUnionTypeName);
                }
                if (!isInitializing)
                {
                    SelectedUnionItemUpdated?.Invoke();
                }
                OnPropertyChanged();
            }
        }

        private ObservableCollection<MetaTypeEditorFieldDTO>? selectedUnionChildren;
        public ObservableCollection<MetaTypeEditorFieldDTO>? SelectedUnionChildren
        {
            get => selectedUnionChildren;
            set
            {
                selectedUnionChildren = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 枚举选项更新事件
        /// </summary>
        public Action? SelectedEnumItemUpdated { get; set; }
        public int SelectedEnumItemIndex { get; set; }

        /// <summary>
        /// 如果是枚举，提供选项文本
        /// </summary>
        public ObservableCollection<EnumMember>? EnumOptionList { get; set; }

        private EnumMember? selectedEnumOption;
        public EnumMember? SelectedEnumOption
        {
            get => selectedEnumOption;
            set
            {
                bool isInitializing = selectedEnumOption is null && value is not null;
                selectedEnumOption = value;
                if(EnumOptionList is not null && selectedEnumOption is not null)
                {
                    SelectedEnumItemIndex = EnumOptionList.IndexOf(selectedEnumOption);
                }
                if (!isInitializing)
                {
                    SelectedEnumItemUpdated?.Invoke();
                }
                OnPropertyChanged();
            }
        }

        private ObservableCollection<MetaTypeEditorFieldDTO>? children;
        /// <summary>
        /// struct 子字段
        /// </summary>
        public ObservableCollection<MetaTypeEditorFieldDTO>? Children
        {
            get => children;
            set
            {
                children = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<MetaTypeEditorFieldDTO>? items;
        /// <summary>
        /// 列表成员
        /// </summary>
        public ObservableCollection<MetaTypeEditorFieldDTO>? Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        public int CollectionLength { get; set; }
        public object? Min { get; set; }
        public object? Max { get; set; }
        #endregion

        #region Method
        public MetaTypeEditorFieldDTO(){ }

        public MetaTypeEditorFieldDTO(MetaTypeEditorFieldDTO source)
        {
            if (source is null)
            {
                return;
            }
            // 全新实例：目标字段全为空，CopyFrom 的"只填充空字段"语义即等价于完整拷贝
            CopyFrom(source);
        }

        /// <summary>
        /// 将 source 的属性合并复制到当前实例（就地复制，保持对象身份不变）。
        /// 只填充当前实例为空的字段，已存在的值不被覆盖。
        /// 注意：与拷贝构造不同，此方法不会创建新对象，适合需要保留外部引用
        /// （如父级 Children 集合、resultCache 键）的就地替换场景。
        /// </summary>
        /// <param name="source">数据来源</param>
        public void CopyFrom(MetaTypeEditorFieldDTO source)
        {
            if (source is null)
            {
                return;
            }
            if (string.IsNullOrEmpty(FieldName))
            {
                FieldName = source.FieldName;
            }
            SetRequired(source.IsRequired);
            TypeKind = source.TypeKind;
            if (!string.IsNullOrEmpty(source.TypeName))
            {
                TypeName ??= source.TypeName;
            }
            OriginKind = source.OriginKind;
            if (string.IsNullOrEmpty(ID))
            {
                ID = source.ID;
            }
            Watermark = source.Watermark;
            if (source.Children is not null)
            {
                Children = [.. source.Children];
            }
            Min = source.Min;
            Max = source.Max;
            // 只填充目标为空的 Path（拷贝构造中"新实例 Path 为空 → 总是复制"也由此覆盖）
            if (Path is null || Path.TargetPath.Length == 0)
            {
                Path = source.Path;
            }
            ElementType = source.ElementType;
            EnumOptionList = source.EnumOptionList;
            FeatureMap = source.FeatureMap;
            if (source.Items is not null)
            {
                Items = [.. source.Items];
            }
            TemplateReference ??= source.TemplateReference;
            TypeParameterNameList = source.TypeParameterNameList;
            UnionTypeNameList = source.UnionTypeNameList;
            Value = source.Value;
            SelectedUnionItemUpdated = source.SelectedUnionItemUpdated;
            SelectedEnumItemUpdated = source.SelectedEnumItemUpdated;
            SelectedUnionChildren = source.SelectedUnionChildren;
            EnumOptionList = source.EnumOptionList;
        }

        public void SetRequired(bool value)
        {
            IsRequired = value;
        }

        /// <summary>
        /// 辅助：根据类型返回默认值
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public object? GetDefaultValue() => TypeKind switch
        {
            MetaTypeKind.Boolean => false,
            MetaTypeKind.Byte => (byte)0,
            MetaTypeKind.Short => (short)0,
            MetaTypeKind.Int => 0,
            MetaTypeKind.Long => 0L,
            MetaTypeKind.Float => 0.0f,
            MetaTypeKind.Double => 0.0,
            MetaTypeKind.String => string.Empty,
            MetaTypeKind.Enum => SelectedEnumOption?.Value?.TypeValue?.LiteralValue?.ToString(),
            MetaTypeKind.Union => SelectedUnionTypeName?.Value?.TypeValue?.LiteralValue?.ToString(),      // Union 值不在 Value 字段体现
            MetaTypeKind.Struct => null,
            MetaTypeKind.Dispatch => null,
            MetaTypeKind.Reference => Value?.ToString() ?? "",
            MetaTypeKind.IntArray or MetaTypeKind.ByteArray or MetaTypeKind.LongArray => null,
            MetaTypeKind.List => null,
            MetaTypeKind.Literal => Value?.ToString(),
            _ => string.Empty
        };
        #endregion

        #region Event
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
            SelectedEnumItemUpdated = null;
            SelectedUnionItemUpdated = null;
            Children = null;
            Min = null;
            Max = null;
            Path = null;
            ElementType = null;
            EnumOptionList = null;
            FeatureMap = [];
            Items = null;
            TemplateReference = null;
            TypeParameterNameList = null;
            UnionTypeNameList = null;
            //GC.SuppressFinalize(this);
        }
        #endregion
    }
}