using System.Collections;
using System.Collections.Generic;


namespace Mammoth.Couscous.java.util {
    internal interface IMap {
        IDictionary AsUntypedDictionary();
    }

    internal interface IMap<TK, TV> : IMap {
        void Put(TK key, TV value);
        bool ContainsKey(TK key);
        ISet<IMapEntry<TK, TV>> EntrySet();
        ICollection<TV> Values();

        IOptional<TV> _lookup(TK key);
        IDictionary<TK, TV> AsDictionary();
    }

    internal interface IMapEntry<TK, TV> {
        TK GetKey();
        TV GetValue();
    }
}
