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
    public partial class LessonEdit : Form
    {
        ApplicationDbContext _db;
        Lesson less = new Lesson();

        public LessonEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtLessonName.Clear();
            txtSearch.Clear();
        }

        void FormLoad()
        {
            dtGridLesson.DataSource = _db.Lessons.Include("Students").Include("Teachers").Select(i => new
            {
                i.Id,
                i.Name,
                Teachers = i.Teachers.Count(),
                Students = i.Students.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridLesson.DataSource = _db.Lessons.Include("Students").Include("Teachers").Select(i => new
            {
                i.Id,
                i.Name,
                Teachers = i.Teachers.Count(),
                Students = i.Students.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void dtGridLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridLesson.CurrentRow;
            txtLessonName.Text = row.Cells["Value"].Value.ToString();
            txtLessonName.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var lessonId = (int)txtLessonName.Tag;
            less = _db.Lessons.FirstOrDefault(i => i.Id == lessonId);

            less.Name = txtLessonName.Text;
            less.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var lessonId = (int)dtGridLesson.CurrentRow.Cells["Id"].Value;
            less = _db.Lessons.FirstOrDefault(i => i.Id == lessonId);

            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridLesson.DataSource = _db.Lessons.Include("Students").Include("Teachers").Select(i => new
            {
                i.Id,
                i.Name,
                Teachers = i.Teachers.Count(),
                Students = i.Students.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i => i.Name.Contains(txtSearch.Text)).ToList();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LessonAdd add = new LessonAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LessonList list = new LessonList();
            this.Hide();
            list.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridLesson.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridLesson.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridLesson.Rows)
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

        private void LessonEdit_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
    }
}
