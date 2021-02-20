namespace SchoolSystem.Forms
{
    partial class AbsentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsentList));
            this.dtGridAbsentList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioReport = new System.Windows.Forms.RadioButton();
            this.radioLesson = new System.Windows.Forms.RadioButton();
            this.radioAbsentDate = new System.Windows.Forms.RadioButton();
            this.radioNameSurname = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAbsentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridAbsentList
            // 
            this.dtGridAbsentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAbsentList.Location = new System.Drawing.Point(-1, -1);
            this.dtGridAbsentList.Name = "dtGridAbsentList";
            this.dtGridAbsentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridAbsentList.Size = new System.Drawing.Size(610, 452);
            this.dtGridAbsentList.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 401);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioReport);
            this.groupBox1.Controls.Add(this.radioLesson);
            this.groupBox1.Controls.Add(this.radioAbsentDate);
            this.groupBox1.Controls.Add(this.radioNameSurname);
            this.groupBox1.Controls.Add(this.radioUpdate);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(647, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama Yap";
            // 
            // radioReport
            // 
            this.radioReport.AutoSize = true;
            this.radioReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioReport.Location = new System.Drawing.Point(6, 156);
            this.radioReport.Name = "radioReport";
            this.radioReport.Size = new System.Drawing.Size(150, 19);
            this.radioReport.TabIndex = 4;
            this.radioReport.TabStop = true;
            this.radioReport.Text = "Rapor Durumuna Göre";
            this.radioReport.UseVisualStyleBackColor = true;
            this.radioReport.CheckedChanged += new System.EventHandler(this.radioReport_CheckedChanged);
            // 
            // radioLesson
            // 
            this.radioLesson.AutoSize = true;
            this.radioLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioLesson.Location = new System.Drawing.Point(6, 131);
            this.radioLesson.Name = "radioLesson";
            this.radioLesson.Size = new System.Drawing.Size(87, 19);
            this.radioLesson.TabIndex = 4;
            this.radioLesson.TabStop = true;
            this.radioLesson.Text = "Derse Göre";
            this.radioLesson.UseVisualStyleBackColor = true;
            this.radioLesson.CheckedChanged += new System.EventHandler(this.radioLesson_CheckedChanged);
            // 
            // radioAbsentDate
            // 
            this.radioAbsentDate.AutoSize = true;
            this.radioAbsentDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioAbsentDate.Location = new System.Drawing.Point(6, 106);
            this.radioAbsentDate.Name = "radioAbsentDate";
            this.radioAbsentDate.Size = new System.Drawing.Size(168, 19);
            this.radioAbsentDate.TabIndex = 3;
            this.radioAbsentDate.TabStop = true;
            this.radioAbsentDate.Text = "Devamsızlık Tarihine Göre";
            this.radioAbsentDate.UseVisualStyleBackColor = true;
            this.radioAbsentDate.CheckedChanged += new System.EventHandler(this.radioAbsentDate_CheckedChanged);
            // 
            // radioNameSurname
            // 
            this.radioNameSurname.AutoSize = true;
            this.radioNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioNameSurname.Location = new System.Drawing.Point(6, 81);
            this.radioNameSurname.Name = "radioNameSurname";
            this.radioNameSurname.Size = new System.Drawing.Size(126, 19);
            this.radioNameSurname.TabIndex = 2;
            this.radioNameSurname.TabStop = true;
            this.radioNameSurname.Text = "Adı-Soyadına Göre";
            this.radioNameSurname.UseVisualStyleBackColor = true;
            this.radioNameSurname.CheckedChanged += new System.EventHandler(this.radioNameSurname_CheckedChanged);
            // 
            // radioUpdate
            // 
            this.radioUpdate.AutoSize = true;
            this.radioUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioUpdate.Location = new System.Drawing.Point(6, 56);
            this.radioUpdate.Name = "radioUpdate";
            this.radioUpdate.Size = new System.Drawing.Size(176, 19);
            this.radioUpdate.TabIndex = 1;
            this.radioUpdate.TabStop = true;
            this.radioUpdate.Text = "Güncellenme Tarihine Göre";
            this.radioUpdate.UseVisualStyleBackColor = true;
            this.radioUpdate.CheckedChanged += new System.EventHandler(this.radioUpdate_CheckedChanged);
            // 
            // radioCreate
            // 
            this.radioCreate.AutoSize = true;
            this.radioCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioCreate.Location = new System.Drawing.Point(6, 31);
            this.radioCreate.Name = "radioCreate";
            this.radioCreate.Size = new System.Drawing.Size(128, 19);
            this.radioCreate.TabIndex = 0;
            this.radioCreate.TabStop = true;
            this.radioCreate.Text = "Kayıt Tarihine Göre";
            this.radioCreate.UseVisualStyleBackColor = true;
            this.radioCreate.CheckedChanged += new System.EventHandler(this.radioCreate_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(697, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(624, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Arama Yap";
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(785, 266);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 65);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(704, 337);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 65);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(704, 266);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 65);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(625, 266);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 65);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AbsentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(871, 451);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtGridAbsentList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbsentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Devamsızlık Listesi";
            this.Load += new System.EventHandler(this.AbsentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAbsentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridAbsentList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioAbsentDate;
        private System.Windows.Forms.RadioButton radioNameSurname;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton radioLesson;
        private System.Windows.Forms.RadioButton radioReport;
    }
}