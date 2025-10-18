using MinecraftLanguageModelLibrary.Model.MCDocument;

namespace MinecraftLanguageModelLibrary.Model
{
    public class RequestModel
    {
        public required Enum.MCDocumentEnum Modifier { get; set; }
        public required MCDocumentFileModel Data { get; set; }
    }
}
