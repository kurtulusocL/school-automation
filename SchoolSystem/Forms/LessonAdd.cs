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
    public partial class LessonAdd : Form
    {
        ApplicationDbContext _db;
        Lesson less = new Lesson();

        public LessonAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            less.Name = txtLessonName.Text;
            less.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Lessons.Add(less);
            _db.SaveChanges();
            txtLessonName.Clear();
        }

        private void btnEditPage_Click(object sender, EventArgs e)
        {
            LessonEdit edit = new LessonEdit();
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
