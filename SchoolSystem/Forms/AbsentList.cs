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
    public partial class AbsentList : Form
    {
        ApplicationDbContext _db;

        public AbsentList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
            {
                i.Id,
                Öğrenci = i.Student.NameSurname,
                Ders = i.Lesson.Name,
                Gün = i.AbsentDate,
                RaporuVarMı = i.IsReport,
                KayıtTarihi = i.CreatedDate,
                GüncellemeTarihi = i.UpdatedDate
            }).OrderBy(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
            {
                i.Id,
                Öğrenci = i.Student.NameSurname,
                Ders = i.Lesson.Name,
                Gün = i.AbsentDate,
                RaporuVarMı = i.IsReport,
                KayıtTarihi = i.CreatedDate,
                GüncellemeTarihi = i.UpdatedDate
            }).OrderBy(i => i.GüncellemeTarihi.Value.ToString()).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
            {
                i.Id,
                Öğrenci = i.Student.NameSurname,
                Ders = i.Lesson.Name,
                Gün = i.AbsentDate,
                RaporuVarMı = i.IsReport,
                KayıtTarihi = i.CreatedDate,
                GüncellemeTarihi = i.UpdatedDate
            }).Where(i => i.Öğrenci.Contains(txtSearch.Text)).ToList();
        }

        private void AbsentList_Load(object sender, EventArgs e)
        {
            FormLoad();
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
                dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
                {
                    i.Id,
                    Öğrenci = i.Student.NameSurname,
                    Ders = i.Lesson.Name,
                    Gün = i.AbsentDate,
                    RaporuVarMı = i.IsReport,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Öğrenci).ToList();
            }
        }

        private void radioAbsentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAbsentDate.Checked)
            {
                dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
                {
                    i.Id,
                    Öğrenci = i.Student.NameSurname,
                    Ders = i.Lesson.Name,
                    Gün = i.AbsentDate,
                    RaporuVarMı = i.IsReport,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Gün).ToList();
            }
        }

        private void radioLesson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLesson.Checked)
            {
                dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
                {
                    i.Id,
                    Öğrenci = i.Student.NameSurname,
                    Ders = i.Lesson.Name,
                    Gün = i.AbsentDate,
                    RaporuVarMı = i.IsReport,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Ders).ToList();
            }
        }

        private void radioReport_CheckedChanged(object sender, EventArgs e)
        {
            if (radioReport.Checked)
            {
                dtGridAbsentList.DataSource = _db.StudentAbsents.Include("Student").Include("Lesson").Select(i => new
                {
                    i.Id,
                    Öğrenci = i.Student.NameSurname,
                    Ders = i.Lesson.Name,
                    Gün = i.AbsentDate,
                    RaporuVarMı = i.IsReport,
                    KayıtTarihi = i.CreatedDate,
                    GüncellemeTarihi = i.UpdatedDate
                }).OrderBy(i => i.RaporuVarMı).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AbsentEdit edit = new AbsentEdit();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridAbsentList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridAbsentList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridAbsentList.Rows)
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
