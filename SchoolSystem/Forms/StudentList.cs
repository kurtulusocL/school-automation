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
    public partial class StudentList : Form
    {
        ApplicationDbContext _db;

        public StudentList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
            {
                i.Id,
                AdıSoyadı = i.NameSurname,
                ÖğrenciNumarası = i.StudentNumber,
                Öğretmen = i.Teacher.NameSurname,
                Dersi = i.Lesson.Name,
                Sınıfı = i.ClassType.Name,
                KimlikNumarası = i.IdentityNumber,
                KayıtTarihi = i.RegisterDate,
                TelefonNumarası = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                DoğumTarihi = i.Birthdate,
                NotSayısı = i.StudentNotes.Count(),
                DevamsızlıkSayısı = i.StudentAbsents.Count(),
                EklenmeTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderBy(i => i.EklenmeTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
            {
                i.Id,
                AdıSoyadı = i.NameSurname,
                ÖğrenciNumarası = i.StudentNumber,
                Öğretmen = i.Teacher.NameSurname,
                Dersi = i.Lesson.Name,
                Sınıfı = i.ClassType.Name,
                KimlikNumarası = i.IdentityNumber,
                KayıtTarihi = i.RegisterDate,
                TelefonNumarası = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                DoğumTarihi = i.Birthdate,
                NotSayısı = i.StudentNotes.Count(),
                DevamsızlıkSayısı = i.StudentAbsents.Count(),
                EklenmeTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderBy(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
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

        private void radioRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRegister.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.KayıtTarihi).ToList();
            }
        }

        private void radioBirthdate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBirthdate.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.DoğumTarihi).ToList();
            }
        }

        private void radioLesson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLesson.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Dersi).ToList();
            }
        }

        private void radioTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTeacher.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Öğretmen).ToList();
            }
        }

        private void radioClass_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClass.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Sınıfı).ToList();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.DevamsızlıkSayısı).ToList();
            }
        }

        private void radioNoteCount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNoteCount.Checked)
            {
                dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
                {
                    i.Id,
                    AdıSoyadı = i.NameSurname,
                    ÖğrenciNumarası = i.StudentNumber,
                    Öğretmen = i.Teacher.NameSurname,
                    Dersi = i.Lesson.Name,
                    Sınıfı = i.ClassType.Name,
                    KimlikNumarası = i.IdentityNumber,
                    KayıtTarihi = i.RegisterDate,
                    TelefonNumarası = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    DoğumTarihi = i.Birthdate,
                    NotSayısı = i.StudentNotes.Count(),
                    DevamsızlıkSayısı = i.StudentAbsents.Count(),
                    EklenmeTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.NotSayısı).ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGirdStudentList.DataSource = _db.Students.Include("Lesson").Include("ClassType").Include("Teacher").Include("StudentAbsents").Include("StudentNotes").Select(i => new
            {
                i.Id,
                AdıSoyadı = i.NameSurname,
                ÖğrenciNumarası = i.StudentNumber,
                Öğretmen = i.Teacher.NameSurname,
                Dersi = i.Lesson.Name,
                Sınıfı = i.ClassType.Name,
                KimlikNumarası = i.IdentityNumber,
                KayıtTarihi = i.RegisterDate,
                TelefonNumarası = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                DoğumTarihi = i.Birthdate,
                NotSayısı = i.StudentNotes.Count(),
                DevamsızlıkSayısı = i.StudentAbsents.Count(),
                EklenmeTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i=>i.AdıSoyadı.Contains(txtSearch.Text)).ToList();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Öğrenci Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentEdit edit = new StudentEdit();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGirdStudentList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGirdStudentList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGirdStudentList.Rows)
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

        private void btnNote_Click(object sender, EventArgs e)
        {
            StudentNoteList note = new StudentNoteList();
            this.Hide();
            note.Show();
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            AbsentList list = new AbsentList();
            this.Hide();
            list.Show();
        }
    }
}
