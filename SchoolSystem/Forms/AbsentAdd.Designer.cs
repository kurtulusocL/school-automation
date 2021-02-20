namespace SchoolSystem.Forms
{
    partial class AbsentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsentAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNameSurname = new System.Windows.Forms.ComboBox();
            this.dtPicDate = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEditPage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkYes = new System.Windows.Forms.CheckBox();
            this.chechNo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devamsızlık Günleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci Adı-Soyadı";
            // 
            // cmbNameSurname
            // 
            this.cmbNameSurname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbNameSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbNameSurname.FormattingEnabled = true;
            this.cmbNameSurname.Location = new System.Drawing.Point(134, 20);
            this.cmbNameSurname.Name = "cmbNameSurname";
            this.cmbNameSurname.Size = new System.Drawing.Size(182, 23);
            this.cmbNameSurname.TabIndex = 1;
            // 
            // dtPicDate
            // 
            this.dtPicDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPicDate.Location = new System.Drawing.Point(134, 78);
            this.dtPicDate.Name = "dtPicDate";
            this.dtPicDate.Size = new System.Drawing.Size(182, 21);
            this.dtPicDate.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(202, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 61);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEditPage
            // 
            this.btnEditPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPage.BackgroundImage")));
            this.btnEditPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPage.Location = new System.Drawing.Point(121, 140);
            this.btnEditPage.Name = "btnEditPage";
            this.btnEditPage.Size = new System.Drawing.Size(75, 61);
            this.btnEditPage.TabIndex = 7;
            this.btnEditPage.UseVisualStyleBackColor = true;
            this.btnEditPage.Click += new System.EventHandler(this.btnEditPage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(40, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 61);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ders Adı";
            // 
            // cmbLesson
            // 
            this.cmbLesson.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(134, 49);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(182, 23);
            this.cmbLesson.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Raporlu Mu";
            // 
            // checkYes
            // 
            this.checkYes.AutoSize = true;
            this.checkYes.Location = new System.Drawing.Point(134, 108);
            this.checkYes.Name = "checkYes";
            this.checkYes.Size = new System.Drawing.Size(48, 17);
            this.checkYes.TabIndex = 4;
            this.checkYes.Text = "Evet";
            this.checkYes.UseVisualStyleBackColor = true;
            // 
            // chechNo
            // 
            this.chechNo.AutoSize = true;
            this.chechNo.Location = new System.Drawing.Point(188, 108);
            this.chechNo.Name = "chechNo";
            this.chechNo.Size = new System.Drawing.Size(50, 17);
            this.chechNo.TabIndex = 5;
            this.chechNo.Text = "Hayır";
            this.chechNo.UseVisualStyleBackColor = true;
            // 
            // AbsentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(328, 217);
            this.Controls.Add(this.chechNo);
            this.Controls.Add(this.checkYes);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEditPage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtPicDate);
            this.Controls.Add(this.cmbLesson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNameSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AbsentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devamsızlık Ekleme Formu";
            this.Load += new System.EventHandler(this.AbsentAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNameSurname;
        private System.Windows.Forms.DateTimePicker dtPicDate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEditPage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkYes;
        private System.Windows.Forms.CheckBox chechNo;
    }
}