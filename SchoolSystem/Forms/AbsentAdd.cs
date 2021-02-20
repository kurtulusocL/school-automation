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
    public partial class AbsentAdd : Form
    {
        ApplicationDbContext _db;
        StudentAbsent absent = new StudentAbsent();
        Student std = new Student();
        Lesson ders = new Lesson();

        public AbsentAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            cmbLesson.SelectedValue = "";
            cmbNameSurname.SelectedValue = "";
            dtPicDate.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            absent.StudentId = (int)cmbNameSurname.SelectedValue;
            absent.LessonId = (int?)cmbLesson.SelectedValue;
            absent.AbsentDate = Convert.ToDateTime(dtPicDate.Value.ToShortDateString());
            if (absent.IsReport == true)
            {
                absent.IsReport = Convert.ToBoolean(checkYes.Checked);
            }
            else
            {
                absent.IsReport = Convert.ToBoolean(chechNo.Checked);
            }
            absent.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.StudentAbsents.Add(absent);
            _db.SaveChanges();
            Clear();
        }

        private void btnEditPage_Click(object sender, EventArgs e)
        {
            AbsentEdit edit = new AbsentEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void AbsentAdd_Load(object sender, EventArgs e)
        {
            var studentList = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").OrderBy(i => i.StudentAbsents.Count).ToList();
            cmbNameSurname.DataSource = studentList;
            cmbNameSurname.ValueMember = "Id";
            cmbNameSurname.DisplayMember = "NameSurname";

            var lessonList = _db.Lessons.Include("Students").Include("Teachers").Include("StudentAbsents").OrderBy(i => i.Students.Count()).ToList();
            cmbLesson.DataSource = lessonList;
            cmbLesson.ValueMember = "Id";
            cmbLesson.DisplayMember = "Name";
        }
    }
}
