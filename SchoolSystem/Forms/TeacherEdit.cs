using iTextSharp.text;
using iTextSharp.text.pdf;
using SchoolSystem.Data;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Forms
{
    public partial class TeacherEdit : Form
    {
        ApplicationDbContext _db;
        Teacher teach = new Teacher();

        public TeacherEdit()
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
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridTeacher.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.PhoneNumber,
                i.MailAddress,
                i.IdentityNumber,
                i.Birthdate,
                i.HireDate,
                TaskInSchool = i.TaskInSchool.KindOfTask,
                ClassType = i.ClassType.Name,
                Lesson = i.Lesson.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.TaskInSchoolId,
                i.ClassTypeId,
                i.LessonId
            }).OrderBy(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridTeacher.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.PhoneNumber,
                i.MailAddress,
                i.IdentityNumber,
                i.Birthdate,
                i.HireDate,
                TaskInSchool = i.TaskInSchool.KindOfTask,
                ClassType = i.ClassType.Name,
                Lesson = i.Lesson.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.TaskInSchoolId,
                i.ClassTypeId,
                i.LessonId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void TeacherEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Öğretmen Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();
        }

        private void dtGridTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridTeacher.CurrentRow;
            txtNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            txtNameSurname.Tag = row.Cells["Id"].Value;
            txtIdentity.Text = row.Cells["IdentityNumber"].Value.ToString();
            txtMail.Text = row.Cells["MailAddress"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
            dtPicBirthdate.Value = Convert.ToDateTime(row.Cells["Birthdate"].Value.ToString());
            dtPickerHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value.ToString());
            cmbClass.SelectedValue = row.Cells["ClassTypeId"].Value.ToString();
            cmbLesson.SelectedValue = row.Cells["LessonId"].Value.ToString();
            cmbTask.SelectedValue = row.Cells["TaskInSchoolId"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var teacherId = (int)txtNameSurname.Tag;
            teach = _db.Teachers.FirstOrDefault(i => i.Id == teacherId);

            teach.IdentityNumber = txtIdentity.Text;
            teach.NameSurname = txtNameSurname.Text;
            teach.PhoneNumber = txtPhoneNumber.Text;
            teach.MailAddress = txtPhoneNumber.Text;
            teach.Birthdate = Convert.ToDateTime(dtPicBirthdate.Value.ToShortDateString());
            teach.HireDate = Convert.ToDateTime(dtPickerHireDate.Value.ToShortDateString());
            teach.ClassTypeId = (int)cmbClass.SelectedValue;
            teach.LessonId = (int)cmbLesson.SelectedValue;
            teach.TaskInSchoolId = (int)cmbTask.SelectedValue;
            teach.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var teacherId = (int)dtGridTeacher.CurrentRow.Cells["Id"].Value;
            teach = _db.Teachers.FirstOrDefault(i => i.Id == teacherId);

            _db.Teachers.Remove(teach);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTeacher.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.PhoneNumber,
                i.MailAddress,
                i.IdentityNumber,
                i.Birthdate,
                i.HireDate,
                TaskInSchool = i.TaskInSchool.KindOfTask,
                ClassType = i.ClassType.Name,
                Lesson = i.Lesson.Name,
                i.CreatedDate,
                i.UpdatedDate,
                i.TaskInSchoolId,
                i.ClassTypeId,
                i.LessonId
            }).Where(i => i.NameSurname.Contains(txtSearch.Text)).ToList();
        }

        private void radioCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCreate.Checked)
            {
                FormLoad();
            }
        }

        private void radioUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdate.Checked)
            {
                UpdatedDate();
            }
        }

        private void radioLesson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLesson.Checked)
            {
                dtGridTeacher.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    i.NameSurname,
                    i.PhoneNumber,
                    i.MailAddress,
                    i.IdentityNumber,
                    i.Birthdate,
                    i.HireDate,
                    TaskInSchool = i.TaskInSchool.KindOfTask,
                    ClassType = i.ClassType.Name,
                    Lesson = i.Lesson.Name,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.TaskInSchoolId,
                    i.ClassTypeId,
                    i.LessonId
                }).OrderBy(i => i.TaskInSchool).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherAdd add = new TeacherAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            TeacherList list = new TeacherList();
            this.Hide();
            list.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridTeacher.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridTeacher.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridTeacher.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(bf)));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "dosyaadı";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {

                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}
