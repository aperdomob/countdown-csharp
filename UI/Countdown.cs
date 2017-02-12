namespace Countdown
{
  using System;
  using System.Text;
  using System.Windows.Forms;
  using BL;
  using Entity;

  public partial class Form1 : Form
  {
    private ActivityBL bl;

    public Form1()
    {
      InitializeComponent();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      if (this.bl == null)
      {
        this.timer.Interval = 1000;
        this.bl = new ActivityBL();

        StringBuilder descriptions = new StringBuilder();
        StringBuilder dates = new StringBuilder();

        foreach (Activity item in this.bl.Activities)
        {
          descriptions.AppendLine(item.Description);
          dates.AppendLine(item.Date.ToLongDateString());  
        }

        this.lbDescription.Text = descriptions.ToString();
        this.lbDate.Text = dates.ToString();
      }

      StringBuilder difference = new StringBuilder();

      foreach (Activity item in this.bl.Activities)
      {
        TimeSpan time = item.Date - DateTime.Now;
        difference.AppendLine(time.ToString(@"dd\.hh\:mm\:ss"));
      }

      this.lbCountdown.Text = difference.ToString();
    }
  }
}
