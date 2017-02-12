namespace Countdown.BL
{
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using DAL;
  using Entity;

  internal class ActivityBL
  {
    private ActivityDAL dal;
    public IList<Activity> Activities { get; private set; }

    public ActivityBL()
    {
      this.dal = new ActivityDAL($"{AppDomain.CurrentDomain.BaseDirectory}Config{Path.DirectorySeparatorChar}Credentials.json");
      this.Load();
    }

    private void Load()
    {
      IList<Activity> activities = this.dal.Activitities;

      this.Activities = activities
        .Where(item => !item.Status.Equals("closed"))
        .OrderBy(item => item.Date)
        .ToList();
    }
  }
}
