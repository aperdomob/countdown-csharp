namespace Countdown.Entity
{
  using Newtonsoft.Json;

  internal class Credentials
  {
    [JsonProperty(PropertyName = "dropboxKey")]
    public string DropboxKey { get; set; }

    [JsonProperty(PropertyName = "configFile")]
    public string ConfigFile { get; set; }
  }
}
