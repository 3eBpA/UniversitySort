﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_DB;

namespace UniversitySort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UniversityDB db = new UniversityDB();

            Software s = new Software() { Name = "Visual 2013" };

            db.Software.Add(s);
            db.SaveChanges();


           



        }
    }
}
