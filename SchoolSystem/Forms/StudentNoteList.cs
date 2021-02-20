using iTextSharp.text;
using iTextSharp.text.pdf;
using SchoolSystem.Data;
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
    public partial class StudentNoteList : Form
    {
        ApplicationDbContext _db;

        public StudentNoteList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
            {
                i.Id,
                ÖğrenciAdıSoyadı = i.Student.NameSurname,
                Sınav1 = i.Exam1,
                Sınav2 = i.Exam2,
                VizeSınavı = i.Vize,
                Sınav3 = i.Exam3,
                FinalSınavı = i.Final,
                ÖdevNotu = i.Homework,
                Sonuç = i.Result,
                Durumu = i.Statu,
                Sınıfı = i.Student.ClassType.Name,
                Öğretmen = i.Student.Teacher.NameSurname,
                Dersi = i.Student.Lesson.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellemeTarihi = i.UpdatedDate
            }).OrderBy(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
            {
                i.Id,
                ÖğrenciAdıSoyadı = i.Student.NameSurname,
                Sınav1 = i.Exam1,
                Sınav2 = i.Exam2,
                VizeSınavı = i.Vize,
                Sınav3 = i.Exam3,
                FinalSınavı = i.Final,
                ÖdevNotu = i.Homework,
                Sonuç = i.Result,
                Durumu = i.Statu,
                Sınıfı = i.Student.ClassType.Name,
                Öğretmen = i.Student.Teacher.NameSurname,
                Dersi = i.Student.Lesson.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellemeTarihi = i.UpdatedDate
            }).OrderBy(i => i.GüncellemeTarihi.Value.ToString()).ToList();
        }

        private void StudentNoteList_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Öğrenci Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
            {
                i.Id,
                ÖğrenciAdıSoyadı = i.Student.NameSurname,
                Sınav1 = i.Exam1,
                Sınav2 = i.Exam2,
                VizeSınavı = i.Vize,
                Sınav3 = i.Exam3,
                FinalSınavı = i.Final,
                ÖdevNotu = i.Homework,
                Sonuç = i.Result,
                Durumu = i.Statu,
                Sınıfı = i.Student.ClassType.Name,
                Öğretmen = i.Student.Teacher.NameSurname,
                Dersi = i.Student.Lesson.Name,
                KayıtTarihi = i.CreatedDate,
                GüncellemeTarihi = i.UpdatedDate
            }).Where(i=>i.ÖğrenciAdıSoyadı.Contains(txtSearch.Text)).ToList();
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

        private void radioNameSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNameSurname.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.ÖğrenciAdıSoyadı).ToList();
            }
        }

        private void radioVize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVize.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.VizeSınavı).ToList();
            }
        }

        private void radioFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFinal.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.FinalSınavı).ToList();
            }
        }

        private void radioResult_CheckedChanged(object sender, EventArgs e)
        {
            if (radioResult.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Sonuç).ToList();
            }
        }

        private void radioClass_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClass.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Sınıfı).ToList();
            }
        }

        private void radioLesson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLesson.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Dersi).ToList();
            }
        }

        private void radioTeacherName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTeacherName.Checked)
            {
                dtGridNoteList.DataSource = _db.StudentNotes.Include("Student").Select(i => new
                {
                    i.Id,
                    ÖğrenciAdıSoyadı = i.Student.NameSurname,
                    Sınav1 = i.Exam1,
                    Sınav2 = i.Exam2,
                    VizeSınavı = i.Vize,
                    Sınav3 = i.Exam3,
                    FinalSınavı = i.Final,
                    ÖdevNotu = i.Homework,
                    Sonuç = i.Result,
                    Durumu = i.Statu,
                    Sınıfı = i.Student.ClassType.Name,
                    Öğretmen = i.Student.Teacher.NameSurname,
                    Dersi = i.Student.Lesson.Name,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Öğretmen).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridNoteList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridNoteList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridNoteList.Rows)
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
