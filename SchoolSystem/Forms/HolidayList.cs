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
    public partial class HolidayList : Form
    {
        ApplicationDbContext _db;
        Holiday hlday = new Holiday();

        public HolidayList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                Başlığı= i.Title,
                Öğretmen = i.Teacher.NameSurname,
                Çalışan = i.Worker.NameSurname,
                İzneAyrılışTarihi = i.HolidayDate,
                İzinDönüşTarihi = i.ComebackDate,
                İzinliGünSayısı = i.Day,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderBy(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                Başlığı = i.Title,
                Öğretmen = i.Teacher.NameSurname,
                Çalışan = i.Worker.NameSurname,
                İzneAyrılışTarihi = i.HolidayDate,
                İzinDönüşTarihi = i.ComebackDate,
                İzinliGünSayısı = i.Day,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderBy(i => i.GüncellenmeTarihi.Value.ToString()).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                Başlığı = i.Title,
                Öğretmen = i.Teacher.NameSurname,
                Çalışan = i.Worker.NameSurname,
                İzneAyrılışTarihi = i.HolidayDate,
                İzinDönüşTarihi = i.ComebackDate,
                İzinliGünSayısı = i.Day,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).Where(i => i.Öğretmen.Contains(txtSearch.Text)).ToList();
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

        private void radioStartHoliday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStartHoliday.Checked)
            {
                dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    Başlığı = i.Title,
                    Öğretmen = i.Teacher.NameSurname,
                    Çalışan = i.Worker.NameSurname,
                    İzneAyrılışTarihi = i.HolidayDate,
                    İzinDönüşTarihi = i.ComebackDate,
                    İzinliGünSayısı = i.Day,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.İzneAyrılışTarihi).ToList();
            }
        }

        private void radioComeHoliday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioComeHoliday.Checked)
            {
                dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    Başlığı = i.Title,
                    Öğretmen = i.Teacher.NameSurname,
                    Çalışan = i.Worker.NameSurname,
                    İzneAyrılışTarihi = i.HolidayDate,
                    İzinDönüşTarihi = i.ComebackDate,
                    İzinliGünSayısı = i.Day,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.İzinDönüşTarihi).ToList();
            }
        }

        private void radioWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWorker.Checked)
            {
                dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    Başlığı = i.Title,
                    Öğretmen = i.Teacher.NameSurname,
                    Çalışan = i.Worker.NameSurname,
                    İzneAyrılışTarihi = i.HolidayDate,
                    İzinDönüşTarihi = i.ComebackDate,
                    İzinliGünSayısı = i.Day,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.Çalışan).ToList();
            }
        }

        private void radioTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTeacher.Checked)
            {
                dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    Başlığı = i.Title,
                    Öğretmen = i.Teacher.NameSurname,
                    Çalışan = i.Worker.NameSurname,
                    İzneAyrılışTarihi = i.HolidayDate,
                    İzinDönüşTarihi = i.ComebackDate,
                    İzinliGünSayısı = i.Day,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.Öğretmen).ToList();
            }
        }

        private void radioDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDay.Checked)
            {
                dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    Başlığı = i.Title,
                    Öğretmen = i.Teacher.NameSurname,
                    Çalışan = i.Worker.NameSurname,
                    İzneAyrılışTarihi = i.HolidayDate,
                    İzinDönüşTarihi = i.ComebackDate,
                    İzinliGünSayısı = i.Day,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate,
                }).OrderBy(i => i.İzinliGünSayısı).ToList();
            }
        }

        private void HolidayList_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HolidayEdit edit = new HolidayEdit();
            this.Hide();
            edit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridHolidayList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridHolidayList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridHolidayList.Rows)
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

        private void txtWorker_TextChanged(object sender, EventArgs e)
        {
            dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                Başlığı = i.Title,
                Öğretmen = i.Teacher.NameSurname,
                Çalışan = i.Worker.NameSurname,
                İzneAyrılışTarihi = i.HolidayDate,
                İzinDönüşTarihi = i.ComebackDate,
                İzinliGünSayısı = i.Day,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).Where(i => i.Çalışan.Contains(txtSearch.Text)).ToList();
        }

        private void radioTitle_CheckedChanged(object sender, EventArgs e)
        {
            dtGridHolidayList.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                Başlığı = i.Title,
                Öğretmen = i.Teacher.NameSurname,
                Çalışan = i.Worker.NameSurname,
                İzneAyrılışTarihi = i.HolidayDate,
                İzinDönüşTarihi = i.ComebackDate,
                İzinliGünSayısı = i.Day,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate,
            }).OrderBy(i=>i.Başlığı).ToList();
        }
    }
}
