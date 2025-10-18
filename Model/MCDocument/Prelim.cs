namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class Prelim
    {
        public List<string> DocCommentaryList { get; set; } = [];
        public List<string> CommentaryList { get; set; } = [];
        public MCDocumentAttribute? Attribute { get; set; }
    }
}
