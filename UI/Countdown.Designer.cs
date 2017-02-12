namespace Countdown
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lbDescription = new System.Windows.Forms.Label();
      this.lbDate = new System.Windows.Forms.Label();
      this.lbCountdown = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // lbDescription
      // 
      this.lbDescription.AutoSize = true;
      this.lbDescription.Location = new System.Drawing.Point(12, 20);
      this.lbDescription.Name = "lbDescription";
      this.lbDescription.Size = new System.Drawing.Size(79, 17);
      this.lbDescription.TabIndex = 0;
      this.lbDescription.Text = "Description";
      // 
      // lbDate
      // 
      this.lbDate.AutoSize = true;
      this.lbDate.Location = new System.Drawing.Point(382, 20);
      this.lbDate.Name = "lbDate";
      this.lbDate.Size = new System.Drawing.Size(38, 17);
      this.lbDate.TabIndex = 1;
      this.lbDate.Text = "Date";
      // 
      // lbCountdown
      // 
      this.lbCountdown.AutoSize = true;
      this.lbCountdown.Location = new System.Drawing.Point(618, 20);
      this.lbCountdown.Name = "lbCountdown";
      this.lbCountdown.Size = new System.Drawing.Size(78, 17);
      this.lbCountdown.TabIndex = 2;
      this.lbCountdown.Text = "Countdown";
      this.lbCountdown.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Interval = 1;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(898, 404);
      this.Controls.Add(this.lbCountdown);
      this.Controls.Add(this.lbDate);
      this.Controls.Add(this.lbDescription);
      this.Name = "Form1";
      this.Text = "Countdown";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbDescription;
    private System.Windows.Forms.Label lbDate;
    private System.Windows.Forms.Label lbCountdown;
    private System.Windows.Forms.Timer timer;
  }
}

