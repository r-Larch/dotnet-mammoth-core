using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous26 : IPredicate<string> {
        public bool Test(string description)
        {
            return !(JavaStringExtensions.Trim(description)).IsEmpty();
        }
    }
}
