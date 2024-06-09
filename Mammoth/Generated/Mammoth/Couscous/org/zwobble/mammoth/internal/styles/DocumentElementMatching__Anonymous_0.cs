using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatchingAnonymous0 : IFunction<Style, string> {
        public string Apply(Style arg0)
        {
            return arg0.GetStyleId();
        }
    }

    internal class DocumentElementMatchingAnonymous1 : IBiPredicate<string, string> {
        public bool Test(string arg0, string arg1)
        {
            return arg0.Equals(arg1);
        }
    }

    internal class DocumentElementMatchingAnonymous2 : IFunction<Style, IOptional<string>> {
        public IOptional<string> Apply(Style arg0)
        {
            return arg0.GetName();
        }
    }

    internal class DocumentElementMatchingAnonymous3 : IBiPredicate<IStringMatcher, string> {
        public bool Test(IStringMatcher arg0, string arg1)
        {
            return arg0.Matches(arg1);
        }
    }

    internal class DocumentElementMatchingAnonymous4<TU, T>(IBiPredicate<T, TU> areEqual, T requiredValue) : IFunction<TU, bool> {
        public bool Apply(TU actualValue)
        {
            return areEqual.Test(requiredValue, actualValue);
        }
    }

    internal class DocumentElementMatchingAnonymous5<T, TU>(IOptional<TU> actual, IBiPredicate<T, TU> areEqual) : IFunction<T, bool> {
        public bool Apply(T requiredValue)
        {
            return actual.Map(new DocumentElementMatchingAnonymous4<TU, T>(areEqual, requiredValue)).OrElse(false);
        }
    }
}
