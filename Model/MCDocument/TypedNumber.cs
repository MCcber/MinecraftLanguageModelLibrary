namespace MinecraftLanguageModelLibrary.Model.MCDocument
{
    public class TypedNumber
    {
        public bool IsIntType { get; set; }
        public bool IsFloatType { get; set; }
        public int Integer { get; set; }
        public char IntTypedUnit { get; set; }
        public float Float { get; set; }
        public char FloatTypedUnit { get; set; }
    }
}
