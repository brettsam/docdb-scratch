using System;
using Newtonsoft.Json;

namespace NHClientTest
{
    public class Doc
    {
        [JsonProperty("_ts")]
        [JsonConverter(typeof(EpochConverter))]
        public DateTime TimeStamp { get; set; }
    }
}
