using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous2 : IFunction<string, bool> {
        public bool Apply(string value)
        {
            return !(value.Equals("false")) && !(value.Equals("0"));
        }
    }
}
