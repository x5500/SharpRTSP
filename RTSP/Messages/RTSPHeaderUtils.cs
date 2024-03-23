using System.Collections.Generic;
using System.Linq;

namespace Rtsp.Messages
{
    public static class RTSPHeaderUtils
    {
        public static IList<string> ParsePublicHeader(string? headerValue)
            => string.IsNullOrEmpty(headerValue) ? ([]) : (IList<string>)headerValue.Split(',').Select(m => m.Trim()).ToList();

        public static IList<string> ParsePublicHeader(RtspResponse response)
            => ParsePublicHeader(response.Headers.TryGetValue(RtspHeaderNames.Public, out var value) ? value : null);
    }
}