using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMg
{
    class Student
    {
        
        protected string mahv;
        protected string hoten;
        protected DateTime ngaysinh = new DateTime();
        protected bool gioitinh;
        protected string monhocA;
        protected string monhocB;
        public Student()
        {
            mahv = "";
            hoten = "";
            ngaysinh = DateTime.Today;
            gioitinh = false;
            monhocA = monhocB = "";
        }
        public Student(string ma, string ht, DateTime ns, bool gt, string c1, string c2)
        {
            mahv = ma;
            hoten = ht;
            ngaysinh = ns;
            gioitinh = gt;
            monhocA = c1;
            monhocB = c2;
        }
        public string Mahv
        {
            get
            {
                return mahv;
            }
            set
            {
                mahv = value;
            }
        }
        public string Hoten
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public bool Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
            }
        }

        public string MonhocA
        {
            get
            {
                return monhocA;
            }
            set
            {
                monhocA = value;
            }
        }
        public string MonhocB
        {
            get
            {
                return monhocB;
            }
            set
            {
                monhocB = value;
            }
        }
        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                ngaysinh = value;
            }
        }
    }
}


