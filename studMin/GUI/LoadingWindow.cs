using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin.GUI
{
    public partial class LoadingWindow : Form
    {
        private Form parentForm = null;

        public LoadingWindow(Form parentForm)
        {
            if (parentForm == null) throw new ArgumentNullException();
            else this.parentForm = parentForm;

            InitializeComponent();

            this.SuspendLayout();

            this.Location = new Point(this.parentForm.Location.X + this.parentForm.Width / 2 - this.Width / 2, this.parentForm.Location.Y + this.parentForm.Height / 2 - this.Height / 2);

            this.ResumeLayout(false);
        }

        public void Show()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Action(() =>
                {
                    this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    base.Show();
                }));
            }
            else
            {
                this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                base.Show();
            }
        }

        public void ShowDialog()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Action(() => { base.ShowDialog(parentForm); }));
            }
            else
            {
                base.ShowDialog(parentForm);
            }
        }

        public void Close()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Action(() => { base.Close(); }));
            }
            else base.Close();
        }
    }
}
