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
    public partial class HolidayEdit : Form
    {
        ApplicationDbContext _db;
        Holiday hlday = new Holiday();

        public HolidayEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            cmbTeacher.SelectedValue = "";
            cmbWorker.SelectedValue = "";
            numDay.ResetText();
            dtPickerFinish.ResetText();
            dtPickerStart.ResetText();
            txtTitle.Clear();
            txtSearch.Clear();
            txtWorker.Clear();
        }

        void FormLoad()
        {
            dtGridHoliday.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                i.Title,
                Teacher = i.Teacher.NameSurname,
                Worker = i.Worker.NameSurname,
                i.HolidayDate,
                i.ComebackDate,
                i.Day,
                i.CreatedDate,
                i.UpdatedDate,
                i.TeacherId,
                i.WorkerId
            }).OrderBy(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridHoliday.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                i.Title,
                Teacher = i.Teacher.NameSurname,
                Worker = i.Worker.NameSurname,
                i.HolidayDate,
                i.ComebackDate,
                i.Day,
                i.CreatedDate,
                i.UpdatedDate,
                i.TeacherId,
                i.WorkerId
            }).OrderBy(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridHoliday.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                i.Title,
                Teacher = i.Teacher.NameSurname,
                Worker = i.Worker.NameSurname,
                i.HolidayDate,
                i.ComebackDate,
                i.Day,
                i.CreatedDate,
                i.UpdatedDate,
                i.TeacherId,
                i.WorkerId
            }).Where(i => i.Teacher.Contains(txtSearch.Text)).ToList();
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
                dtGridHoliday.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    i.Title,
                    Teacher = i.Teacher.NameSurname,
                    Worker = i.Worker.NameSurname,
                    i.HolidayDate,
                    i.ComebackDate,
                    i.Day,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.TeacherId,
                    i.WorkerId
                }).OrderBy(i => i.HolidayDate).ToList();
            }
        }

        private void radioComeHoliday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioComeHoliday.Checked)
            {
                dtGridHoliday.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
                {
                    i.Id,
                    i.Title,
                    Teacher = i.Teacher.NameSurname,
                    Worker = i.Worker.NameSurname,
                    i.HolidayDate,
                    i.ComebackDate,
                    i.Day,
                    i.CreatedDate,
                    i.UpdatedDate,
                    i.TeacherId,
                    i.WorkerId
                }).OrderBy(i => i.ComebackDate).ToList();
            }
        }

        private void dtGridHoliday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridHoliday.CurrentRow;

            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtTitle.Tag = row.Cells["Id"].Value;
            cmbWorker.SelectedValue = Convert.ToInt32(row.Cells["WorkerId"].Value).ToString();
            cmbTeacher.SelectedValue = Convert.ToInt32(row.Cells["TeacherId"].Value.ToString());
            dtPickerFinish.Value = Convert.ToDateTime(row.Cells["ComebackDate"].Value.ToString());
            dtPickerStart.Value = Convert.ToDateTime(row.Cells["HolidayDate"].Value.ToString());
            numDay.Value = Convert.ToInt32(row.Cells["Day"].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var holidayId = (int)txtTitle.Tag;
            hlday = _db.Holidays.FirstOrDefault(i => i.Id == holidayId);

            hlday.Title = txtTitle.Text;
            hlday.TeacherId = (int?)cmbTeacher.SelectedValue;
            hlday.WorkerId = (int?)cmbWorker.SelectedValue;
            hlday.ComebackDate = Convert.ToDateTime(dtPickerFinish.Value.ToShortDateString());
            hlday.HolidayDate = Convert.ToDateTime(dtPickerStart.Value.ToShortDateString());
            hlday.Day = Convert.ToInt32(numDay.Value);
            hlday.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var holidayId = (int)dtGridHoliday.CurrentRow.Cells["Id"].Value;
            hlday = _db.Holidays.FirstOrDefault(i => i.Id == holidayId);

            _db.Holidays.Remove(hlday);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void HolidayEdit_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Personel Adı-Soyadı ile arama yapabilirsiniz");
            FormLoad();

            var teacherList = _db.Teachers.Include("TaskInSchool").Include("ClassType").Include("Lesson").Include("Students").Include("Holidays").OrderBy(i => i.Students.Count()).ToList();
            cmbTeacher.DataSource = teacherList;
            cmbTeacher.ValueMember = "Id";
            cmbTeacher.DisplayMember = "NameSurname";

            var workerList = _db.Workers.Include("TaskInSchool").Include("Holidays").OrderBy(i => i.Holidays.Count()).ToList();
            cmbWorker.DataSource = workerList;
            cmbWorker.ValueMember = "Id";
            cmbWorker.DisplayMember = "NameSurname";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HolidayAdd add = new HolidayAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            HolidayList list = new HolidayList();
            this.Hide();
            list.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridHoliday.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridHoliday.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridHoliday.Rows)
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
            dtGridHoliday.DataSource = _db.Holidays.Include("Worker").Include("Teacher").Select(i => new
            {
                i.Id,
                i.Title,
                Teacher = i.Teacher.NameSurname,
                Worker = i.Worker.NameSurname,
                i.HolidayDate,
                i.ComebackDate,
                i.Day,
                i.CreatedDate,
                i.UpdatedDate,
                i.TeacherId,
                i.WorkerId
            }).Where(i => i.Worker.Contains(txtSearch.Text)).ToList();
        }
    }
}
