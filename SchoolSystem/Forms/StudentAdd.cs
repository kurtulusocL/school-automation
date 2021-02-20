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
    public partial class StudentAdd : Form
    {
        ApplicationDbContext _db;
        Student std = new Student();

        public StudentAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtIdentity.Clear();
            txtMail.Clear();
            txtNameSurname.Clear();
            txtNumber.Clear();
            txtPhone.Clear();
            dtPicBirthdate.ResetText();
            dtPicRegister.ResetText();
            cmbClass.SelectedValue = "";
            cmbLesson.SelectedValue = "";
            cmbTeacher.SelectedValue = "";
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            var lessonList = _db.Lessons.Include("Students").Include("Teachers").OrderBy(i => i.Students.Count()).ToList();
            cmbLesson.DataSource = lessonList;
            cmbLesson.ValueMember = "Id";
            cmbLesson.DisplayMember = "Name";

            var classList = _db.ClassTypes.Include("Students").Include("Teachers").OrderBy(i => i.Students.Count()).ToList();
            cmbClass.DataSource = classList;
            cmbClass.ValueMember = "Id";
            cmbClass.DisplayMember = "Name";

            var teacherList = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").OrderBy(i => i.Students.Count()).ToList();
            cmbTeacher.DataSource = teacherList;
            cmbTeacher.ValueMember = "Id";
            cmbTeacher.DisplayMember = "NameSurname";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            std.IdentityNumber = txtIdentity.Text;
            std.NameSurname = txtNameSurname.Text;
            std.PhoneNumber = txtPhone.Text;
            std.StudentNumber = txtNumber.Text;
            std.MailAddress = txtMail.Text;
            std.Birthdate = Convert.ToDateTime(dtPicBirthdate.Value.ToShortDateString());
            std.RegisterDate = Convert.ToDateTime(dtPicRegister.Value.ToShortDateString());
            std.ClassTypeId = (int)cmbClass.SelectedValue;
            std.TeacherId = (int)cmbTeacher.SelectedValue;
            std.LessonId = (int)cmbLesson.SelectedValue;
            std.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Students.Add(std);
            _db.SaveChanges();
            Clear();
        }

        private void btnEditPage_Click(object sender, EventArgs e)
        {
            StudentEdit edit = new StudentEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void cmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var getLesson = _db.Teachers.Where(i => i.LessonId == (int)cmbLesson.SelectedValue).ToList();
            //cmbLesson.DataSource = getLesson;
            //cmbLesson.DisplayMember = "Name";
            //cmbLesson.ValueMember = "Id";
        }

        private void cmbLesson_ValueMemberChanged(object sender, EventArgs e)
        {
            //var getLesson = _db.Teachers.Where(i => i.LessonId == (int)cmbLesson.SelectedValue).ToList();
            //cmbLesson.DataSource = getLesson;
            //cmbLesson.DisplayMember = "Name";
            //cmbLesson.ValueMember = "Id";
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var getClass = _db.Teachers.Where(i => i.ClassTypeId == (int)cmbClass.SelectedValue).ToList();
            //cmbClass.DataSource = getClass;
            //cmbClass.DisplayMember = "Name";
            //cmbClass.ValueMember = "Id";
        }

        private void cmbClass_ValueMemberChanged(object sender, EventArgs e)
        {
            //var getClass = _db.Teachers.Where(i => i.ClassTypeId == (int)cmbClass.SelectedValue).ToList();
            //cmbClass.DataSource = getClass;
            //cmbClass.DisplayMember = "Name";
            //cmbClass.ValueMember = "Id";
        }
    }
}
