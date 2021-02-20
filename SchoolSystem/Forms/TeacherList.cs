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
    public partial class TeacherList : Form
    {
        ApplicationDbContext _db;

        public TeacherList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
            {
                i.Id,
                AdıSoyad = i.NameSurname,
                TelefonNo = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                KimlikNo = i.IdentityNumber,
                DoğumTarihi = i.Birthdate,
                BaşlangıçTarihi = i.HireDate,
                Görevi = i.TaskInSchool.KindOfTask,
                Sınıfı = i.ClassType.Name,
                Dersi = i.Lesson.Name,
                ÖğrenciSayısı = i.Students.Count(),
                İzinliGünSayısı = i.Holidays.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderBy(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
            {
                i.Id,
                AdıSoyad = i.NameSurname,
                TelefonNo = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                KimlikNo = i.IdentityNumber,
                DoğumTarihi = i.Birthdate,
                BaşlangıçTarihi = i.HireDate,
                Görevi = i.TaskInSchool.KindOfTask,
                Sınıfı = i.ClassType.Name,
                Dersi = i.Lesson.Name,
                ÖğrenciSayısı = i.Students.Count(),
                İzinliGünSayısı = i.Holidays.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderBy(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
            {
                i.Id,
                AdıSoyad = i.NameSurname,
                TelefonNo = i.PhoneNumber,
                MailAdresi = i.MailAddress,
                KimlikNo = i.IdentityNumber,
                DoğumTarihi = i.Birthdate,
                BaşlangıçTarihi = i.HireDate,
                Görevi = i.TaskInSchool.KindOfTask,
                Sınıfı = i.ClassType.Name,
                Dersi = i.Lesson.Name,
                ÖğrenciSayısı = i.Students.Count(),
                İzinliGünSayısı = i.Holidays.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i => i.AdıSoyad.Contains(txtSearch.Text)).ToList();
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

        private void radioHire_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHire.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.BaşlangıçTarihi).ToList();
            }
        }

        private void radioNameSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNameSurname.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.AdıSoyad).ToList();
            }
        }

        private void radioClass_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClass.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Sınıfı).ToList();
            }
        }

        private void radioLesson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLesson.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Dersi).ToList();
            }
        }

        private void radioTask_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTask.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Görevi).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TeacherEdit edit = new TeacherEdit();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridTeacherList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridTeacherList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridTeacherList.Rows)
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

        private void TeacherList_Load(object sender, EventArgs e)
        {
            FormLoad();
            toolTip1.SetToolTip(txtSearch, "Öğretmen Adı-Soyadı ile arama yapabilirsiniz");
        }

        private void radioHolidayDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHolidayDay.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.İzinliGünSayısı).ToList();
            }
        }

        private void radioStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStudent.Checked)
            {
                dtGridTeacherList.DataSource = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").Select(i => new
                {
                    i.Id,
                    AdıSoyad = i.NameSurname,
                    TelefonNo = i.PhoneNumber,
                    MailAdresi = i.MailAddress,
                    KimlikNo = i.IdentityNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlangıçTarihi = i.HireDate,
                    Görevi = i.TaskInSchool.KindOfTask,
                    Sınıfı = i.ClassType.Name,
                    Dersi = i.Lesson.Name,
                    ÖğrenciSayısı = i.Students.Count(),
                    İzinliGünSayısı = i.Holidays.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.ÖğrenciSayısı).ToList();
            }
        }
    }
}
