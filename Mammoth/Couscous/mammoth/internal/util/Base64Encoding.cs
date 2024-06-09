using System;
using System.IO;
using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Base64Encoding {
        internal static string StreamToBase64(ISupplierWithException<INputStream, IoException> streamSupplier)
        {
            using (var stream = streamSupplier.Get().Stream) {
                return StreamToBase64(stream);
            }
        }

        internal static string StreamToBase64(Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }
}
