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
    public partial class StudentNoteEdit : Form
    {
        ApplicationDbContext _db;
        StudentNote note = new StudentNote();

        public StudentNoteEdit()
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
            numExamVize.ResetText();
            numHomework.ResetText();
            lblResult.Text = "";
            txtSearch.Clear();
            lblDurum.Text = "";
        }

        void FormLoad()
        {
            dtGridNote.DataSource = _db.StudentNotes.Include("Student").Select(i => new
            {
                i.Id,
                Student = i.Student.NameSurname,
                i.Exam1,
                i.Exam2,
                i.Vize,
                i.Exam3,
                i.Final,
                i.Homework,
                i.Result,
                i.Statu,
                i.CreatedDate,
                i.UpdatedDate,
                i.StudentId
            }).OrderBy(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridNote.DataSource = _db.StudentNotes.Include("Student").Select(i => new
            {
                i.Id,
                Student = i.Student.NameSurname,
                i.Exam1,
                i.Exam2,
                i.Vize,
                i.Exam3,
                i.Final,
                i.Homework,
                i.Result,
                i.Statu,
                i.CreatedDate,
                i.UpdatedDate,
                i.StudentId
            }).OrderBy(i => i.UpdatedDate).ToList();
        }

        private void StudentNoteEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Öğrenci Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();

            cmbNameSurname.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").OrderBy(i => i.StudentNotes.Count()).ToList();
            cmbNameSurname.ValueMember = "Id";
            cmbNameSurname.DisplayMember = "NameSurname";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridNote.DataSource = _db.StudentNotes.Include("Student").Select(i => new
            {
                i.Id,
                Student = i.Student.NameSurname,
                i.Exam1,
                i.Exam2,
                i.Vize,
                i.Exam3,
                i.Final,
                i.Homework,
                i.Result,
                i.Statu,
                i.CreatedDate,
                i.UpdatedDate,
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

        private void radioResult_CheckedChanged(object sender, EventArgs e)
        {
            if (radioResult.Checked)
            {
                dtGridNote.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    Student = i.Student.NameSurname,
                    i.Exam1,
                    i.Exam2,
                    i.Vize,
                    i.Exam3,
                    i.Final,
                    i.Homework,
                    i.Result,
                    i.Statu,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.StudentId
                }).OrderBy(i => i.Result).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentNoteAdd add = new StudentNoteAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            StudentNoteList list = new StudentNoteList();
            this.Hide();
            list.Show();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridNote.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridNote.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridNote.Rows)
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

        private void lblResult_DoubleClick(object sender, EventArgs e)
        {
            note.Result = ((Convert.ToDouble(numExam1.Value) * 0.2) + (Convert.ToDouble(numExam2.Value) * 0.1) + (Convert.ToDouble(numExamVize.Value) * 0.25) + (Convert.ToDouble(numExam3.Value) * 0.15) + (Convert.ToDouble(numExamFinal.Value) * 0.35) + (Convert.ToDouble(numHomework.Value) * 0.1));
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

        private void dtGridNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridNote.CurrentRow;
            cmbNameSurname.SelectedValue = row.Cells["StudentId"].Value.ToString();
            cmbNameSurname.Tag = row.Cells["Id"].Value;
            numExam1.Value = Convert.ToInt32(row.Cells["Exam1"].Value.ToString());
            numExam2.Value= Convert.ToInt32(row.Cells["Exam2"].Value.ToString());
            numExam3.Value= Convert.ToInt32(row.Cells["Exam3"].Value.ToString());
            numExamVize.Value= Convert.ToInt32(row.Cells["Vize"].Value.ToString());
            numExamFinal.Value= Convert.ToInt32(row.Cells["Final"].Value.ToString());  
            if (note.Result >= 0)
            {
                lblDurum.Text = row.Cells["Statu"].Value.ToString();
                lblDurum.BackColor = Color.Green;
            }
            else
            {
                lblDurum.Text = row.Cells["Statu"].Value.ToString();
                lblDurum.BackColor = Color.Red;
            }
            lblResult.Text = row.Cells["Result"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var noteId = (int)cmbNameSurname.Tag;
            note = _db.StudentNotes.FirstOrDefault(i => i.Id == noteId);

            note.StudentId = (int)cmbNameSurname.SelectedValue;
            note.Exam1 = Convert.ToDouble(numExam1.Value);
            note.Exam2 = Convert.ToDouble(numExam2.Value);
            note.Exam3 = Convert.ToDouble(numExam3.Value);
            note.Vize = Convert.ToDouble(numExamVize.Value);
            note.Final = Convert.ToDouble(numExamFinal.Value);
            note.Homework = Convert.ToDouble(numHomework.Value);
            note.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (note.Result >= 70)
            {
                note.Statu = "Öğrenci sınıfı geçmiştir.";
            }
            else
            {
                note.Statu = "Öğrenci sınıfı geçememiştir.";
            }

            note.Result = ((Convert.ToDouble(numExam1.Value) * 0.2) + (Convert.ToDouble(numExam2.Value) * 0.1) + (Convert.ToDouble(numExamVize.Value) * 0.25) + (Convert.ToDouble(numExam3.Value) * 0.15) + (Convert.ToDouble(numExamFinal.Value) * 0.35) + (Convert.ToDouble(numHomework.Value) * 0.1));

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var noteId = (int)dtGridNote.CurrentRow.Cells["Id"].Value;
            note = _db.StudentNotes.FirstOrDefault(i => i.Id == noteId);

            _db.StudentNotes.Remove(note);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}
