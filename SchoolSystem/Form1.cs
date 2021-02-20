using SchoolSystem.Data;
using SchoolSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        ApplicationDbContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Istatistic()
        {
            lblClassCount.Text = Convert.ToString(_db.ClassTypes.Count());
            lblEmployeeCount.Text= Convert.ToString(_db.Workers.Count());
            lblExamCount.Text= Convert.ToString(_db.StudentNotes.Count());
            lblLessonCount.Text= Convert.ToString(_db.Lessons.Count());
            lblStudentCount.Text= Convert.ToString(_db.Students.Count());
            lblTaskCount.Text= Convert.ToString(_db.TaskInSchools.Count());
            lblTeacherCount.Text= Convert.ToString(_db.Teachers.Count());
            lblAbsent.Text= Convert.ToString(_db.StudentAbsents.Count());
            lblReport.Text= Convert.ToString(_db.Holidays.Count());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Istatistic();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Istatistic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void mniStudentList_Click(object sender, EventArgs e)
        {
            StudentList student = new StudentList();
            student.Show();
        }

        private void mniStudentEdit_Click(object sender, EventArgs e)
        {
            StudentEdit std = new StudentEdit();
            std.Show();
        }

        private void mniStudentNoteList_Click(object sender, EventArgs e)
        {
            StudentNoteList noteList = new StudentNoteList();
            noteList.Show();
        }

        private void mniNoteEdit_Click(object sender, EventArgs e)
        {
            StudentNoteEdit noteEdit = new StudentNoteEdit();
            noteEdit.Show();
        }

        private void mniTeacher_Click(object sender, EventArgs e)
        {
            TeacherList teachList = new TeacherList();
            teachList.Show();
        }

        private void mniTeacherEdit_Click(object sender, EventArgs e)
        {
            TeacherEdit teach = new TeacherEdit();
            teach.Show();
        }

        private void mniLessonList_Click(object sender, EventArgs e)
        {
            LessonList list = new LessonList();
            list.Show();
        }

        private void mniLessonEdit_Click(object sender, EventArgs e)
        {
            LessonEdit edit = new LessonEdit();
            edit.Show();
        }

        private void mniClassList_Click(object sender, EventArgs e)
        {
            ClassTypeList typeList = new ClassTypeList();
            typeList.Show();
        }

        private void mniClassEdit_Click(object sender, EventArgs e)
        {
            ClassTypeEdit type = new ClassTypeEdit();
            type.Show();
        }

        private void mniWorkerList_Click(object sender, EventArgs e)
        {
            WorkerList wList = new WorkerList();
            wList.Show();
        }

        private void mniWorkerEdit_Click(object sender, EventArgs e)
        {
            WorkerEdit worker = new WorkerEdit();
            worker.Show();
        }

        private void mniWorkerTaskList_Click(object sender, EventArgs e)
        {
            TaskInSchoolList taskList = new TaskInSchoolList();
            taskList.Show();
        }

        private void mniWorkerTaskEdit_Click(object sender, EventArgs e)
        {
            TaskInSchoolEdit task = new TaskInSchoolEdit();
            task.Show();
        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentAdd add = new StudentAdd();
            add.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherAdd tAdd = new TeacherAdd();
            tAdd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClassTypeAdd typeAdd = new ClassTypeAdd();
            typeAdd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LessonAdd lAdd = new LessonAdd();
            lAdd.Show();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            StudentNoteAdd noteAdd = new StudentNoteAdd();
            noteAdd.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            WorkerAdd wAdd = new WorkerAdd();
            wAdd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TaskInSchoolAdd task = new TaskInSchoolAdd();
            task.Show();
        }

        private void btnAbsentAdd_Click(object sender, EventArgs e)
        {
            AbsentAdd aAdd = new AbsentAdd();
            aAdd.Show();
        }

        private void mniAbsentList_Click(object sender, EventArgs e)
        {
            AbsentList aList = new AbsentList();
            aList.Show();
        }

        private void mniAbsent_Click(object sender, EventArgs e)
        {
            AbsentEdit abst = new AbsentEdit();
            abst.Show();
        }

        private void raporluÇalışanListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HolidayList hList = new HolidayList();
            hList.Show();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HolidayEdit hldy = new HolidayEdit();
            hldy.Show();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            HolidayAdd hAdd = new HolidayAdd();
            hAdd.Show();
        }
    }
}
