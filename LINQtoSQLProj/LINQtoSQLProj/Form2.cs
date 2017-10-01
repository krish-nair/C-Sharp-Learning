﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQLProj
{
    public partial class Form2 : Form
    {
        CompanyDBDataContext dc;
        List<Employee> Emps;
        int rno = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dc = new CompanyDBDataContext();
            Emps = dc.Employees.ToList();

            ShowData();
        }
        private void ShowData()
        {
            textBox1.Text = Emps[rno].Eno.ToString();
            textBox2.Text = Emps[rno].Ename;

            textBox3.Text = Emps[rno].Role;
            textBox4.Text = Emps[rno].Salary.ToString();
            textBox5.Text = Emps[rno].Dname;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {
                rno -= 1;
                ShowData();
            }
            else
                MessageBox.Show("First record of the table");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rno < Emps.Count - 1)
            {
                rno += 1;
                ShowData();
            }
            else
                MessageBox.Show("Last record of the table");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
