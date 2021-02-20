namespace SchoolSystem.Forms
{
    partial class StudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentList));
            this.dtGirdStudentList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBirthdate = new System.Windows.Forms.RadioButton();
            this.radioRegister = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioClass = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioNoteCount = new System.Windows.Forms.RadioButton();
            this.radioLesson = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbsent = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGirdStudentList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGirdStudentList
            // 
            this.dtGirdStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGirdStudentList.Location = new System.Drawing.Point(0, 0);
            this.dtGirdStudentList.Name = "dtGirdStudentList";
            this.dtGirdStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGirdStudentList.Size = new System.Drawing.Size(871, 336);
            this.dtGirdStudentList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBirthdate);
            this.groupBox1.Controls.Add(this.radioRegister);
            this.groupBox1.Controls.Add(this.radioUpdate);
            this.groupBox1.Controls.Add(this.radioClass);
            this.groupBox1.Controls.Add(this.radioTeacher);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioNoteCount);
            this.groupBox1.Controls.Add(this.radioLesson);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama Yap";
            // 
            // radioBirthdate
            // 
            this.radioBirthdate.AutoSize = true;
            this.radioBirthdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioBirthdate.Location = new System.Drawing.Point(6, 106);
            this.radioBirthdate.Name = "radioBirthdate";
            this.radioBirthdate.Size = new System.Drawing.Size(143, 19);
            this.radioBirthdate.TabIndex = 3;
            this.radioBirthdate.TabStop = true;
            this.radioBirthdate.Text = "Doğum Tarihine Göre";
            this.radioBirthdate.UseVisualStyleBackColor = true;
            this.radioBirthdate.CheckedChanged += new System.EventHandler(this.radioBirthdate_CheckedChanged);
            // 
            // radioRegister
            // 
            this.radioRegister.AutoSize = true;
            this.radioRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioRegister.Location = new System.Drawing.Point(6, 81);
            this.radioRegister.Name = "radioRegister";
            this.radioRegister.Size = new System.Drawing.Size(128, 19);
            this.radioRegister.TabIndex = 2;
            this.radioRegister.TabStop = true;
            this.radioRegister.Text = "Kayıt Tarihine Göre";
            this.radioRegister.UseVisualStyleBackColor = true;
            this.radioRegister.CheckedChanged += new System.EventHandler(this.radioRegister_CheckedChanged);
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
            // radioClass
            // 
            this.radioClass.AutoSize = true;
            this.radioClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioClass.Location = new System.Drawing.Point(223, 73);
            this.radioClass.Name = "radioClass";
            this.radioClass.Size = new System.Drawing.Size(95, 19);
            this.radioClass.TabIndex = 6;
            this.radioClass.TabStop = true;
            this.radioClass.Text = "Sınıfına Göre";
            this.radioClass.UseVisualStyleBackColor = true;
            this.radioClass.CheckedChanged += new System.EventHandler(this.radioClass_CheckedChanged);
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioTeacher.Location = new System.Drawing.Point(223, 48);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(143, 19);
            this.radioTeacher.TabIndex = 5;
            this.radioTeacher.TabStop = true;
            this.radioTeacher.Text = "Öğretmen Adına Göre";
            this.radioTeacher.UseVisualStyleBackColor = true;
            this.radioTeacher.CheckedChanged += new System.EventHandler(this.radioTeacher_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton1.Location = new System.Drawing.Point(223, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(182, 19);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Devamsızlık Durumuna Göre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioNoteCount
            // 
            this.radioNoteCount.AutoSize = true;
            this.radioNoteCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioNoteCount.Location = new System.Drawing.Point(125, 126);
            this.radioNoteCount.Name = "radioNoteCount";
            this.radioNoteCount.Size = new System.Drawing.Size(151, 19);
            this.radioNoteCount.TabIndex = 8;
            this.radioNoteCount.TabStop = true;
            this.radioNoteCount.Text = "Ders Not Sayısına Göre";
            this.radioNoteCount.UseVisualStyleBackColor = true;
            this.radioNoteCount.CheckedChanged += new System.EventHandler(this.radioNoteCount_CheckedChanged);
            // 
            // radioLesson
            // 
            this.radioLesson.AutoSize = true;
            this.radioLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioLesson.Location = new System.Drawing.Point(223, 23);
            this.radioLesson.Name = "radioLesson";
            this.radioLesson.Size = new System.Drawing.Size(114, 19);
            this.radioLesson.TabIndex = 4;
            this.radioLesson.TabStop = true;
            this.radioLesson.Text = "Ders Adına Göre";
            this.radioLesson.UseVisualStyleBackColor = true;
            this.radioLesson.CheckedChanged += new System.EventHandler(this.radioLesson_CheckedChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(155, 345);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 21);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(82, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Arama Yap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(823, 486);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(643, 382);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 65);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(562, 382);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 65);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(483, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 65);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(724, 382);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 65);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // btnAbsent
            // 
            this.btnAbsent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbsent.BackgroundImage")));
            this.btnAbsent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbsent.Location = new System.Drawing.Point(643, 453);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(75, 64);
            this.btnAbsent.TabIndex = 36;
            this.btnAbsent.UseVisualStyleBackColor = true;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNote.BackgroundImage")));
            this.btnNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNote.Location = new System.Drawing.Point(562, 453);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(75, 64);
            this.btnNote.TabIndex = 35;
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(870, 534);
            this.Controls.Add(this.btnAbsent);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtGirdStudentList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGirdStudentList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGirdStudentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioBirthdate;
        private System.Windows.Forms.RadioButton radioRegister;
        private System.Windows.Forms.RadioButton radioClass;
        private System.Windows.Forms.RadioButton radioTeacher;
        private System.Windows.Forms.RadioButton radioLesson;
        private System.Windows.Forms.RadioButton radioNoteCount;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAbsent;
        private System.Windows.Forms.Button btnNote;
    }
}