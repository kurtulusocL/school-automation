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
    public partial class WorkerAdd : Form
    {
        ApplicationDbContext _db;
        Worker wrk = new Worker();

        public WorkerAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtIdentity.Clear();
            txtMail.Clear();
            txtNameSurname.Clear();
            txtPhone.Clear();
            dtPickerBirthdate.ResetText();
            dtPickerHireDate.ResetText();
            cmbTask.SelectedValue = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            wrk.NameSurname = txtNameSurname.Text;
            wrk.IdentityNumber = txtIdentity.Text;
            wrk.MailAddress = txtMail.Text;
            wrk.PhoneNumber = txtPhone.Text;
            wrk.Birthdate = Convert.ToDateTime(dtPickerBirthdate.Value.ToShortDateString());
            wrk.HireDate = Convert.ToDateTime(dtPickerHireDate.Value.ToShortDateString());
            wrk.TaskInSchoolId = (int)cmbTask.SelectedValue;
            wrk.CreatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.Workers.Add(wrk);
            _db.SaveChanges();
            Clear();
        }

        private void WorkerAdd_Load(object sender, EventArgs e)
        {
            var taskList = _db.TaskInSchools.Include("Teachers").Include("Workers").OrderBy(i => i.Teachers.Count()).ToList();
            cmbTask.DataSource = taskList;
            cmbTask.ValueMember = "Id";
            cmbTask.DisplayMember = "KindOfTask";
        }

        private void btnEditPage_Click(object sender, EventArgs e)
        {
            WorkerEdit edit = new WorkerEdit();
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
