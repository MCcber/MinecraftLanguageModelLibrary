namespace MinecraftLanguageModelLibrary.Data
{
    public class MCDocumentFile
    {
        /// <summary>
        /// 文件引用的外部路径
        /// </summary>
        public List<string> UsePathList { get; set; } = [];
        /// <summary>
        /// 根节点列表
        /// </summary>
        public List<MetaTypeEditorFieldDTO> RootList { get; set; } = [];
    }
}