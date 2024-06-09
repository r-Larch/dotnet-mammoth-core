using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class ParagraphIndent {
        private Optional<string> _end;
        private Optional<string> _firstLine;
        private Optional<string> _hanging;
        private Optional<string> _start;

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
