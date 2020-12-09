using System;
using System.Collections;
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
    internal partial class Classroomfrm : Form
    {
        private LinkedList<Student> liststu = new LinkedList<Student>();
        private LinkedList<ClassC> listclassc = new LinkedList<ClassC>();
        private Hashtable studenthashtable = new Hashtable();
        private int i = 0;
        public Classroomfrm(LinkedList<Student> liststudent)
        {
            InitializeComponent();
            liststu = liststudent;
        }


        public void ShowStudentListView()
        {

            foreach (Student stu in liststu)
            {
                lvwstu.Items.Add(stu.Mahv);
                int j = lvwstu.Items.Count - 1;
                lvwstu.Items[j].SubItems.Add(stu.Hoten);
                lvwstu.Items[j].SubItems.Add(stu.Ngaysinh.ToShortDateString());
                if (stu.Gioitinh == true)
                    lvwstu.Items[j].SubItems.Add("Male");
                else
                    lvwstu.Items[j].SubItems.Add("Female");

                lvwstu.Items[j].SubItems.Add(stu.MonhocA);
                lvwstu.Items[j].SubItems.Add(stu.MonhocB);

            }
        }

        public void Showclassroom()
        {
            foreach (ClassC cls in listclassc)
            {
                lvwclassroom.Items.Add(cls.Malop);
                int i = lvwclassroom.Items.Count - 1;
                lvwclassroom.Items[i].SubItems.Add(cls.Khoa);
                lvwclassroom.Items[i].SubItems.Add(cls.HeDaoTao);
            }
        }



        public void Showstudentadded(string Malop)
        {
            foreach (Student stu in liststu)
            {
                if (Malop != null)
                {
                    lvwaddstudent.Items.Add(stu.Mahv);
                    int j = lvwstu.Items.Count - 1;
                    lvwaddstudent.Items[j].SubItems.Add(stu.Hoten);
                    lvwaddstudent.Items[j].SubItems.Add(stu.Ngaysinh.ToShortDateString());
                    if (stu.Gioitinh == true)
                        lvwaddstudent.Items[j].SubItems.Add("Male");
                    else
                        lvwaddstudent.Items[j].SubItems.Add("Female");
                }
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {


        }

        //public void SetList(LinkedList<Student> list)
        //{
        //    liststu = list;
        //}

        private void lvwstu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Classroomfrm_Load(object sender, EventArgs e)
        {
            if (liststu.Count != null)
            {
                ShowStudentListView();

                i = 0;
            }
        }

        private void btnaddclass_Click(object sender, EventArgs e)
        {
            if (listclassc.Count() != 0)
            {
                foreach (ClassC classroomC in listclassc)
                {

                    if (classroomC.Malop == txtclassid.Text)
                    {
                        MessageBox.Show("This id is already exist!!");
                        return;
                    }
                }
            }


            ClassC classC = new ClassC();
            classC.Malop = txtclassid.Text;
            classC.Khoa = txtsyear.Text;
            classC.HeDaoTao = txtcertificate.Text;
            listclassc.AddLast(classC);
            lvwclassroom.Items.Add(classC.Malop);
            int i = lvwclassroom.Items.Count - 1;
            lvwclassroom.Items[i].SubItems.Add(classC.Khoa);
            lvwclassroom.Items[i].SubItems.Add(classC.HeDaoTao);
            studenthashtable.Add(classC.Malop, new LinkedList<Student>());

        }

        private void btneditclass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to edit? Yes/No", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                for (int i = listclassc.Count - 1; i >= 0; i--)
                {
                    ClassC classroomC = listclassc.ElementAt(i);

                    var temp = lvwclassroom.SelectedItems[0].Text;
                    if (classroomC.Malop == temp)
                    {
                        ClassC classC = new ClassC();
                        classC.Malop = txtclassid.Text;
                        classC.Khoa = txtsyear.Text;
                        classC.HeDaoTao = txtcertificate.Text;
                        int j = i;
                        lvwclassroom.Items[j].Text = txtclassid.Text;
                        lvwclassroom.Items[j].SubItems[1].Text = txtsyear.Text;
                        lvwclassroom.Items[j].SubItems[2].Text = txtcertificate.Text;

                    }
                }
                
            }
        }

        private void btndeleteclass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete? Yes/No", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                for (int i = listclassc.Count - 1; i >= 0; i--)
                {
                    ClassC classroomC = listclassc.ElementAt(i);

                    var classidselected = lvwclassroom.SelectedItems[0].Text;
                    if (classroomC.Malop == classidselected)
                    {
                        lvwclassroom.Items.Remove(lvwclassroom.SelectedItems[0]);
                        listclassc.Remove(classroomC);
                        lvwaddstudent.Items.Clear();
                        break;
                    }
                }
            }
        }

        private void lvwclassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwclassroom.SelectedItems)
            {
                txtclassid.Text = lvi.SubItems[0].Text;
                txtsyear.Text = lvi.SubItems[1].Text;
                txtcertificate.Text = lvi.SubItems[2].Text;
                refeshAddedListByClassId(txtclassid.Text);
                break;
            }


        }

        private void btnaddStutoClass_Click(object sender, EventArgs e)
        {

            var classidselected = txtclassid.Text.Trim();

            if (lvwstu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select student in list!!!!");
                return;
            }
            if (classidselected == "")
            {
                MessageBox.Show("Please select Classroom.");
                return;
            }

            LinkedList<Student> students = (LinkedList<Student>)studenthashtable[classidselected];
            for (int i = liststu.Count - 1; i >= 0; i--)
            {
                Student student = liststu.ElementAt(i);

                var StudentId = lvwstu.SelectedItems[0].Text;
                if (student.Mahv == StudentId && !checkExistingStudentId(students, StudentId))
                {

                    
                    //clearAddedList();
                    students.AddLast(student);
                    refeshAddedListByClassId(classidselected);
                }
            }
        }

        private bool checkExistingStudentId(LinkedList<Student> students, string studentId)
        {
            if (students.Count() != 0)
            {
                foreach (Student std in students)
                {

                    if (std.Mahv == studentId)
                    {
                        MessageBox.Show("This id is already exist!!");
                        return true;
                    }

                }
                return false;

            }
            else
            {
                return false;
            }
        }

        private void clearAddedList()
        {
            lvwaddstudent.Items.Clear();
        }

        private void refeshAddedListByClassId(string Malop)
        {
            clearAddedList();
            LinkedList<Student> students = (LinkedList<Student>)studenthashtable[Malop];
            foreach (Student stu in students)
            {
                if (Malop != null)
                {

                    lvwaddstudent.Items.Add(stu.Mahv);
                    int j = lvwaddstudent.Items.Count - 1;
                    lvwaddstudent.Items[j].SubItems.Add(stu.Hoten);
                    lvwaddstudent.Items[j].SubItems.Add(stu.Ngaysinh.ToShortDateString());
                    if (stu.Gioitinh == true)
                        lvwaddstudent.Items[j].SubItems.Add("Male");
                    else
                        lvwaddstudent.Items[j].SubItems.Add("Female");
                }
            }

        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndeleteStuinclass_Click(object sender, EventArgs e)
        {
            var classidselected = txtclassid.Text.Trim();
            LinkedList<Student> students = (LinkedList<Student>)studenthashtable[classidselected];
            for (int i = liststu.Count - 1; i >= 0; i--)
            {
                Student student = liststu.ElementAt(i);
                var StudentId = lvwstu.SelectedItems[0].Text;
                if (student.Mahv == StudentId )
                {


                    //clearAddedList();
                    students.Remove(student);
                    refeshAddedListByClassId(classidselected);

                }


            }
        }
    }
}
