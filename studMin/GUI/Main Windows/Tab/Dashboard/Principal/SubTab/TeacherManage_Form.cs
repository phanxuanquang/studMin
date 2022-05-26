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
        List<STAFF> staffList;
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

        private void LoadDataToDataTable(string enteredText)
        {
            if (String.IsNullOrEmpty(enteredText)) return;

            DataTable.Rows.Clear();
            staffList = new List<STAFF>();
            // query để load lại table theo từ khóa trong search box
            List<STAFF> listStaffs = StaffServices.Instance.GetStaffs();

            foreach (STAFF staff in listStaffs)
            {
                string staffName = staff.INFOR.FIRSTNAME + " " + staff.INFOR.LASTNAME;
                if (staffName.ToLower().Contains(enteredText.ToLower()))
                {
                    string gender = staff.INFOR.SEX == 0 ? "Nam" : "Nữ";
                    staffList.Add(staff);
                    DataTable.Rows.Add(staff.ID, staffName, gender, staff.INFOR.DAYOFBIRTH.ToString().Split(' ')[0], staff.USER.EMAIL);
                }
            }
        }

        private void FirePerson_Button_Click(object sender, EventArgs e)
        {
            if (staffList == null || staffList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sa thải nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                string staffId = DataTable.SelectedRows[0].Cells[0].Value.ToString();
                STAFF selectedStaff = StaffServices.Instance.GetStaffById(staffId);

                DataProvider.Instance.Database.STAFFs.Remove(selectedStaff);
                DataProvider.Instance.Database.SaveChanges();

                LoadDataToDataTable(Search_Box.Text);
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            LoadDataToDataTable(Search_Box.Text.Trim());
        }
    }
}
