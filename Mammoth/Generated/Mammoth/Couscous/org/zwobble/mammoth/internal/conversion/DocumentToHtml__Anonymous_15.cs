namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_15 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.lang.RuntimeException> {
        internal string _commentId;
        internal DocumentToHtml__Anonymous_15(string commentId) {
            this._commentId = commentId;
        }
        public Mammoth.Couscous.java.lang.RuntimeException get() {
            return new Mammoth.Couscous.java.lang.RuntimeException("Referenced comment could not be found, id: " + this._commentId);
        }
    }
}

