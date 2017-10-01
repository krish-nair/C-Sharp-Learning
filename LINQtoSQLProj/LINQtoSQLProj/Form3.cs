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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new CompanyDBDataContext();
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
