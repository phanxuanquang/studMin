using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studMin
{
    using Database.Models;
    public partial class ClassManage_SubTab : UserControl
    {
        public ClassManage_SubTab()
        {
            InitializeComponent();
            this.Load += ClassManage_SubTab_Load;
        }

        private void ClassManage_SubTab_Load(object sender, EventArgs e)
        {
            BidingClass();
        }

        private void AddClass_Button_Click(object sender, EventArgs e)
        {
            AddClass_Form addClass_Form = new AddClass_Form();
            addClass_Form.ShowDialog();
        }

        private void ChangeAgeRange_Button_Click(object sender, EventArgs e)
        {
            ChangeAgeRange_Form changeAgeRange_Form = new ChangeAgeRange_Form();
            changeAgeRange_Form.ShowDialog();
        }

        private void BidingClass()
        {
            cLASSBindingSource.ResetBindings(true);
            cLASSBindingSource.DataSource = Database.ClassServices.Instance.GetClasss();
            var maxQuantity = Database.ParameterServices.Instance.GetParameterByName("MAXQUANTITY").MAX;
            foreach (DataGridViewRow row in GridView.Rows)
            {
                CLASS selected = row.DataBoundItem as CLASS;
                if (selected != null)
                {
                    row.Cells["NameClassHeadTeacher"].Value = selected.TEACHER.INFOR.FIRSTNAME + " " + selected.TEACHER.INFOR.LASTNAME;
                    row.Cells["Quantity"].Value = Database.ClassServices.Instance.GetQuantityOfClass(selected.ID);
                    row.Cells["MaxQuantity"].Value = maxQuantity;
                }
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            var listClass = Database.ClassServices.Instance.GetClasss().Select(item => item.CLASSNAME);
            if (listClass.Count() != listClass.Distinct().Count())
            {
                MessageBox.Show("Tên lớp đã tồn tại!");
                //Database.DataProvider.Instance.Database.Entry(Database.DataProvider.Instance.Database.CLASSes).Reload();
                RefreshAll();
                BidingClass();
                return;
            }
            Database.DataProvider.Instance.Database.SaveChanges();
        }

        public void RefreshAll()
        {
            foreach (var entity in Database.DataProvider.Instance.Database.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }
    }
}
