using System;
using System.IO;
using Mammoth.Couscous.java.io;
using IOException = Mammoth.Couscous.java.io.IOException;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Base64Encoding {
        internal static string streamToBase64(SupplierWithException<InputStream, IOException> streamSupplier)
        {
            using (var stream = streamSupplier.get().Stream) {
                return streamToBase64(stream);
            }
        }

        internal static string streamToBase64(Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }
}
