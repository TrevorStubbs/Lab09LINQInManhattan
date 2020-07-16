using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab09LINQInManhattan.Classes
{
    /// <summary>
    /// Built using https://json2csharp.com/
    /// </summary>
    public class Feature
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

    }
}
