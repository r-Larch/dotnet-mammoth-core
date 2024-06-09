using System;
using System.Net;
using System.Net.Http;
using Mammoth.Couscous.java.io;
using File = System.IO.File;


namespace Mammoth.Couscous.java.net {
    internal class Url {
        private readonly string _url;

        internal Url(string url)
        {
            _url = url;
        }

        internal INputStream OpenStream()
        {
            try {
                using var client = new HttpClient();
                var response = client.GetStreamAsync(_url).GetAwaiter().GetResult();
                try {
                    return ToJava.StreamToInputStream(response);
                }
                catch {
                    response.Close();
                    throw;
                }
            }
            catch (UriFormatException) {
                return ToJava.StreamToInputStream(File.OpenRead(_url));
            }
            catch (WebException exception) {
                throw new IoException(exception.Message);
            }
        }
    }
}
