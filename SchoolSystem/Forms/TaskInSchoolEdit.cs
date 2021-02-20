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
    public partial class TaskInSchoolEdit : Form
    {
        ApplicationDbContext _db;
        TaskInSchool task = new TaskInSchool();

        public TaskInSchoolEdit()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void Clear()
        {
            txtSearch.Clear();
            txtTask.Clear();
        }

        void FormLoad()
        {
            dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
            {
                i.Id,
                i.KindOfTask,
                Teachers = i.Teachers.Count(),
                Workers = i.Workers.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdatedDate()
        {
            dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
            {
                i.Id,
                i.KindOfTask,
                Teachers = i.Teachers.Count(),
                Workers = i.Workers.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void TaskInSchoolEdit_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void dtGridTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridTask.CurrentRow;
            txtTask.Text = row.Cells["KindOfTask"].Value.ToString();
            txtTask.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var taskId = (int)dtGridTask.Tag;
            task = _db.TaskInSchools.FirstOrDefault(i => i.Id == taskId);

            task.KindOfTask = txtTask.Text;
            task.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            _db.SaveChanges();
            Clear();
            UpdatedDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var taskId = (int)dtGridTask.CurrentRow.Cells["Id"].Value;
            task = _db.TaskInSchools.FirstOrDefault(i => i.Id == taskId);

            _db.TaskInSchools.Remove(task);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridTask.DataSource = _db.TaskInSchools.Include("Workers").Include("Teachers").Select(i => new
            {
                i.Id,
                i.KindOfTask,
                Teachers = i.Teachers.Count(),
                Workers = i.Workers.Count(),
                i.CreatedDate,
                i.UpdatedDate
            }).Where(i=>i.KindOfTask.Contains(txtSearch.Text)).ToList();
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
            TaskInSchoolAdd add = new TaskInSchoolAdd();
            this.Hide();
            add.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            TaskInSchoolList list = new TaskInSchoolList();
            this.Hide();
            list.Show();
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
