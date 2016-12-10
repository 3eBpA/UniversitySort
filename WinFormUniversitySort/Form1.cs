using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using University_DB;

namespace WinFormUniversitySort
{
    public partial class Form1 : Form
    {
        ModelDb db;
        public Form1()
        {
            InitializeComponent();
            db = new ModelDb();
            dataGridView1.DataSource = db.Semesters.ToList();
            dataGridView1.DataSource = db.Semesters.Local.ToBindingList();
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                db.SaveChanges();
            }
        }
    }
}
