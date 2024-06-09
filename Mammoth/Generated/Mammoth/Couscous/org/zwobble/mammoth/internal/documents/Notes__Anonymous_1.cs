using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NotesAnonymous1 : IFunction<Note, string> {
        public string Apply(Note arg0)
        {
            return arg0.GetId();
        }
    }
}
