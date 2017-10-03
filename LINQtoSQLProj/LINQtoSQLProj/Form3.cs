using System;
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
    public partial class Form3 : Form
    {
        CompanyDBDataContext dc;

        public Form3()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dc = new CompanyDBDataContext();
            dgView.DataSource = dc.Employees;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                Form4 f = new Form4();
                f.textBox1.ReadOnly = true;
                f.textBox1.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                f.textBox2.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                f.textBox3.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                f.textBox4.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
                f.textBox5.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a row for the pdation", "Information", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
        }
    }
}
