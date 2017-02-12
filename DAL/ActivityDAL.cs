namespace Countdown.DAL
{
  using System.Collections.Generic;
  using System.IO;
  using Dropbox.Api;
  using Dropbox.Api.Files;
  using Dropbox.Api.Stone;
  using Entity;
  using Newtonsoft.Json;

  internal class ActivityDAL
  {
    private string filepath;

    public ActivityDAL(string filepath)
    {
      this.filepath = filepath;
    }

    public IList<Activity> Activitities
    {
      get
      {
        Credentials credentials = JsonConvert.DeserializeObject<Credentials>(File.ReadAllText(this.filepath));
        string json = string.Empty;

        using (DropboxClient client = new DropboxClient(credentials.DropboxKey))
        {
          IDownloadResponse<FileMetadata> download = client.Files.DownloadAsync(credentials.ConfigFile).Result;
          json = download.GetContentAsStringAsync().Result;
        }

        return JsonConvert.DeserializeObject<IList<Activity>>(json);
      }
    }
  }
}
