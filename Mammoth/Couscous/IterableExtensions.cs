using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous {
    internal static class IterableExtensions {
        public static void ForEach<T>(this ITerable<T> iterable, IConsumer<T> consumer)
        {
            var iterator = iterable.Iterator();
            while (iterator.HasNext()) {
                consumer.Accept(iterator.Next());
            }
        }
    }
}
