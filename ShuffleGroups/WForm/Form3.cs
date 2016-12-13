using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;

namespace WForm
{
    public partial class AddSemesterForm : Form
    {
        List<Software> listSoft;
        UniversityDB db;
        public AddSemesterForm()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listSoft = new List<Software>();
            db = new UniversityDB();
            db.Softwares.ToList().ForEach(a => comboBox1.Items.Add(a.name));
            if (comboBox1.Items.Count > 0)
                button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ee = db.Softwares.Where(a => a.name == comboBox1.SelectedItem.ToString()).SingleOrDefault();
            listSoft.Add(ee);
            label1.Text += " +" + ee.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                Semester sem = new Semester()
                {
                    numberOfSemester = Convert.ToInt32(textBox1.Text),
                    Specialization = textBox_Specialization.Text,
                    Software = listSoft
                };
                db.Semesters.Add(sem);
                db.SaveChanges();
            }
        }
    }
}
