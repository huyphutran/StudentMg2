namespace StudentMg
{
    partial class Mainfrm
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
            this.mnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnToolStripMenuItem
            // 
            this.mnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.classroomToolStripMenuItem});
            this.mnToolStripMenuItem.Name = "mnToolStripMenuItem";
            this.mnToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.mnToolStripMenuItem.Text = "ListReview";
            this.mnToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            this.mnToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.studentToolStripMenuItem_MouseMove);
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // classroomToolStripMenuItem
            // 
            this.classroomToolStripMenuItem.Name = "classroomToolStripMenuItem";
            this.classroomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.classroomToolStripMenuItem.Text = "Classroom";
            this.classroomToolStripMenuItem.Click += new System.EventHandler(this.classroomToolStripMenuItem_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainfrm";
            this.Text = "Mainfrm";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classroomToolStripMenuItem;
    }
}