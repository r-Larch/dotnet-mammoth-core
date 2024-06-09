namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class ParagraphIndent {
        internal Mammoth.Couscous.java.util.Optional<string> _start;
        internal Mammoth.Couscous.java.util.Optional<string> _end;
        internal Mammoth.Couscous.java.util.Optional<string> _firstLine;
        internal Mammoth.Couscous.java.util.Optional<string> _hanging;
        internal ParagraphIndent(Mammoth.Couscous.java.util.Optional<string> start, Mammoth.Couscous.java.util.Optional<string> end, Mammoth.Couscous.java.util.Optional<string> firstLine, Mammoth.Couscous.java.util.Optional<string> hanging) {
            this._start = start;
            this._end = end;
            this._firstLine = firstLine;
            this._hanging = hanging;
        }
        public Mammoth.Couscous.java.util.Optional<string> getStart() {
            return this._start;
        }
        public Mammoth.Couscous.java.util.Optional<string> getEnd() {
            return this._end;
        }
        public Mammoth.Couscous.java.util.Optional<string> getFirstLine() {
            return this._firstLine;
        }
        public Mammoth.Couscous.java.util.Optional<string> getHanging() {
            return this._hanging;
        }
    }
}

