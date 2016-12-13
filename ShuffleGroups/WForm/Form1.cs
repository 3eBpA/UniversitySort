using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;

namespace WForm
{

    public partial class Form1 : Form
    {
        UniversityDB db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new UniversityDB();
            var j = db.Audiences.Select(a=> new {ID= a.ID, Number = a.number, Group = a.Group.name});
            dataGridView1.DataSource = j.ToList();
            LoadCombo();

        }

        public void LoadCombo()
        {
            comboBox1.Items.Add("Audience");
            comboBox1.Items.Add("Semester");
            comboBox1.Items.Add("Software");
            comboBox1.Items.Add("Group");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Audience":
                    { dataGridView1.DataSource = db.Audiences.ToList(); dataGridView1.DataSource = db.Audiences.Local.ToBindingList(); }
                    break;
                case "Semester":
                    { dataGridView1.DataSource = db.Semesters.ToList(); }
                    break;
                case "Software":
                    { dataGridView1.DataSource = db.Softwares.ToList(); dataGridView1.DataSource = db.Softwares.Local.ToBindingList(); }
                    break;
                case "Group":
                    { dataGridView1.DataSource = db.Groups.ToList(); dataGridView1.DataSource = db.Groups.Local.ToBindingList(); }
                    break;
                default:
                    break;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string namedb = comboBox1.SelectedItem.ToString();
            if(namedb != string.Empty)
            {
                if(namedb == "Semester")
                {
                    AddSemesterForm form = new AddSemesterForm();
                    form.Show(); 
                }
                if (namedb == "Software")
                {
                    FormSoftware form = new FormSoftware();
                    form.Show();
                }
            }
        }
    }
}
