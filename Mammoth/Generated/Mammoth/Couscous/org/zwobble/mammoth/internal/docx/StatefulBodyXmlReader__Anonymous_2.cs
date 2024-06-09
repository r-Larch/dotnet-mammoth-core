using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_2 : Function<string, bool> {
        public bool apply(string value)
        {
            return !(value.Equals("false")) && !(value.Equals("0"));
        }
    }
}
