using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedPart
{
    public class Planets
    {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("RotationPeriod")]
        public string RotationPeriod { get; set; }

        [JsonProperty("orbitalPeriod")]
        public string orbitalPeriod { get; set; }

        [JsonProperty("Diameter")]
        public string Diameter { get; set; }

        [JsonProperty("Climate")]
        public string Climate { get; set; }

        [JsonProperty("Gravity")]
        public string Gravity { get; set; }

        [JsonProperty("Terrain")]
        public string Terrain { get; set; }

        [JsonProperty("SurfaceWater")]
        public string SurfaceWater { get; set; }

        [JsonProperty("Population")]
        public string Population { get; set; }

        [JsonProperty("Residents")]
        public IList<object> Residents { get; set; }

        [JsonProperty("Films")]
        public IList<string> Films { get; set; }

        [JsonProperty("Created")]
        public DateTime Created { get; set; }

        [JsonProperty("Edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }


    }
}
