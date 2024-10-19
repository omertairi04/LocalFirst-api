namespace Local_Alternatives.Helpers;

using Newtonsoft.Json;

public class CityJson
{
    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("lat")]
    public string Lat { get; set; }

    [JsonProperty("lng")]
    public string Lng { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("iso2")]
    public string Iso2 { get; set; }

    [JsonProperty("admin_name")]
    public string AdminName { get; set; }  // Correctly maps "admin_name" from JSON

    [JsonProperty("capital")]
    public string Capital { get; set; }

    [JsonProperty("population")]
    public string Population { get; set; }

    [JsonProperty("population_proper")]
    public string PopulationProper { get; set; }
}
