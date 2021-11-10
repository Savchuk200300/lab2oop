using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetAllStudents();
        }

        private string path = "Gurtojytok.xml";
        private List<Student> final = new List<Student>();

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DormBox.Text = null;
            FloorBox.Text = null;
            RoomBox.Text = null;
            SurnameBox.Text = null;
            NameBox.Text = null;
            PhoneBox.Text = null;
            Dorm.Checked = false;
            Floor.Checked = false;
            Room.Checked = false;
            Surname.Checked = false;
            NameCheck.Checked = false;
            PhoneNumber.Checked = false;
            LINQ.Checked = false;
            DOM.Checked = false;
            SAX.Checked = false;
        }

        private void Output(List<Student> final)
        {
            int i = 1;
            foreach(Student n in final)
            {
                richTextBox1.AppendText(i++ + "." + "\n");
                richTextBox1.AppendText("Гуртожиток: " + n.Dorm + "\n");
                richTextBox1.AppendText("Поверх: " + n.Floor + "\n");
                richTextBox1.AppendText("Кімната: " + n.Room + "\n");
                richTextBox1.AppendText("Ім'я: " + n.Name + "\n");
                richTextBox1.AppendText("Фамілія: " + n.Surname + "\n");
                richTextBox1.AppendText("Телефон: " + n.PhoneNumber + "\n\n");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Student _student = OurStudent();
            if (LINQ.Checked)
            {
                IStrategy CurrentStrategy = new Linq(path);
                final = CurrentStrategy.Algorithm(_student, path);
                Output(final);
            }
            if (DOM.Checked)
            {
                IStrategy CurrentStrategy = new Dom(path);
                final = CurrentStrategy.Algorithm(_student, path);
                Output(final);
            }
            if (SAX.Checked)
            {
                IStrategy CurrentStrategy = new Sax(path);
                final = CurrentStrategy.Algorithm(_student, path);
                Output(final);
            }
        }

        private Student OurStudent()
        {
            string[] info = new string[6];
            if (Dorm.Checked)
            {
                info[0] = Convert.ToString(DormBox.Text);
            }
            if (Floor.Checked)
            {
                info[1] = Convert.ToString(FloorBox.Text);
            }
            if (Room.Checked)
            {
                info[2] = Convert.ToString(RoomBox.Text);
            }
            if (Surname.Checked)
            {
                info[3] = Convert.ToString(SurnameBox.Text);
            }
            if (NameCheck.Checked)
            {
                info[4] = Convert.ToString(NameBox.Text);
            }
            if (PhoneNumber.Checked)
            {
                info[5] = Convert.ToString(PhoneBox.Text);
            }

            Student IdealStudent = new Student(info);
            return IdealStudent;
        }

        public void GetAllStudents()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Gurtojytok.xml");
            XmlNodeList elem = doc.SelectNodes("//dorm");
            foreach(XmlNode e in elem)
            {
                XmlNodeList list1 = e.ChildNodes;
                foreach(XmlNode el in list1)
                {
                    XmlNodeList list2 = el.ChildNodes;
                    foreach (XmlNode ell in list2)
                    {
                        string dorm = ell.ParentNode.ParentNode.Attributes.GetNamedItem("DORM").Value;
                        if (!DormBox.Items.Contains(dorm))
                        {
                            DormBox.Items.Add(dorm);
                        }
                        string floor = ell.ParentNode.Attributes.GetNamedItem("FLOOR").Value;
                        if (!FloorBox.Items.Contains(floor))    
                        {
                            FloorBox.Items.Add(floor);
                        }
                        string room = ell.Attributes.GetNamedItem("ROOM").Value;
                        if (!RoomBox.Items.Contains(room))
                        {
                            RoomBox.Items.Add(room);
                        }
                        string surname = ell.Attributes.GetNamedItem("SURNAME").Value;
                        if (!SurnameBox.Items.Contains(surname))
                        {
                            SurnameBox.Items.Add(surname);
                        }
                        string name = ell.Attributes.GetNamedItem("NAME").Value;
                        if (!NameBox.Items.Contains(name))
                        {
                            NameBox.Items.Add(name);
                        }
                        string phonenumber = ell.Attributes.GetNamedItem("PHONENUMBER").Value;
                        if (!PhoneBox.Items.Contains(phonenumber))
                        {
                            PhoneBox.Items.Add(phonenumber);
                        }
                    }
                }
            }
        }

        private void Transfor_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("transform.xsl");
            string input = @"Gurtojytok.xml";
            string result = @"info.html";
            xslt.Transform(input, result);
            MessageBox.Show("Трансформовано");
        }

        private void хелпToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гуртожитки\n\n\nНазва гуртожитку\nПоверх\nКімната\nІм'я\nФамілія\nТелефон", "Варіант");
        }

        private void PhoneBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
