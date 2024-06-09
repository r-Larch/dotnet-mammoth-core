using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class ParagraphIndent(IOptional<string> start, IOptional<string> end, IOptional<string> firstLine, IOptional<string> hanging) {
        public IOptional<string> GetStart()
        {
            return start;
        }

        public IOptional<string> GetEnd()
        {
            return end;
        }

        public IOptional<string> GetFirstLine()
        {
            return firstLine;
        }

        public IOptional<string> GetHanging()
        {
            return hanging;
        }
    }
}
