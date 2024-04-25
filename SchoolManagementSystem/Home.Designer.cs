﻿namespace SchoolManagementSystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmissionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldAdmissionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEACHERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem,
            this.oldAdmissionToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.tEACHERSToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutSchoolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(822, 88);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem1,
            this.oldAdmissionToolStripMenuItem1});
            this.newAdmissionToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAdmissionToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.admissions_message_logo;
            this.newAdmissionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(95, 84);
            this.newAdmissionToolStripMenuItem.Text = "ADMISSION";
            this.newAdmissionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newAdmissionToolStripMenuItem.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem_Click);
            // 
            // newAdmissionToolStripMenuItem1
            // 
            this.newAdmissionToolStripMenuItem1.Name = "newAdmissionToolStripMenuItem1";
            this.newAdmissionToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.newAdmissionToolStripMenuItem1.Text = "New Admission";
            this.newAdmissionToolStripMenuItem1.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem1_Click);
            // 
            // oldAdmissionToolStripMenuItem1
            // 
            this.oldAdmissionToolStripMenuItem1.Name = "oldAdmissionToolStripMenuItem1";
            this.oldAdmissionToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.oldAdmissionToolStripMenuItem1.Text = "Upgrade Semester";
            this.oldAdmissionToolStripMenuItem1.Click += new System.EventHandler(this.oldAdmissionToolStripMenuItem1_Click);
            // 
            // oldAdmissionToolStripMenuItem
            // 
            this.oldAdmissionToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldAdmissionToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.icon_fees;
            this.oldAdmissionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.oldAdmissionToolStripMenuItem.Name = "oldAdmissionToolStripMenuItem";
            this.oldAdmissionToolStripMenuItem.Size = new System.Drawing.Size(72, 84);
            this.oldAdmissionToolStripMenuItem.Text = "FEES";
            this.oldAdmissionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.oldAdmissionToolStripMenuItem.Click += new System.EventHandler(this.oldAdmissionToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem1,
            this.individualDetailsToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.stdicon;
            this.searchStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(142, 84);
            this.searchStudentToolStripMenuItem.Text = "STUDENT DETAILS";
            this.searchStudentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // searchStudentToolStripMenuItem1
            // 
            this.searchStudentToolStripMenuItem1.Name = "searchStudentToolStripMenuItem1";
            this.searchStudentToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.searchStudentToolStripMenuItem1.Text = "Search Student";
            this.searchStudentToolStripMenuItem1.Click += new System.EventHandler(this.searchStudentToolStripMenuItem1_Click);
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.individualDetailsToolStripMenuItem.Text = "Individual Details";
            this.individualDetailsToolStripMenuItem.Click += new System.EventHandler(this.individualDetailsToolStripMenuItem_Click);
            // 
            // tEACHERSToolStripMenuItem
            // 
            this.tEACHERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDINFOToolStripMenuItem,
            this.toolStripMenuItem1});
            this.tEACHERSToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.icon_djt_mb_im_a_teacher_296691;
            this.tEACHERSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tEACHERSToolStripMenuItem.Name = "tEACHERSToolStripMenuItem";
            this.tEACHERSToolStripMenuItem.Size = new System.Drawing.Size(102, 84);
            this.tEACHERSToolStripMenuItem.Text = "TEACHERS";
            this.tEACHERSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tEACHERSToolStripMenuItem.Click += new System.EventHandler(this.tEACHERSToolStripMenuItem_Click);
            // 
            // aDDINFOToolStripMenuItem
            // 
            this.aDDINFOToolStripMenuItem.Name = "aDDINFOToolStripMenuItem";
            this.aDDINFOToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aDDINFOToolStripMenuItem.Text = "ADD INFO.";
            this.aDDINFOToolStripMenuItem.Click += new System.EventHandler(this.aDDINFOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1.Text = "SEARCH";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudentToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.remstdicon;
            this.deleteStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 84);
            this.deleteStudentToolStripMenuItem.Text = "REMOVE STUDENTS";
            this.deleteStudentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.abouticon;
            this.feedbackToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(88, 84);
            this.feedbackToolStripMenuItem.Text = "ABOUT US";
            this.feedbackToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(12, 84);
            // 
            // aboutSchoolToolStripMenuItem
            // 
            this.aboutSchoolToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutSchoolToolStripMenuItem.Image = global::SchoolManagementSystem.Properties.Resources.exiticon;
            this.aboutSchoolToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutSchoolToolStripMenuItem.Name = "aboutSchoolToolStripMenuItem";
            this.aboutSchoolToolStripMenuItem.Size = new System.Drawing.Size(109, 84);
            this.aboutSchoolToolStripMenuItem.Text = "EXIT SYSTEM";
            this.aboutSchoolToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutSchoolToolStripMenuItem.Click += new System.EventHandler(this.aboutSchoolToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Brought To You By: code-projects.org";
            // 
            // button1
            // 
            this.button1.Image = global::SchoolManagementSystem.Properties.Resources.icpFieldr;
            this.button1.Location = new System.Drawing.Point(730, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 55);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SchoolManagementSystem.Properties.Resources.content_1417713014__international_school__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(220, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.banara_schoolImg21122016104034am2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(822, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oldAdmissionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oldAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tEACHERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDINFOToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}