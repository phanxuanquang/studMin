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
        List<TEACHER> teacherList;
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

        private void LoadDataToDataTable(string enteredText, bool loadInitData)
        {
            DataTable.Rows.Clear();
            staffList = new List<STAFF>();
            teacherList = new List<TEACHER>();
            // query để load lại table theo từ khóa trong search box
            List<STAFF> listStaffs = StaffServices.Instance.GetStaffs();
            List<TEACHER> listTeachers = TeacherServices.Instance.GetTeachers();

            LoadList(listStaffs, enteredText, loadInitData);
            LoadList(listTeachers, enteredText, loadInitData);
        }

        private void FirePerson_Button_Click(object sender, EventArgs e)
        {
            if ((staffList == null || staffList.Count == 0) && (teacherList == null || teacherList.Count == 0))
            {
                MessageBox.Show("Không tìm thấy nhân viên, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sa thải nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                string staffId = DataTable.SelectedRows[0].Cells[0].Value.ToString();
                STAFF selectedStaff = DataProvider.Instance.Database.STAFFs.Where(item => item.ID.ToString().ToLower().Contains(staffId.ToLower())).FirstOrDefault();

                if (selectedStaff == null)
                {
                    TEACHER selectedTeacher = DataProvider.Instance.Database.TEACHERs.Where(item => item.ID.ToString().ToLower().Contains(staffId.ToLower())).FirstOrDefault();

                    selectedTeacher.USER.ISDELETED = true;
                }
                else
                {
                    selectedStaff.USER.ISDELETED = true;
                }

                DataProvider.Instance.Database.SaveChanges();

                LoadDataToDataTable(Search_Box.Text, false);
                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadDataToDataTable(Search_Box.Text.Trim(), false);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                Search_Box.Text = String.Empty;
            }
        }

        private void TeacherManage_Form_Load(object sender, EventArgs e)
        {
            LoadDataToDataTable(Search_Box.Text.Trim(), true);
        }

        public void LoadList(IEnumerable<dynamic> list, string enteredText, bool loadInitData)
        {
            foreach (var item in list)
            {
                string teacherName = item.INFOR.FIRSTNAME + " " + item.INFOR.LASTNAME;
                string gender = item.INFOR.SEX == 0 ? "Nam" : "Nữ";
                string role = item is TEACHER ? item.TEACHERROLE.ROLE : item.STAFFROLE.ROLE;

                if (role == "Hiệu trưởng" || role == "Phó hiệu trưởng" || role == "Trưởng bộ môn" || role == "Chủ nhiệm")
                {
                    continue;
                }

                if (!loadInitData)
                {
                    if ((teacherName.ToLower().Contains(enteredText.ToLower()) || item.ID.ToString().ToLower().Contains(enteredText.ToLower())) && !item.USER.ISDELETED)
                    {
                        if (item is TEACHER)
                        {
                            teacherList.Add(item);
                        }
                        else
                        {
                            staffList.Add(item);
                        }
                        DataTable.Rows.Add(item.ID.ToString().Substring(0, 8).ToUpper(), teacherName, gender, item.USER.EMAIL, role);
                    }
                }
                else
                {
                    if (!item.USER.ISDELETED)
                    {
                        if (item is TEACHER)
                        {
                            teacherList.Add(item);
                        }
                        else
                        {
                            staffList.Add(item);
                        }
                        DataTable.Rows.Add(item.ID.ToString().Substring(0, 8).ToUpper(), teacherName, gender, item.USER.EMAIL, role);
                    }
                }
            }
        }
    }
}