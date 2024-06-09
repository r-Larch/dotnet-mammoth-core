using System;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.java.util {
    internal interface IOptional<T> {
        bool IsPresent();
        IOptional<TU> Map<TU>(IFunction<T, TU> function);
        IOptional<TU> FlatMap<TU>(IFunction<T, IOptional<TU>> function);
        IOptional<T> Filter(function.IPredicate<T> predicate);
        T OrElse(T value);
        T OrElseGet(ISupplier<T> supplier);
        T OrElseThrow<TException>(ISupplier<TException> exceptionSupplier) where TException : Exception;
        T Get();
        void IfPresent(IConsumer<T> consumer);
    }

    internal interface INone {
    }

    internal struct None<T> : INone, IOptional<T> {
        public static readonly None<T> Instance = new();

        public override bool Equals(object other)
        {
            return other is INone;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool IsPresent()
        {
            return false;
        }

        public IOptional<TU> Map<TU>(IFunction<T, TU> function)
        {
            return new None<TU>();
        }

        public IOptional<TU> FlatMap<TU>(IFunction<T, IOptional<TU>> function)
        {
            return new None<TU>();
        }

        public IOptional<T> Filter(function.IPredicate<T> predicate)
        {
            return this;
        }

        public T OrElse(T value)
        {
            return value;
        }

        public T OrElseGet(ISupplier<T> supplier)
        {
            return supplier.Get();
        }

        public T OrElseThrow<TException>(ISupplier<TException> exceptionSupplier) where TException : Exception
        {
            throw exceptionSupplier.Get();
        }

        public T Get()
        {
            throw new NoSuchElementException();
        }

        public void IfPresent(IConsumer<T> consumer)
        {
        }
    }

    internal interface ISome {
        object GetObject();
    }

    internal struct Some<T> : ISome, IOptional<T> {
        private readonly T _value;

        internal Some(T value)
        {
            _value = value;
        }

        public override bool Equals(object other)
        {
            var otherSome = other as ISome;
            if (otherSome == null) {
                return false;
            }

            return _value.Equals(otherSome.GetObject());
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public bool IsPresent()
        {
            return true;
        }

        public IOptional<TU> Map<TU>(IFunction<T, TU> function)
        {
            return new Some<TU>(function.Apply(_value));
        }

        public IOptional<TU> FlatMap<TU>(IFunction<T, IOptional<TU>> function)
        {
            return function.Apply(_value);
        }

        public IOptional<T> Filter(function.IPredicate<T> predicate)
        {
            if (predicate.Test(_value)) {
                return this;
            }

            return None<T>.Instance;
        }

        public T OrElse(T value)
        {
            return _value;
        }

        public T OrElseGet(ISupplier<T> supplier)
        {
            return _value;
        }

        public T OrElseThrow<TException>(ISupplier<TException> exceptionSupplier) where TException : Exception
        {
            return _value;
        }

        public T Get()
        {
            return _value;
        }

        public object GetObject()
        {
            return _value;
        }

        public void IfPresent(IConsumer<T> consumer)
        {
            consumer.Accept(_value);
        }
    }

    internal static class Optional {
        internal static IOptional<T> Empty<T>()
        {
            return None<T>.Instance;
        }

        internal static IOptional<T> Of<T>(T value)
        {
            return new Some<T>(value);
        }
    }
}
