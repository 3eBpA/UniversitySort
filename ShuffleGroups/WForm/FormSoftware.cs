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
    public partial class FormSoftware : Form
    {
        UniversityDB db;
        public FormSoftware()
        {
            InitializeComponent();
        }

        private void FormSoftware_Load(object sender, EventArgs e)
        {
            db = new UniversityDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Software soft = new Software()
            {
                name = textBox_softname.Text
            };
            db.Softwares.Add(soft);
            db.SaveChanges();
        }

       
    }
}
