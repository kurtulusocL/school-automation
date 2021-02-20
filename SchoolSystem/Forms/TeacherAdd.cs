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
    public partial class TeacherAdd : Form
    {
        ApplicationDbContext _db;
        Teacher teach = new Teacher();

        public TeacherAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtPhoneNumber.Clear();
            txtNameSurname.Clear();
            txtMail.Clear();
            txtIdentity.Clear();
            cmbClass.SelectedValue = "";
            cmbLesson.SelectedValue = "";
            cmbTask.SelectedValue = "";
            dtPicBirthdate.ResetText();
            dtPickerHireDate.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            teach.IdentityNumber = txtIdentity.Text;
            teach.NameSurname = txtNameSurname.Text;
            teach.PhoneNumber = txtPhoneNumber.Text;
            teach.MailAddress = txtPhoneNumber.Text;
            teach.Birthdate = Convert.ToDateTime(dtPicBirthdate.Value.ToShortDateString());
            teach.HireDate = Convert.ToDateTime(dtPickerHireDate.Value.ToShortDateString());
            teach.ClassTypeId = (int)cmbClass.SelectedValue;
            teach.LessonId = (int)cmbLesson.SelectedValue;
            teach.TaskInSchoolId = (int)cmbTask.SelectedValue;
            teach.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Teachers.Add(teach);
            _db.SaveChanges();
            Clear();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            TeacherEdit edit = new TeacherEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void TeacherAdd_Load(object sender, EventArgs e)
        {
            var lessonList = _db.Lessons.Include("Students").Include("Teachers").OrderBy(i => i.Teachers.Count()).ToList();
            cmbLesson.DataSource = lessonList;
            cmbLesson.ValueMember = "Id";
            cmbLesson.DisplayMember = "Name";

            var classList = _db.ClassTypes.Include("Students").Include("Teachers").OrderBy(i => i.Students.Count()).ToList();
            cmbClass.DataSource = classList;
            cmbClass.ValueMember = "Id";
            cmbClass.DisplayMember = "Name";

            var taskList = _db.TaskInSchools.Include("Workers").Include("Teachers").OrderBy(i => i.Workers.Count()).ToList();
            cmbTask.DataSource = taskList;
            cmbTask.ValueMember = "Id";
            cmbTask.DisplayMember = "KindOfTask";
        }
    }
}
