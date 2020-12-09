using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMg
{
    internal partial class Mainfrm : Form
    {
        private Studentfrm studentfrm = new Studentfrm();

        public Mainfrm()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            studentfrm.MdiParent = this;
            studentfrm.Show();
        }

        //private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}

        private void classroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedList<Student> liststudent = studentfrm.getliststudent();
            Classroomfrm frm = new Classroomfrm(liststudent);
            frm.MdiParent = this;

            frm.Show();
        }



        private void studentToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            mnToolStripMenuItem.ToolTipText = "Student Menu";
        }

        //private void Mainfrm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
