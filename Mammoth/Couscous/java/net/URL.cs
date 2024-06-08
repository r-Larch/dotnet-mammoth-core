using System.Net;
using System.Net.Http;
using Mammoth.Couscous.java.io;

namespace Mammoth.Couscous.java.net {
    internal class URL {
        private readonly string _url;
        
        internal URL(string url) {
            _url = url;
        }
        
        internal InputStream openStream() {
            try {
                using var client = new HttpClient();
                var response = client.GetStreamAsync(_url).GetAwaiter().GetResult();
                try {
                    return ToJava.StreamToInputStream(response);
                } catch {
                    response.Close();
                    throw;
                }
            } catch (System.UriFormatException) {
                return ToJava.StreamToInputStream(System.IO.File.OpenRead(_url));
            } catch (WebException exception) {
                throw new IOException(exception.Message);
            }
        }
    }
}
