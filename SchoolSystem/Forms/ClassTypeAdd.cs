using SchoolSystem.Data;
using System;
using SchoolSystem.Models;
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
    public partial class ClassTypeAdd : Form
    {
        ApplicationDbContext _db;
        ClassType edit = new ClassType();

        public ClassTypeAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            edit.Name = txtName.Text;
            edit.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.ClassTypes.Add(edit);
            _db.SaveChanges();
            txtName.Clear();
        }

        private void btnEditPage_Click(object sender, EventArgs e)
        {
            ClassTypeEdit type = new ClassTypeEdit();
            this.Hide();
            type.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }
    }
}
