namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class MCDocumentFileModel
    {
        public List<Structure> StructureList { get; set; } = [];
        public List<Enumeration> EnumerationList { get; set; } = [];
        public List<TypeAlia> TypeAliaList { get; set; } = [];
        public List<UseStatement> UseStatementList { get; set; } = [];
        public List<Injection> InjectionList { get; set; } = [];
        public List<DispatchStatement> DispatchStatementList { get; set; } = [];
        public bool IsCollected { get; set; } = false;
    }
}
