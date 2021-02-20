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
    public partial class StudentNoteAdd : Form
    {
        ApplicationDbContext _db;
        StudentNote note = new StudentNote();

        public StudentNoteAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            cmbNameSurname.SelectedValue = "";
            numExam1.ResetText();
            numExam2.ResetText();
            numExam3.ResetText();
            numExamFinal.ResetText();
            numnumExamVize.ResetText();
            numHomework.ResetText();
            lblResult.Text = "";
            lblDurum.Text = "";
        }

        private void StudentNoteAdd_Load(object sender, EventArgs e)
        {
            cmbNameSurname.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").OrderBy(i => i.StudentNotes.Count()).ToList();
            cmbNameSurname.ValueMember = "Id";
            cmbNameSurname.DisplayMember = "NameSurname";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            note.StudentId = (int)cmbNameSurname.SelectedValue;
            note.Exam1 = Convert.ToDouble(numExam1.Value);
            note.Exam2 = Convert.ToDouble(numExam2.Value);
            note.Exam3 = Convert.ToDouble(numExam3.Value);
            note.Vize = Convert.ToDouble(numnumExamVize.Value);
            note.Final = Convert.ToDouble(numExamFinal.Value);
            note.Homework = Convert.ToDouble(numHomework.Value);
            note.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (note.Result >= 70)
            {
                note.Statu = "Öğrenci sınıfı geçmiştir.";
            }
            else
            {
                note.Statu = "Öğrenci sınıfı geçememiştir.";
            }

            note.Result = ((Convert.ToDouble(numExam1.Value) * 0.2) + (Convert.ToDouble(numExam2.Value) * 0.1) + (Convert.ToDouble(numnumExamVize.Value) * 0.25) + (Convert.ToDouble(numExam3.Value) * 0.15) + (Convert.ToDouble(numExamFinal.Value) * 0.35) + (Convert.ToDouble(numHomework.Value) * 0.1));
            
            _db.StudentNotes.Add(note);
            _db.SaveChanges();
            Clear();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            StudentNoteEdit edit = new StudentNoteEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void lblResult_DoubleClick(object sender, EventArgs e)
        {
            note.Result = ((Convert.ToDouble(numExam1.Value) * 0.2) + (Convert.ToDouble(numExam2.Value) * 0.1) + (Convert.ToDouble(numnumExamVize.Value) * 0.25) + (Convert.ToDouble(numExam3.Value) * 0.15) + (Convert.ToDouble(numExamFinal.Value) * 0.35) + (Convert.ToDouble(numHomework.Value) * 0.1));
            lblResult.Text = Convert.ToString(note.Result);

            if (note.Result >= 70)
            {
                lblDurum.Text = "Öğrenci sınıfını geçmiştir.";
                lblDurum.BackColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "Öğrenci sınıfını geçememiştir.";
                lblDurum.BackColor = Color.Red;
            }
        }
    }
}
