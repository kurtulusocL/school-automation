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
    public partial class AbsentEdit : Form
    {
        ApplicationDbContext _db;
        StudentAbsent absent = new StudentAbsent();

        public AbsentEdit()
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

        void FormLoad()
        {
            dtGridAbsent.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
            {
                i.Id,
                Student = i.Student.NameSurname,
                Lesson = i.Lesson.Name,
                i.AbsentDate,
                i.IsReport,
                i.CreatedDate,
                i.UpdatedDate,
                i.LessonId,
                i.StudentId
            }).OrderBy(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridAbsent.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
            {
                i.Id,
                Student = i.Student.NameSurname,
                Lesson = i.Lesson.Name,
                i.AbsentDate,
                i.IsReport,
                i.CreatedDate,
                i.UpdatedDate,
                i.LessonId,
                i.StudentId
            }).OrderBy(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void AbsentEdit_Load(object sender, EventArgs e)
        {
            FormLoad();

            var studentList = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").OrderBy(i => i.StudentAbsents.Count).ToList();
            cmbNameSurname.DataSource = studentList;
            cmbNameSurname.ValueMember = "Id";
            cmbNameSurname.DisplayMember = "NameSurname";

            var lessonList = _db.Lessons.Include("Students").Include("Teachers").Include("StudentAbsents").OrderBy(i => i.Students.Count()).ToList();
            cmbLesson.DataSource = lessonList;
            cmbLesson.ValueMember = "Id";
            cmbLesson.DisplayMember = "Name";
        }

        private void dtGridAbsent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridAbsent.CurrentRow;

            cmbNameSurname.SelectedValue = Convert.ToInt32(row.Cells["StudentId"].Value.ToString());
            cmbNameSurname.Tag= Convert.ToInt32(row.Cells["Id"].Value.ToString());
            cmbLesson.SelectedValue = Convert.ToUInt32(Convert.ToInt32(row.Cells["LessonId"].Value)).ToString();
            dtPicDate.Value = Convert.ToDateTime(row.Cells["AbsentDate"].Value.ToString());
            if (absent.IsReport == true)            
                checkYes.Checked = Convert.ToBoolean(row.Cells["IsReport"].Value.ToString());            
            else            
                checkNo.Checked = Convert.ToBoolean(row.Cells["IsReport"].Value.ToString());
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var absentId = (int)cmbNameSurname.Tag;
            absent = _db.StudentAbsents.FirstOrDefault(i => i.Id == absentId);

            absent.StudentId = (int)cmbNameSurname.SelectedValue;
            absent.LessonId = (int?)cmbLesson.SelectedValue;
            absent.AbsentDate = Convert.ToDateTime(dtPicDate.Value.ToShortDateString());
            if (absent.IsReport == true)
            {
                absent.IsReport = Convert.ToBoolean(checkYes.Checked);
            }
            else
            {
                absent.IsReport = Convert.ToBoolean(checkNo.Checked);
            }
            absent.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var absentId = (int)dtGridAbsent.CurrentRow.Cells["Id"].Value;
            absent = _db.StudentAbsents.FirstOrDefault(i => i.Id == absentId);

            _db.StudentAbsents.Remove(absent);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AbsentAdd add = new AbsentAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AbsentList list = new AbsentList();
            this.Hide();
            list.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentList list = new StudentList();
            this.Hide();
            list.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridAbsent.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridAbsent.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridAbsent.Rows)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridAbsent.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
            {
                i.Id,
                Student = i.Student.NameSurname,
                Lesson = i.Lesson.Name,
                i.AbsentDate,
                i.IsReport,
                i.CreatedDate,
                i.UpdatedDate,
                i.LessonId,
                i.StudentId
            }).Where(i=>i.Student.Contains(txtSearch.Text)).ToList();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}
