using System.Windows.Forms;

namespace StudentMg
{
    partial class Studentfrm
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnviewinfo = new System.Windows.Forms.Button();
            this.chkgender = new System.Windows.Forms.CheckBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcourseA = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdateborn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcourseB = new System.Windows.Forms.TextBox();
            this.lvwstu = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateBorn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(444, 79);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(78, 22);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(444, 126);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(78, 22);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(444, 173);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(78, 22);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnviewinfo
            // 
            this.btnviewinfo.Location = new System.Drawing.Point(444, 237);
            this.btnviewinfo.Name = "btnviewinfo";
            this.btnviewinfo.Size = new System.Drawing.Size(78, 22);
            this.btnviewinfo.TabIndex = 3;
            this.btnviewinfo.Text = "Back";
            this.btnviewinfo.UseVisualStyleBackColor = true;
            this.btnviewinfo.Click += new System.EventHandler(this.btnviewinfo_Click);
            // 
            // chkgender
            // 
            this.chkgender.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkgender.AutoSize = true;
            this.chkgender.Location = new System.Drawing.Point(201, 316);
            this.chkgender.Name = "chkgender";
            this.chkgender.Size = new System.Drawing.Size(40, 23);
            this.chkgender.TabIndex = 4;
            this.chkgender.Text = "Male";
            this.chkgender.UseVisualStyleBackColor = true;
            this.chkgender.CheckedChanged += new System.EventHandler(this.chkgender_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(201, 121);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(176, 20);
            this.txtname.TabIndex = 5;
            // 
            // txtcourseA
            // 
            this.txtcourseA.Location = new System.Drawing.Point(201, 166);
            this.txtcourseA.Name = "txtcourseA";
            this.txtcourseA.Size = new System.Drawing.Size(176, 20);
            this.txtcourseA.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(201, 79);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(176, 20);
            this.txtid.TabIndex = 7;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(49, 121);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // dtpdateborn
            // 
            this.dtpdateborn.Location = new System.Drawing.Point(201, 275);
            this.dtpdateborn.Name = "dtpdateborn";
            this.dtpdateborn.Size = new System.Drawing.Size(176, 20);
            this.dtpdateborn.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "DateBorn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SubjectID";
            // 
            // txtcourseB
            // 
            this.txtcourseB.Location = new System.Drawing.Point(201, 202);
            this.txtcourseB.Name = "txtcourseB";
            this.txtcourseB.Size = new System.Drawing.Size(176, 20);
            this.txtcourseB.TabIndex = 21;
            // 
            // lvwstu
            // 
            this.lvwstu.BackColor = System.Drawing.SystemColors.Control;
            this.lvwstu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameStudent,
            this.DateBorn,
            this.Gender,
            this.CourseA,
            this.CourseB});
            this.lvwstu.HideSelection = false;
            this.lvwstu.LabelEdit = true;
            this.lvwstu.Location = new System.Drawing.Point(12, 445);
            this.lvwstu.Name = "lvwstu";
            this.lvwstu.Size = new System.Drawing.Size(510, 191);
            this.lvwstu.TabIndex = 0;
            this.lvwstu.UseCompatibleStateImageBehavior = false;
            this.lvwstu.View = System.Windows.Forms.View.Details;
            this.lvwstu.SelectedIndexChanged += new System.EventHandler(this.lvwstu_SelectedIndexChanged_2);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NameStudent
            // 
            this.NameStudent.Text = "Name";
            // 
            // DateBorn
            // 
            this.DateBorn.Text = "DateBorn";
            this.DateBorn.Width = 197;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // CourseA
            // 
            this.CourseA.Text = "SubjectID";
            // 
            // CourseB
            // 
            this.CourseB.Text = "Subject";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Studentfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 661);
            this.Controls.Add(this.lvwstu);
            this.Controls.Add(this.txtcourseB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpdateborn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcourseA);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.chkgender);
            this.Controls.Add(this.btnviewinfo);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Name = "Studentfrm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnviewinfo;
        private System.Windows.Forms.CheckBox chkgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcourseA;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdateborn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcourseB;
        private System.Windows.Forms.ListView lvwstu;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameStudent;
        private System.Windows.Forms.ColumnHeader DateBorn;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader CourseA;
        private System.Windows.Forms.ColumnHeader CourseB;
        private ListView listView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

