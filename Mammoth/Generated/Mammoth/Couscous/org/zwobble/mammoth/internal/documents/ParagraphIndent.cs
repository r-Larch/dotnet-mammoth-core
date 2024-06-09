using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class ParagraphIndent {
        internal Optional<string> _end;
        internal Optional<string> _firstLine;
        internal Optional<string> _hanging;
        internal Optional<string> _start;

        internal ParagraphIndent(Optional<string> start, Optional<string> end, Optional<string> firstLine, Optional<string> hanging)
        {
            _start = start;
            _end = end;
            _firstLine = firstLine;
            _hanging = hanging;
        }

        public Optional<string> getStart()
        {
            return _start;
        }

        public Optional<string> getEnd()
        {
            return _end;
        }

        public Optional<string> getFirstLine()
        {
            return _firstLine;
        }

        public Optional<string> getHanging()
        {
            return _hanging;
        }
    }
}
