namespace SchoolSystem.Forms
{
    partial class StudentNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentNoteList));
            this.dtGridNoteList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioResult = new System.Windows.Forms.RadioButton();
            this.radioNameSurname = new System.Windows.Forms.RadioButton();
            this.radioUpdate = new System.Windows.Forms.RadioButton();
            this.radioFinal = new System.Windows.Forms.RadioButton();
            this.radioTeacherName = new System.Windows.Forms.RadioButton();
            this.radioClass = new System.Windows.Forms.RadioButton();
            this.radioLesson = new System.Windows.Forms.RadioButton();
            this.radioVize = new System.Windows.Forms.RadioButton();
            this.radioCreate = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNoteList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridNoteList
            // 
            this.dtGridNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridNoteList.Location = new System.Drawing.Point(0, 0);
            this.dtGridNoteList.Name = "dtGridNoteList";
            this.dtGridNoteList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridNoteList.Size = new System.Drawing.Size(870, 295);
            this.dtGridNoteList.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(839, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioResult);
            this.groupBox1.Controls.Add(this.radioNameSurname);
            this.groupBox1.Controls.Add(this.radioUpdate);
            this.groupBox1.Controls.Add(this.radioFinal);
            this.groupBox1.Controls.Add(this.radioTeacherName);
            this.groupBox1.Controls.Add(this.radioClass);
            this.groupBox1.Controls.Add(this.radioLesson);
            this.groupBox1.Controls.Add(this.radioVize);
            this.groupBox1.Controls.Add(this.radioCreate);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama Yap";
            // 
            // radioResult
            // 
            this.radioResult.AutoSize = true;
            this.radioResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioResult.Location = new System.Drawing.Point(184, 81);
            this.radioResult.Name = "radioResult";
            this.radioResult.Size = new System.Drawing.Size(161, 19);
            this.radioResult.TabIndex = 5;
            this.radioResult.TabStop = true;
            this.radioResult.Text = "Yıl Sonu Durumuna Göre";
            this.radioResult.UseVisualStyleBackColor = true;
            this.radioResult.CheckedChanged += new System.EventHandler(this.radioResult_CheckedChanged);
            // 
            // radioNameSurname
            // 
            this.radioNameSurname.AutoSize = true;
            this.radioNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioNameSurname.Location = new System.Drawing.Point(6, 81);
            this.radioNameSurname.Name = "radioNameSurname";
            this.radioNameSurname.Size = new System.Drawing.Size(113, 19);
            this.radioNameSurname.TabIndex = 2;
            this.radioNameSurname.TabStop = true;
            this.radioNameSurname.Text = "Ad-Soyada Göre";
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
            // radioFinal
            // 
            this.radioFinal.AutoSize = true;
            this.radioFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioFinal.Location = new System.Drawing.Point(184, 56);
            this.radioFinal.Name = "radioFinal";
            this.radioFinal.Size = new System.Drawing.Size(124, 19);
            this.radioFinal.TabIndex = 4;
            this.radioFinal.TabStop = true;
            this.radioFinal.Text = "Final Notuna Göre";
            this.radioFinal.UseVisualStyleBackColor = true;
            this.radioFinal.CheckedChanged += new System.EventHandler(this.radioFinal_CheckedChanged);
            // 
            // radioTeacherName
            // 
            this.radioTeacherName.AutoSize = true;
            this.radioTeacherName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioTeacherName.Location = new System.Drawing.Point(351, 81);
            this.radioTeacherName.Name = "radioTeacherName";
            this.radioTeacherName.Size = new System.Drawing.Size(171, 19);
            this.radioTeacherName.TabIndex = 8;
            this.radioTeacherName.TabStop = true;
            this.radioTeacherName.Text = "Öğretmen Ad-Soyada Göre";
            this.radioTeacherName.UseVisualStyleBackColor = true;
            this.radioTeacherName.CheckedChanged += new System.EventHandler(this.radioTeacherName_CheckedChanged);
            // 
            // radioClass
            // 
            this.radioClass.AutoSize = true;
            this.radioClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioClass.Location = new System.Drawing.Point(351, 31);
            this.radioClass.Name = "radioClass";
            this.radioClass.Size = new System.Drawing.Size(95, 19);
            this.radioClass.TabIndex = 6;
            this.radioClass.TabStop = true;
            this.radioClass.Text = "Sınıfına Göre";
            this.radioClass.UseVisualStyleBackColor = true;
            this.radioClass.CheckedChanged += new System.EventHandler(this.radioClass_CheckedChanged);
            // 
            // radioLesson
            // 
            this.radioLesson.AutoSize = true;
            this.radioLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioLesson.Location = new System.Drawing.Point(351, 56);
            this.radioLesson.Name = "radioLesson";
            this.radioLesson.Size = new System.Drawing.Size(114, 19);
            this.radioLesson.TabIndex = 7;
            this.radioLesson.TabStop = true;
            this.radioLesson.Text = "Ders Adına Göre";
            this.radioLesson.UseVisualStyleBackColor = true;
            this.radioLesson.CheckedChanged += new System.EventHandler(this.radioLesson_CheckedChanged);
            // 
            // radioVize
            // 
            this.radioVize.AutoSize = true;
            this.radioVize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioVize.Location = new System.Drawing.Point(184, 31);
            this.radioVize.Name = "radioVize";
            this.radioVize.Size = new System.Drawing.Size(120, 19);
            this.radioVize.TabIndex = 3;
            this.radioVize.TabStop = true;
            this.radioVize.Text = "Vize Notuna Göre";
            this.radioVize.UseVisualStyleBackColor = true;
            this.radioVize.CheckedChanged += new System.EventHandler(this.radioVize_CheckedChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(83, 304);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Arama Yap";
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
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(717, 319);
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
            this.btnRefresh.Location = new System.Drawing.Point(636, 390);
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
            this.btnHome.Location = new System.Drawing.Point(636, 319);
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
            this.btnEdit.Location = new System.Drawing.Point(557, 319);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 65);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // StudentNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(870, 465);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtGridNoteList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentNoteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not ve Sene Sonu Durum Listesi";
            this.Load += new System.EventHandler(this.StudentNoteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridNoteList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridNoteList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioResult;
        private System.Windows.Forms.RadioButton radioUpdate;
        private System.Windows.Forms.RadioButton radioCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioFinal;
        private System.Windows.Forms.RadioButton radioVize;
        private System.Windows.Forms.RadioButton radioNameSurname;
        private System.Windows.Forms.RadioButton radioLesson;
        private System.Windows.Forms.RadioButton radioTeacherName;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioClass;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
    }
}