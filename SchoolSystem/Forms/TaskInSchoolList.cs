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
    public partial class TaskInSchoolList : Form
    {
        ApplicationDbContext _db;

        public TaskInSchoolList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
            {
                i.Id,
                GörevlendirmeAdı = i.KindOfTask,
                ÖğretmenSayısı = i.Teachers.Count(),
                ÇalışanSayısı = i.Workers.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
            {
                i.Id,
                GörevlendirmeAdı = i.KindOfTask,
                ÖğretmenSayısı = i.Teachers.Count(),
                ÇalışanSayısı = i.Workers.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderByDescending(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
            {
                i.Id,
                GörevlendirmeAdı = i.KindOfTask,
                ÖğretmenSayısı = i.Teachers.Count(),
                ÇalışanSayısı = i.Workers.Count(),
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i=>i.GörevlendirmeAdı.Contains(txtSearch.Text)).ToList();
        }

        private void TaskInSchoolList_Load(object sender, EventArgs e)
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

        private void radioTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTeacher.Checked)
            {
                dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
                {
                    i.Id,
                    GörevlendirmeAdı = i.KindOfTask,
                    ÖğretmenSayısı = i.Teachers.Count(),
                    ÇalışanSayısı = i.Workers.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderByDescending(i => i.ÖğretmenSayısı).ToList();
            }
        }

        private void radioWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWorker.Checked)
            {
                dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
                {
                    i.Id,
                    GörevlendirmeAdı = i.KindOfTask,
                    ÖğretmenSayısı = i.Teachers.Count(),
                    ÇalışanSayısı = i.Workers.Count(),
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderByDescending(i => i.ÇalışanSayısı).ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TaskInSchoolEdit edit = new TaskInSchoolEdit();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridTask.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridTask.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridTask.Rows)
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
