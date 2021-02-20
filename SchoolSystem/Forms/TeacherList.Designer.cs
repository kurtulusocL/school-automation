namespace SchoolSystem.Forms
{
    partial class TeacherList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherList));
            this.dtGridTeacherList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioHolidayDay = new System.Windows.Forms.RadioButton();
            this.radioLesson = new System.Windows.Forms.RadioButton();
            this.radioClass = new System.Windows.Forms.RadioButton();
            this.radioTask = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioNameSurname = new System.Windows.Forms.RadioButton();
            this.radioHire = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTeacherList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridTeacherList
            // 
            this.dtGridTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTeacherList.Location = new System.Drawing.Point(3, 1);
            this.dtGridTeacherList.Name = "dtGridTeacherList";
            this.dtGridTeacherList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridTeacherList.Size = new System.Drawing.Size(867, 307);
            this.dtGridTeacherList.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(81, 328);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(8, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Arama Yap";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioHolidayDay);
            this.groupBox1.Controls.Add(this.radioLesson);
            this.groupBox1.Controls.Add(this.radioClass);
            this.groupBox1.Controls.Add(this.radioTask);
            this.groupBox1.Controls.Add(this.radioUpdate);
            this.groupBox1.Controls.Add(this.radioStudent);
            this.groupBox1.Controls.Add(this.radioNameSurname);
            this.groupBox1.Controls.Add(this.radioHire);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama Yap";
            // 
            // radioHolidayDay
            // 
            this.radioHolidayDay.AutoSize = true;
            this.radioHolidayDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioHolidayDay.Location = new System.Drawing.Point(6, 106);
            this.radioHolidayDay.Name = "radioHolidayDay";
            this.radioHolidayDay.Size = new System.Drawing.Size(154, 19);
            this.radioHolidayDay.TabIndex = 7;
            this.radioHolidayDay.TabStop = true;
            this.radioHolidayDay.Text = "İzinli Gün Sayısına Göre";
            this.radioHolidayDay.UseVisualStyleBackColor = true;
            this.radioHolidayDay.CheckedChanged += new System.EventHandler(this.radioHolidayDay_CheckedChanged);
            // 
            // radioLesson
            // 
            this.radioLesson.AutoSize = true;
            this.radioLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioLesson.Location = new System.Drawing.Point(246, 81);
            this.radioLesson.Name = "radioLesson";
            this.radioLesson.Size = new System.Drawing.Size(97, 19);
            this.radioLesson.TabIndex = 5;
            this.radioLesson.TabStop = true;
            this.radioLesson.Text = "Dersine Göre";
            this.radioLesson.UseVisualStyleBackColor = true;
            this.radioLesson.CheckedChanged += new System.EventHandler(this.radioLesson_CheckedChanged);
            // 
            // radioClass
            // 
            this.radioClass.AutoSize = true;
            this.radioClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioClass.Location = new System.Drawing.Point(246, 56);
            this.radioClass.Name = "radioClass";
            this.radioClass.Size = new System.Drawing.Size(95, 19);
            this.radioClass.TabIndex = 4;
            this.radioClass.TabStop = true;
            this.radioClass.Text = "Sınıfına Göre";
            this.radioClass.UseVisualStyleBackColor = true;
            this.radioClass.CheckedChanged += new System.EventHandler(this.radioClass_CheckedChanged);
            // 
            // radioTask
            // 
            this.radioTask.AutoSize = true;
            this.radioTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioTask.Location = new System.Drawing.Point(246, 106);
            this.radioTask.Name = "radioTask";
            this.radioTask.Size = new System.Drawing.Size(164, 19);
            this.radioTask.TabIndex = 6;
            this.radioTask.TabStop = true;
            this.radioTask.Text = "Görevlendirilmesine Göre";
            this.radioTask.UseVisualStyleBackColor = true;
            this.radioTask.CheckedChanged += new System.EventHandler(this.radioTask_CheckedChanged);
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
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioStudent.Location = new System.Drawing.Point(403, 31);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(146, 19);
            this.radioStudent.TabIndex = 3;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Öğrenci Sayısına Göre";
            this.radioStudent.UseVisualStyleBackColor = true;
            this.radioStudent.CheckedChanged += new System.EventHandler(this.radioStudent_CheckedChanged);
            // 
            // radioNameSurname
            // 
            this.radioNameSurname.AutoSize = true;
            this.radioNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioNameSurname.Location = new System.Drawing.Point(246, 31);
            this.radioNameSurname.Name = "radioNameSurname";
            this.radioNameSurname.Size = new System.Drawing.Size(113, 19);
            this.radioNameSurname.TabIndex = 3;
            this.radioNameSurname.TabStop = true;
            this.radioNameSurname.Text = "Ad-Soyada Göre";
            this.radioNameSurname.UseVisualStyleBackColor = true;
            this.radioNameSurname.CheckedChanged += new System.EventHandler(this.radioNameSurname_CheckedChanged);
            // 
            // radioHire
            // 
            this.radioHire.AutoSize = true;
            this.radioHire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioHire.Location = new System.Drawing.Point(6, 81);
            this.radioHire.Name = "radioHire";
            this.radioHire.Size = new System.Drawing.Size(151, 19);
            this.radioHire.TabIndex = 2;
            this.radioHire.TabStop = true;
            this.radioHire.Text = "Başlama Tarihine Göre";
            this.radioHire.UseVisualStyleBackColor = true;
            this.radioHire.CheckedChanged += new System.EventHandler(this.radioHire_CheckedChanged);
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
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(748, 351);
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
            this.btnRefresh.Location = new System.Drawing.Point(667, 422);
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
            this.btnHome.Location = new System.Drawing.Point(667, 351);
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
            this.btnEdit.Location = new System.Drawing.Point(588, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 65);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(839, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Uyarı";
            // 
            // TeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(873, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtGridTeacherList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Listesi";
            this.Load += new System.EventHandler(this.TeacherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTeacherList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridTeacherList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioClass;
        private System.Windows.Forms.RadioButton radioTask;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.RadioButton radioNameSurname;
        private System.Windows.Forms.RadioButton radioHire;
        private System.Windows.Forms.RadioButton radioLesson;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.RadioButton radioHolidayDay;
    }
}