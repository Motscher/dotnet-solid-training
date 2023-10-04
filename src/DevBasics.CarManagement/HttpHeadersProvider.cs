using System.Collections.Generic;

namespace DevBasics.CarManagement
{
    public static class HttpHeadersProvider
    {
        public static IDictionary<string, string> GetHttpHeaders()
        {
            var httpHeaders = new Dictionary<string, string>
            {
                { "Content-Type", "application/json" },
            };
            return httpHeaders;
        }
    }
}