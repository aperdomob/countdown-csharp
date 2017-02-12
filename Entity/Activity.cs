namespace Countdown.Entity
{
  using System;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;
  internal class Activity
  {
    [JsonProperty(PropertyName ="description")]
    public string Description { get; set; }

    [JsonProperty(PropertyName = "date")]
    [JsonConverter(typeof(IsoDateTimeConverter))]
    public DateTime Date { get; set; }

    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }
  }
}
