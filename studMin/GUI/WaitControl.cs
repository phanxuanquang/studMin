using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin.GUI
{
    internal class WaitControl : IDisposable
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Form form = null;

        public void Dispose()
        {
            if (form != null)
            {
                form.Controls.Remove(progressBar);
            }
            this.components.Dispose();
            this.clock.Dispose();
            this.progressBar.Dispose();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.clock = new System.Windows.Forms.Timer(this.components);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Animated = true;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.progressBar.FillOffset = 15;
            this.progressBar.FillThickness = 12;
            this.progressBar.Location = new System.Drawing.Point(58, 34);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(132)))), ((int)(((byte)(248)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.progressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressBar.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressBar.ProgressThickness = 24;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(200, 200);
            this.progressBar.UseTransparentBackground = true;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            // 
            // clock
            // 
            this.clock.Interval = 1;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);

        }

        private void clock_Tick(object sender, EventArgs e)
        {
            this.progressBar.Value++;
            if (this.progressBar.Value == 100)
            {
                this.progressBar.Value = 0;
            }
        }

        public void Start()
        {
            this.progressBar.BringToFront();
            this.form.Enabled = false;
            if (this.progressBar.Visible == false)
            {
                this.progressBar.Visible = true;
            }
            this.clock.Start();
        }

        public void Stop()
        {
            if (this.progressBar.Visible == true)
            {
                this.progressBar.Visible = false;
            }
            this.form.Enabled = true;
            this.clock.Stop();
        }

        public WaitControl(System.Windows.Forms.Form form)
        {
            if (form == null) throw new Exception();
            this.form = form;

            this.InitializeComponent();

            this.progressBar.Left = (this.form.ClientSize.Width - this.progressBar.Width) / 2;
            this.progressBar.Top = (this.form.ClientSize.Height - this.progressBar.Height) / 2;
            this.progressBar.Visible = false;

            this.form.Controls.Add(this.progressBar);
        }
    }
}
