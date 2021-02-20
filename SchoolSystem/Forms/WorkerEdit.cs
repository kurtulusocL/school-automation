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
    public partial class WorkerEdit : Form
    {
        ApplicationDbContext _db;
        Worker wrk = new Worker();

        public WorkerEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtIdentity.Clear();
            txtMail.Clear();
            txtNameSurname.Clear();
            txtPhone.Clear();
            dtPickerBirthdate.ResetText();
            dtPickerHireDate.ResetText();
            cmbTask.SelectedValue = "";
        }

        void FormLoad()
        {
            dtGridWorker.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
            {
                i.Id,
                i.IdentityNumber,
                i.NameSurname,
                TaskInSchool = i.TaskInSchool.KindOfTask,
                i.MailAddress,
                i.PhoneNumber,
                i.Birthdate,
                i.HireDate,
                i.CreatedDate,
                i.UpdatedDate,
                i.TaskInSchoolId
            }).OrderBy(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridWorker.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
            {
                i.Id,
                i.IdentityNumber,
                i.NameSurname,
                TaskInSchool = i.TaskInSchool.KindOfTask,
                i.MailAddress,
                i.PhoneNumber,
                i.Birthdate,
                i.HireDate,
                i.CreatedDate,
                i.UpdatedDate,
                i.TaskInSchoolId
            }).OrderBy(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Çalışan Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WorkerAdd add = new WorkerAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            WorkerList list = new WorkerList();
            this.Hide();
            list.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridWorker.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridWorker.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridWorker.Rows)
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
            dtGridWorker.DataSource = _db.Workers.Include("TaskInSchool").Include("Holidays").Select(i => new
            {
                i.Id,
                i.IdentityNumber,
                i.NameSurname,
                TaskInSchool = i.TaskInSchool.KindOfTask,
                i.MailAddress,
                i.PhoneNumber,
                i.Birthdate,
                i.HireDate,
                i.CreatedDate,
                i.UpdatedDate,
                i.TaskInSchoolId
            }).Where(i=>i.NameSurname.Contains(txtSearch.Text)).ToList();
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

        private void dtGridWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridWorker.CurrentRow;

            txtNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            txtNameSurname.Tag= row.Cells["Id"].Value;
            txtIdentity.Text= row.Cells["IdentityNumber"].Value.ToString();
            txtMail.Text= row.Cells["MailAddress"].Value.ToString(); ;
            txtPhone.Text= row.Cells["PhoneNumber"].Value.ToString();
            dtPickerBirthdate.Value = Convert.ToDateTime(row.Cells["Birthdate"].Value.ToString());
            dtPickerHireDate.Value= Convert.ToDateTime(row.Cells["HireDate"].Value.ToString());
            cmbTask.SelectedValue = Convert.ToInt32(row.Cells["TaskInSchoolId"].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var worderId = (int)txtNameSurname.Tag;
            wrk = _db.Workers.FirstOrDefault(i => i.Id == worderId);

            wrk.NameSurname = txtNameSurname.Text;
            wrk.IdentityNumber = txtIdentity.Text;
            wrk.MailAddress = txtMail.Text;
            wrk.PhoneNumber = txtPhone.Text;
            wrk.Birthdate = Convert.ToDateTime(dtPickerBirthdate.Value.ToShortDateString());
            wrk.HireDate = Convert.ToDateTime(dtPickerHireDate.Value.ToShortDateString());
            wrk.TaskInSchoolId = (int)cmbTask.SelectedValue;
            wrk.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var workerId = (int)dtGridWorker.CurrentRow.Cells["Id"].Value;
            wrk = _db.Workers.FirstOrDefault(i => i.Id == workerId);

            _db.Workers.Remove(wrk);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}
