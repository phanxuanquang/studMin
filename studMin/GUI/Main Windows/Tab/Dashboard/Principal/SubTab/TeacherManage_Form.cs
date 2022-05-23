using studMin.Database;
using studMin.Database.Models;
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
    public partial class TeacherManage_Form : Form
    {
        public TeacherManage_Form()
        {
            
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
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
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadDataToDataTable();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }

        private void LoadDataToDataTable()
        {
            DataTable.Rows.Clear();
            // query để load lại table theo từ khóa trong search box
            List<STAFF> listStaffs = StaffServices.Instance.GetStaffs();
            string enteredValue = Search_Box.Text;

            foreach (STAFF staff in listStaffs)
            {
                string staffName = staff.INFOR.FIRSTNAME + " " + staff.INFOR.LASTNAME;
                if (staffName.ToLower().Contains(enteredValue.ToLower()))
                {
                    string fullName = staff.INFOR.FIRSTNAME + " " + staff.INFOR.LASTNAME;
                    string gender = staff.INFOR.SEX == 0 ? "Nam" : "Nữ";
                    DataTable.Rows.Add(staff.ID, fullName, gender, staff.INFOR.DAYOFBIRTH, staff.USER.EMAIL);
                }
            }
        }

        private void FirePerson_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sa thải nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                string staffId = DataTable.SelectedRows[0].Cells[0].Value.ToString();
                STAFF selectedStaff = StaffServices.Instance.GetStaffById(staffId);

                DataProvider.Instance.Database.STAFFs.Remove(selectedStaff);
                DataProvider.Instance.Database.SaveChanges();

                LoadDataToDataTable();
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
