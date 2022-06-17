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

        public LoadingWindow(Form parentForm, string title = "")
        {
            if (parentForm == null) throw new ArgumentNullException();
            else this.parentForm = parentForm;

            InitializeComponent();

            this.SuspendLayout();

            this.Location = new Point(this.parentForm.Location.X + this.parentForm.Width / 2 - this.Width / 2, this.parentForm.Location.Y + this.parentForm.Height / 2 - this.Height / 2);
            if (!String.IsNullOrEmpty(title)) label1.Text = title;

            this.ResumeLayout(false);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
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
