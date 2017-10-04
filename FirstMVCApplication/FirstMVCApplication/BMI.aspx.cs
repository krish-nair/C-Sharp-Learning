using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstMVCApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
protected void Button1_Click(object sender, EventArgs e)
        {
            
            double height = Convert.ToInt32(TextBox1.Text);
            double weight = Convert.ToInt32(TextBox2.Text);
            double bmi = Convert.ToInt32((weight/(height * height))*10000);


                Label3.Text = string.Format("BMI is : {0}", bmi);

               if (bmi < 16)
                {
                    Label3.Text = string.Format("BMI is: {0}, {1}", bmi, "Severely underweight");
                }
               else if (bmi >= 16 & bmi <= 18.5)
                {
                     Label3.Text = string.Format("BMI is: {0}, {1}", bmi, "Underweight");
                }
               else if (bmi > 18.5 & bmi <= 25)
                {
                     Label3.Text = string.Format("BMI is: {0}, {1}", bmi, "Healthy Weight");
                }
               else if (bmi > 25 & bmi <= 30)
                {
                    Label3.Text = string.Format("BMI is: {0}, {1}", bmi, "Over Weight");
                }
               else if (bmi > 30)
                {
                    Label3.Text = string.Format("BMI is: {0}, {1}", bmi, "Obese");
                }
           
        }


    }
}