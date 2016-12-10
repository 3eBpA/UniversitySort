using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.Entity;
using University_DB;
=======
>>>>>>> 9ef937cd69108198ba9684200a615ef313205455

namespace WinFormUniversitySort
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        ModelDb db;
        public Form1()
        {
            InitializeComponent();
            db = new ModelDb();
            dataGridView1.DataSource = db.Semesters.ToList();
            dataGridView1.DataSource = db.Semesters.Local.ToBindingList();
=======
        public Form1()
        {
            InitializeComponent();
>>>>>>> 9ef937cd69108198ba9684200a615ef313205455
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
<<<<<<< HEAD
                db.SaveChanges();
=======
                
>>>>>>> 9ef937cd69108198ba9684200a615ef313205455
            }
        }
    }
}
