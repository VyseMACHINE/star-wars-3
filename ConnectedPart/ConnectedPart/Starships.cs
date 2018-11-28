using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedPart
{
    public class Starships
    {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("Manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("CostInCredits")]
        public string CostInCredits { get; set; }

        [JsonProperty("Length")]
        public string Length { get; set; }

        [JsonProperty("MaxAtmospheringSpeed")]
        public string MaxAtmospheringSpeed { get; set; }

        [JsonProperty("Crew")]
        public string Crew { get; set; }

        [JsonProperty("Passengers")]
        public string Passengers { get; set; }

        [JsonProperty("CargoCapacity")]
        public string CargoCapacity { get; set; }

        [JsonProperty("Consumables")]
        public string Consumables { get; set; }

        [JsonProperty("HyperdriveRating")]
        public string HyperdriveRating { get; set; }

        [JsonProperty("MGLT")]
        public string MGLT { get; set; }

        [JsonProperty("StarshipClass")]
        public string StarshipClass { get; set; }

        [JsonProperty("Pilots")]
        public IList<object> Pilots { get; set; }

        [JsonProperty("Films")]
        public IList<string> Films { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("Edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("Url")]
        public string Url { get; set; }
    }
}
