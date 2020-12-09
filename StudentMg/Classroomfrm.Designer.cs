namespace StudentMg
{
    partial class Classroomfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvwstu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwclassroom = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwaddstudent = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtclassid = new System.Windows.Forms.TextBox();
            this.txtsyear = new System.Windows.Forms.TextBox();
            this.txtcertificate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaddclass = new System.Windows.Forms.Button();
            this.btndeleteclass = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.btneditclass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnaddStutoClass = new System.Windows.Forms.Button();
            this.btndeleteStuinclass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClassRoom";
            // 
            // lvwstu
            // 
            this.lvwstu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.lvwstu.FullRowSelect = true;
            this.lvwstu.HideSelection = false;
            this.lvwstu.Location = new System.Drawing.Point(474, 25);
            this.lvwstu.Name = "lvwstu";
            this.lvwstu.Size = new System.Drawing.Size(388, 523);
            this.lvwstu.TabIndex = 1;
            this.lvwstu.UseCompatibleStateImageBehavior = false;
            this.lvwstu.View = System.Windows.Forms.View.Details;
            this.lvwstu.SelectedIndexChanged += new System.EventHandler(this.lvwstu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DateBorn";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SubjectID";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Subject";
            // 
            // lvwclassroom
            // 
            this.lvwclassroom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwclassroom.FullRowSelect = true;
            this.lvwclassroom.HideSelection = false;
            this.lvwclassroom.Location = new System.Drawing.Point(53, 212);
            this.lvwclassroom.Name = "lvwclassroom";
            this.lvwclassroom.Size = new System.Drawing.Size(388, 125);
            this.lvwclassroom.TabIndex = 2;
            this.lvwclassroom.UseCompatibleStateImageBehavior = false;
            this.lvwclassroom.View = System.Windows.Forms.View.Details;
            this.lvwclassroom.SelectedIndexChanged += new System.EventHandler(this.lvwclassroom_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ClassID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "School Year";
            this.columnHeader7.Width = 122;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ceritifivate dergee";
            this.columnHeader8.Width = 137;
            // 
            // lvwaddstudent
            // 
            this.lvwaddstudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvwaddstudent.FullRowSelect = true;
            this.lvwaddstudent.HideSelection = false;
            this.lvwaddstudent.Location = new System.Drawing.Point(52, 386);
            this.lvwaddstudent.Name = "lvwaddstudent";
            this.lvwaddstudent.Size = new System.Drawing.Size(388, 125);
            this.lvwaddstudent.TabIndex = 3;
            this.lvwaddstudent.UseCompatibleStateImageBehavior = false;
            this.lvwaddstudent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Name";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "SubjectID";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Subject";
            // 
            // txtclassid
            // 
            this.txtclassid.Location = new System.Drawing.Point(126, 24);
            this.txtclassid.MaxLength = 10;
            this.txtclassid.Name = "txtclassid";
            this.txtclassid.Size = new System.Drawing.Size(124, 20);
            this.txtclassid.TabIndex = 25;
            // 
            // txtsyear
            // 
            this.txtsyear.Location = new System.Drawing.Point(126, 67);
            this.txtsyear.MaxLength = 10;
            this.txtsyear.Name = "txtsyear";
            this.txtsyear.Size = new System.Drawing.Size(124, 20);
            this.txtsyear.TabIndex = 26;
            // 
            // txtcertificate
            // 
            this.txtcertificate.Location = new System.Drawing.Point(126, 117);
            this.txtcertificate.MaxLength = 10;
            this.txtcertificate.Name = "txtcertificate";
            this.txtcertificate.Size = new System.Drawing.Size(124, 20);
            this.txtcertificate.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ClassID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Certificate dergee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "School Year";
            // 
            // btnaddclass
            // 
            this.btnaddclass.Location = new System.Drawing.Point(277, 25);
            this.btnaddclass.Name = "btnaddclass";
            this.btnaddclass.Size = new System.Drawing.Size(100, 23);
            this.btnaddclass.TabIndex = 31;
            this.btnaddclass.Text = "AddClassCoure";
            this.btnaddclass.UseVisualStyleBackColor = true;
            this.btnaddclass.Click += new System.EventHandler(this.btnaddclass_Click);
            // 
            // btndeleteclass
            // 
            this.btndeleteclass.Location = new System.Drawing.Point(277, 117);
            this.btndeleteclass.Name = "btndeleteclass";
            this.btndeleteclass.Size = new System.Drawing.Size(100, 23);
            this.btndeleteclass.TabIndex = 33;
            this.btndeleteclass.Text = "DeleteClassCourse";
            this.btndeleteclass.UseVisualStyleBackColor = true;
            this.btndeleteclass.Click += new System.EventHandler(this.btndeleteclass_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(393, 117);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 34;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // btneditclass
            // 
            this.btneditclass.Location = new System.Drawing.Point(277, 67);
            this.btneditclass.Name = "btneditclass";
            this.btneditclass.Size = new System.Drawing.Size(100, 23);
            this.btneditclass.TabIndex = 32;
            this.btneditclass.Text = "EditClassCourse";
            this.btneditclass.UseVisualStyleBackColor = true;
            this.btneditclass.Click += new System.EventHandler(this.btneditclass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "List Class Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "List Student in ClassRoom";
            // 
            // btnaddStutoClass
            // 
            this.btnaddStutoClass.Location = new System.Drawing.Point(53, 529);
            this.btnaddStutoClass.Name = "btnaddStutoClass";
            this.btnaddStutoClass.Size = new System.Drawing.Size(156, 28);
            this.btnaddStutoClass.TabIndex = 37;
            this.btnaddStutoClass.Text = "Add student into classroom";
            this.btnaddStutoClass.UseVisualStyleBackColor = true;
            this.btnaddStutoClass.Click += new System.EventHandler(this.btnaddStutoClass_Click);
            // 
            // btndeleteStuinclass
            // 
            this.btndeleteStuinclass.Location = new System.Drawing.Point(277, 529);
            this.btndeleteStuinclass.Name = "btndeleteStuinclass";
            this.btndeleteStuinclass.Size = new System.Drawing.Size(156, 28);
            this.btndeleteStuinclass.TabIndex = 38;
            this.btndeleteStuinclass.Text = "Delete student in class";
            this.btndeleteStuinclass.UseVisualStyleBackColor = true;
            this.btndeleteStuinclass.Click += new System.EventHandler(this.btndeleteStuinclass_Click);
            // 
            // Classroomfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 579);
            this.Controls.Add(this.btndeleteStuinclass);
            this.Controls.Add(this.btnaddStutoClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btndeleteclass);
            this.Controls.Add(this.btneditclass);
            this.Controls.Add(this.btnaddclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcertificate);
            this.Controls.Add(this.txtsyear);
            this.Controls.Add(this.txtclassid);
            this.Controls.Add(this.lvwaddstudent);
            this.Controls.Add(this.lvwclassroom);
            this.Controls.Add(this.lvwstu);
            this.Controls.Add(this.label1);
            this.Name = "Classroomfrm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Classroomfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwstu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvwclassroom;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lvwaddstudent;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TextBox txtclassid;
        private System.Windows.Forms.TextBox txtsyear;
        private System.Windows.Forms.TextBox txtcertificate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaddclass;
        private System.Windows.Forms.Button btndeleteclass;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button btneditclass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnaddStutoClass;
        private System.Windows.Forms.Button btndeleteStuinclass;
    }
}