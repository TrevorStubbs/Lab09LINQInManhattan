using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab09LINQInManhattan.Classes
{
    /// <summary>
    /// Built using https://json2csharp.com/
    /// </summary>
    public class Root
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }

    }

}
