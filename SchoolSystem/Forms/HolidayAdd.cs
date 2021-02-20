using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Forms
{
    public partial class HolidayAdd : Form
    {
        ApplicationDbContext _db;
        Holiday hlday = new Holiday();

        public HolidayAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            cmbTeacher.SelectedValue = "";
            cmbWorker.SelectedValue = "";
            numDay.ResetText();
            dtPickerFinish.ResetText();
            dtPickerStart.ResetText();
            txtTitle.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hlday.TeacherId = (int?)cmbTeacher.SelectedValue;
            hlday.WorkerId = (int?)cmbWorker.SelectedValue;
            hlday.ComebackDate = Convert.ToDateTime(dtPickerFinish.Value.ToShortDateString());
            hlday.HolidayDate = Convert.ToDateTime(dtPickerStart.Value.ToShortDateString());
            hlday.Day = Convert.ToInt32(numDay.Value);
            hlday.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Holidays.Add(hlday);
            _db.SaveChanges();
            Clear();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            HolidayEdit edit = new HolidayEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void HolidayAdd_Load(object sender, EventArgs e)
        {
            var teacherList = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").OrderBy(i => i.Students.Count()).ToList();
            cmbTeacher.DataSource = teacherList;
            cmbTeacher.ValueMember = "Id";
            cmbTeacher.DisplayMember = "NameSurname";

            var workerList = _db.Workers.Include("TaskInSchool").Include("Holidays").OrderBy(i => i.Holidays.Count()).ToList();
            cmbWorker.DataSource = workerList;
            cmbWorker.ValueMember = "Id";
            cmbWorker.DisplayMember = "NameSurname";
        }
    }
}
