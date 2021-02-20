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
    public partial class TaskInSchoolAdd : Form
    {
        ApplicationDbContext _db;
        TaskInSchool task = new TaskInSchool();

        public TaskInSchoolAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            task.KindOfTask = txtTask.Text;
            task.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.TaskInSchools.Add(task);
            _db.SaveChanges();
            txtTask.Clear();
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            TaskInSchoolEdit edit = new TaskInSchoolEdit();
            this.Hide();
            edit.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }
    }
}
