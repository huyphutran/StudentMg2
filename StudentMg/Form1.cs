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
    public partial class Form1 : Form
    {
        private LinkedList<Student> liststu = new LinkedList<Student>();
        private int i = 0;
        private bool isEditModel = false;
        
        //TODO 2: click view list then ernable edit button and delete button.
       

        public void ShowStudent(int a)
        {
            if (a >= 0 && liststu != null)
            {
                int index = 0;
                foreach (Student stu in liststu)
                    if (index == a)
                    {
                        txtid.Text = stu.Mahv;
                        txtname.Text = stu.Hoten;
                        dtpdateborn.Value = stu.Ngaysinh;
                        chkgender.Checked = stu.Gioitinh;
                        txtcourseA.Text = stu.MonhocA;
                        txtcourseB.Text = stu.MonhocB;
                        break;
                    }
                index++;
            }
        }
        
        public void ShowListView()
        {
            lvwstu.Items.Clear();
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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(liststu.Count != null)
            {
                ShowListView();
                i = 0;
                ShowStudent(0);
            }

        }
        



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkgender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkgender.Checked == true)
                chkgender.Text ="Male";
            else
                chkgender.Text = "FeMale";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //TODO 1: check id if existing then show Dialog error.
            //Dialog   
            if(liststu.Count() != 0)
            {
                foreach(Student std in liststu) 
                {   
                    
                    if (std.Mahv == txtid.Text)
                    {
                        MessageBox.Show("This id is already exist!!");
                        return;
                    }
                }
            }
                btnadd.Enabled = true;

                Student stu = new Student();
                stu.Mahv = txtid.Text;
                stu.Hoten = txtname.Text;
                stu.Ngaysinh = dtpdateborn.Value;
                stu.Gioitinh = chkgender.Checked;
                stu.MonhocA = txtcourseA.Text;
                stu.MonhocB = txtcourseB.Text;
                liststu.AddLast(stu);
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

        private void btnedit_Click(object sender, EventArgs e)
        {   
            if(MessageBox.Show("Do you want to edit? Yes/No","Edit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnadd.Enabled = false;
                foreach (Student stu in liststu) {
                    stu.Hoten = txtname.Text;
                    stu.Ngaysinh = dtpdateborn.Value;
                    stu.Gioitinh = chkgender.Checked;
                    stu.MonhocA = txtcourseA.Text;
                    stu.MonhocB = txtcourseB.Text;
                    int j = i;
                    lvwstu.Items[j].Text = txtid.Text;
                    lvwstu.Items[j].SubItems[1].Text = txtname.Text;
                    lvwstu.Items[j].SubItems[2].Text = dtpdateborn.Value.ToShortDateString();
                    if (stu.Gioitinh == true)
                        lvwstu.Items[j].SubItems[3].Text = "Male";
                    else
                        lvwstu.Items[j].SubItems[3].Text = "FeMale";

                    lvwstu.Items[j].SubItems[4].Text = txtcourseA.Text;
                    lvwstu.Items[j].SubItems[5].Text = txtcourseB.Text;
                    break;
                    } 
                }

            //TODO 4: show dialog confirmation: Do you want to edit? Yes/No
            //Update student in student list by form information.
            //   stu.Hoten = txtname.Text;
            //            stu.Ngaysinh = dtpdateborn.Value;
            //            stu.Gioitinh = chkgender.Checked;
            //            stu.MonhocA = txtcourseA.Text;
            //            stu.MonhocB = txtcourseB.Text;
            //            int j = i;
            //            lvwstu.Items[j].Text = txtid.Text;
            //            lvwstu.Items[j].SubItems[1].Text = txtname.Text;
            //            lvwstu.Items[j].SubItems[2].Text = dtpdateborn.Value.ToShortDateString();
            //            if (stu.Gioitinh == true)
            //                lvwstu.Items[j].SubItems[3].Text = "Male";
            //            else
            //                lvwstu.Items[j].SubItems[3].Text = "FeMale";

            //            lvwstu.Items[j].SubItems[4].Text = txtcourseA.Text;
            //            lvwstu.Items[j].SubItems[5].Text = txtcourseB.Text;
            //            break;

            //if (i >= 0)
            //{
            //    int a = 0;
            //    foreach (Student stu in liststu)
            //    {
            //        if (a != liststu.Select(stu)
            //            a++;
            //        else
            //            if (a == liststu.Count)
            //        {
            //         
            //        }
            //    }
            //}
        }





        private void btndel_Click(object sender, EventArgs e)
        {

            //TODO 4: show dialog confirmation: Do you want to delete? Yes/No
            //if (lvwstu.Items.Count > 0)
            //{

            //    //liststu<Student>.Remove(Student);
            //    //lvwstu.Items.Remove(lvwstu.SelectedItems[0]);

            //}
            //Delete student in student list by form id.
            if (MessageBox.Show("Do you want to delete? Yes/No", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = liststu.Count - 1; i >= 0 ; i--)
                {
                    Student student = liststu.ElementAt(i);
                    var temp = lvwstu.SelectedItems[0].Text;
                    if(student.Mahv == temp)
                    {
                        lvwstu.Items.Remove(lvwstu.SelectedItems[0]);
                        break;
                    } 
                }
            }

        }

        private void lvwstu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //TODO 2: Get student information and fill it into form.
            //Student std = liststu.Find();
            //foreach (Student stu in liststu)
            //    txtid.Text = stu.Mahv;
            //stu.Mahv = liststu.Find(Student)



            //Enable flag edit mode. 
            // disable add button
            // enable edit button, delete button
            Console.WriteLine(e);
        }

        private void dlgeditmode_Click(object sender, EventArgs e)
        {   
            MessageBox.Show("This id is already exited");
        }

        private void lvwstu_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Console.WriteLine(e);
        }
    }
}
