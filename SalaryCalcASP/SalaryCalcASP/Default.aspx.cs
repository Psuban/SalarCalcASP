using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryCalcASP
{
    public partial class Default : System.Web.UI.Page
    {
        double salaryPerYearCalc { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void calcButton_Click(object sender, EventArgs e)
        {
            string salaryInput = salaryInputTextBox.Text;
            double salaryInputDouble = double.Parse(salaryInput);    
              



            if (DropDownList1.Text == "Yearly")
            {
                resultBeforeDeductionsLabel.Text = "You should already know since you entered an annual salary but hey here you go £" + salaryInput;
            }

            else if (DropDownList1.Text == "Monthly")
            {
                salaryPerYearCalc = salaryInputDouble * 12;
                resultBeforeDeductionsLabel.Text = "£" + salaryPerYearCalc.ToString();
            }
            else if (DropDownList1.Text == "Weekly")
            {
                salaryPerYearCalc = salaryInputDouble * 52;
                resultBeforeDeductionsLabel.Text = "£" + salaryPerYearCalc.ToString();
            }
        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            if (DropDownList1.Text == "Yearly")
            {
                
            }
        }

        protected void noButton_Click(object sender, EventArgs e)
        {
            breakdownLabel.Text = "No problemo. Thanks for using Suban's Salary Breakdown and Calculator";
        }

        protected void salaryInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}