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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new CompanyDBDataContext();
            if (textBox1.ReadOnly == false)
            {

                Employee obj = new Employee();
                obj.Eno = int.Parse(textBox1.Text);
                obj.Ename = textBox2.Text;
                obj.Role = textBox3.Text;
                obj.Salary = decimal.Parse(textBox4.Text);
                obj.Dname = textBox5.Text;
                dc.Employees.InsertOnSubmit(obj);
                dc.SubmitChanges();
                MessageBox.Show("Record inserted into the table");
                
            }
            else
            {
                Employee obj = dc.Employees.SingleOrDefault(E => E.Eno == int.Parse(textBox1.Text));
                obj.Ename = textBox2.Text;
                obj.Role = textBox3.Text;
                obj.Salary = decimal.Parse(textBox4.Text);
                obj.Dname = textBox5.Text;
                dc.SubmitChanges();
                MessageBox.Show("Record updated in the table.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
}
