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
    public partial class StudentEdit : Form
    {
        ApplicationDbContext _db;
        Student std = new Student();

        public StudentEdit()
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
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGirdStudent.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.StudentNumber,
                Teacher = i.Teacher.NameSurname,
                Lesson = i.Lesson.Name,
                Class = i.ClassType.Name,
                i.IdentityNumber,
                i.RegisterDate,
                i.PhoneNumber,
                i.MailAddress,
                i.Birthdate,
                i.CreatedDate,
                i.UpdatedDate,
                i.ClassTypeId,
                i.LessonId,
                i.TeacherId
            }).OrderBy(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGirdStudent.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.StudentNumber,
                Teacher = i.Teacher.NameSurname,
                Lesson = i.Lesson.Name,
                Class = i.ClassType.Name,
                i.IdentityNumber,
                i.RegisterDate,
                i.PhoneNumber,
                i.MailAddress,
                i.Birthdate,
                i.CreatedDate,
                i.UpdatedDate,
                i.ClassTypeId,
                i.LessonId,
                i.TeacherId
            }).OrderBy(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Öğrenci Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGirdStudent.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
            {
                i.Id,
                i.NameSurname,
                i.StudentNumber,
                Teacher = i.Teacher.NameSurname,
                Lesson = i.Lesson.Name,
                Class = i.ClassType.Name,
                i.IdentityNumber,
                i.RegisterDate,
                i.PhoneNumber,
                i.MailAddress,
                i.Birthdate,
                i.CreatedDate,
                i.UpdatedDate,
                i.ClassTypeId,
                i.LessonId,
                i.TeacherId
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

        private void radioStudentRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStudentRegister.Checked)
            {
                dtGirdStudent.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    i.NameSurname,
                    i.StudentNumber,
                    Teacher = i.Teacher.NameSurname,
                    Lesson = i.Lesson.Name,
                    Class = i.ClassType.Name,
                    i.IdentityNumber,
                    i.RegisterDate,
                    i.PhoneNumber,
                    i.MailAddress,
                    i.Birthdate,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.ClassTypeId,
                    i.LessonId,
                    i.TeacherId
                }).OrderBy(i => i.RegisterDate).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd add = new StudentAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            StudentList list = new StudentList();
            this.Hide();
            list.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            StudentNoteList note = new StudentNoteList();
            this.Hide();
            note.Show();
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            AbsentList absent = new AbsentList();
            this.Hide();
            absent.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGirdStudent.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGirdStudent.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGirdStudent.Rows)
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

        private void dtGirdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGirdStudent.CurrentRow;

            txtNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            txtNameSurname.Tag = row.Cells["Id"].Value;
            txtIdentity.Text = row.Cells["IdentityNumber"].Value.ToString();
            txtMail.Text = row.Cells["MailAddress"].Value.ToString();
            txtNumber.Text = row.Cells["StudentNumber"].Value.ToString();
            txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
            dtPicBirthdate.Value = Convert.ToDateTime(row.Cells["Birthdate"].Value.ToString());
            dtPicRegister.Value = Convert.ToDateTime(row.Cells["RegisterDate"].Value.ToString());
            cmbClass.SelectedValue = Convert.ToInt32(row.Cells["ClassTypeId"].Value.ToString());
            cmbLesson.SelectedValue = Convert.ToInt32(row.Cells["LessonId"].Value.ToString());
            cmbTeacher.SelectedValue = Convert.ToInt32(row.Cells["TeacherId"].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var studentId = (int)txtNameSurname.Tag;
            std = _db.Students.FirstOrDefault(i => i.Id == studentId);

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
            std.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var studentId = (int)dtGirdStudent.CurrentRow.Cells["Id"].Value;
            std = _db.Students.FirstOrDefault(i => i.Id == studentId);

            _db.Students.Remove(std);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}
