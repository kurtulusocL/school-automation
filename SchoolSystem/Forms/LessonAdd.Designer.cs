﻿namespace SchoolSystem.Forms
{
    partial class LessonAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonAdd));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEditPage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(189, 62);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 61);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEditPage
            // 
            this.btnEditPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPage.BackgroundImage")));
            this.btnEditPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPage.Location = new System.Drawing.Point(108, 62);
            this.btnEditPage.Name = "btnEditPage";
            this.btnEditPage.Size = new System.Drawing.Size(75, 61);
            this.btnEditPage.TabIndex = 3;
            this.btnEditPage.UseVisualStyleBackColor = true;
            this.btnEditPage.Click += new System.EventHandler(this.btnEditPage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(27, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 61);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLessonName
            // 
            this.txtLessonName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLessonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLessonName.Location = new System.Drawing.Point(64, 22);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(156, 21);
            this.txtLessonName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ders Adı";
            // 
            // LessonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(278, 136);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEditPage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLessonName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LessonAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEditPage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.Label label1;
    }
}