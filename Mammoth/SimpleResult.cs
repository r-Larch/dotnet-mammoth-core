using System.Collections.Generic;
using Mammoth.Couscous;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth {
    internal static class SimpleResult {
        internal static IResult<T> ToResult<T>(this InternalResult<T> result)
        {
            var warnings = new HashSet<string>(FromJava.IterableToEnumerable(result.GetWarnings()));
            return new SimpleResult<T>(result.GetValue(), warnings);
        }
    }

    internal class SimpleResult<T> : IResult<T> {
        internal SimpleResult(T value, ISet<string> warnings)
        {
            Value = value;
            Warnings = warnings;
        }

        public T Value { get; }
        public ISet<string> Warnings { get; }
    }
}
