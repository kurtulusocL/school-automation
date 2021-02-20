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
    public partial class WorkerList : Form
    {
        ApplicationDbContext _db;

        public WorkerList()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
            {
                i.Id,
                KimlikNumarası = i.IdentityNumber,
                AdıSoyadı = i.NameSurname,
                Görevi = i.TaskInSchool.KindOfTask,
                İzinliGünsayısı=i.Holidays.Count(),
                MailAdresi = i.MailAddress,
                TelefonNo = i.PhoneNumber,
                DoğumTarihi = i.Birthdate,
                BaşlamaTarihi = i.HireDate,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).OrderBy(i => i.KayıtTarihi).ToList();
        }

        void UpdatedDate()
        {
            dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
            {
                i.Id,
                KimlikNumarası = i.IdentityNumber,
                AdıSoyadı = i.NameSurname,
                Görevi = i.TaskInSchool.KindOfTask,
                İzinliGünsayısı = i.Holidays.Count(),
                MailAdresi = i.MailAddress,
                TelefonNo = i.PhoneNumber,
                DoğumTarihi = i.Birthdate,
                BaşlamaTarihi = i.HireDate,
                KayıtTarihi = i.CreatedDate,
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

        private void WorkerList_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Çalışan Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();
        }

        private void radioUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdate.Checked)
            {
                UpdatedDate();
            }
        }

        private void radioTask_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTask.Checked)
            {
                dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
                {
                    i.Id,
                    KimlikNumarası = i.IdentityNumber,
                    AdıSoyadı = i.NameSurname,
                    Görevi = i.TaskInSchool.KindOfTask,
                    İzinliGünsayısı = i.Holidays.Count(),
                    MailAdresi = i.MailAddress,
                    TelefonNo = i.PhoneNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlamaTarihi = i.HireDate,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.Görevi).ToList();
            }
        }

        private void radioHoliday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHoliday.Checked)
            {
                dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
                {
                    i.Id,
                    KimlikNumarası = i.IdentityNumber,
                    AdıSoyadı = i.NameSurname,
                    Görevi = i.TaskInSchool.KindOfTask,
                    İzinliGünsayısı = i.Holidays.Count(),
                    MailAdresi = i.MailAddress,
                    TelefonNo = i.PhoneNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlamaTarihi = i.HireDate,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.İzinliGünsayısı).ToList();
            }
        }

        private void radioWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWorker.Checked)
            {
                dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
                {
                    i.Id,
                    KimlikNumarası = i.IdentityNumber,
                    AdıSoyadı = i.NameSurname,
                    Görevi = i.TaskInSchool.KindOfTask,
                    İzinliGünsayısı = i.Holidays.Count(),
                    MailAdresi = i.MailAddress,
                    TelefonNo = i.PhoneNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlamaTarihi = i.HireDate,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.AdıSoyadı).ToList();
            }
        }

        private void radioHire_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHire.Checked)
            {
                dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
                {
                    i.Id,
                    KimlikNumarası = i.IdentityNumber,
                    AdıSoyadı = i.NameSurname,
                    Görevi = i.TaskInSchool.KindOfTask,
                    İzinliGünsayısı = i.Holidays.Count(),
                    MailAdresi = i.MailAddress,
                    TelefonNo = i.PhoneNumber,
                    DoğumTarihi = i.Birthdate,
                    BaşlamaTarihi = i.HireDate,
                    KayıtTarihi = i.CreatedDate,
                    GüncellenmeTarihi = i.UpdatedDate
                }).OrderBy(i => i.BaşlamaTarihi).ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridWorkerList.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
            {
                i.Id,
                KimlikNumarası = i.IdentityNumber,
                AdıSoyadı = i.NameSurname,
                Görevi = i.TaskInSchool.KindOfTask,
                İzinliGünsayısı = i.Holidays.Count(),
                MailAdresi = i.MailAddress,
                TelefonNo = i.PhoneNumber,
                DoğumTarihi = i.Birthdate,
                BaşlamaTarihi = i.HireDate,
                KayıtTarihi = i.CreatedDate,
                GüncellenmeTarihi = i.UpdatedDate
            }).Where(i=>i.AdıSoyadı.Contains(txtSearch.Text)).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            WorkerEdit edit = new WorkerEdit();
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

                PdfPTable pdfTablosu = new PdfPTable(dtGridWorkerList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridWorkerList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridWorkerList.Rows)
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
