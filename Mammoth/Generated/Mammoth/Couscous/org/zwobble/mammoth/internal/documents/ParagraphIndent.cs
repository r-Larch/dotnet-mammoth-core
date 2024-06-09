using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class ParagraphIndent {
        private IOptional<string> _end;
        private IOptional<string> _firstLine;
        private IOptional<string> _hanging;
        private IOptional<string> _start;

        internal ParagraphIndent(IOptional<string> start, IOptional<string> end, IOptional<string> firstLine, IOptional<string> hanging)
        {
            _start = start;
            _end = end;
            _firstLine = firstLine;
            _hanging = hanging;
        }

        public IOptional<string> GetStart()
        {
            return _start;
        }

        public IOptional<string> GetEnd()
        {
            return _end;
        }

        public IOptional<string> GetFirstLine()
        {
            return _firstLine;
        }

        public IOptional<string> GetHanging()
        {
            return _hanging;
        }
    }
}
