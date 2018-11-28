using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedPart
{
  public class People
    {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Height")]
        public string Height { get; set; }

        [JsonProperty("Mass")]
        public string Mass { get; set; }

        [JsonProperty("HairColor")]
        public string HairColor { get; set; }

        [JsonProperty("SkinColor")]
        public string SkinColor { get; set; }

        [JsonProperty("EyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("BirthYear")]
        public string BirthYear { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("Films")]
        public IList<string> Films { get; set; }

        [JsonProperty("Species")]
        public IList<string> Species { get; set; }

        [JsonProperty("Vehicles")]
        public IList<string> Vehicles { get; set; }

        [JsonProperty("Starships")]
        public IList<string> Starships { get; set; }

        [JsonProperty("Created")]
        public DateTime Created { get; set; }

        [JsonProperty("Edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }
    }
}
