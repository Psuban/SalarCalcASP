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
        double salaryPerYearCalc;
        double primaryTaxBoundary = 10600;
        double primaryNIBoundary = 8060;
        double basicTaxRateBoundary = 43000;
        double higherTaxRateBoundary = 150000;
        double higherNIRateBoundary = 43004;
        double basicTaxRate = 0.2;
        double higherTaxRate = 0.4;
        double additionalTaxRate = 0.45;
        double basicaNIRate = 0.12;
        double higherNIRate = 0.02;
        string yearlySalaryText = "<br />Salary per year after deductions: £";
        string monthlySalaryText = "<br />Salary per month after deductions: £";
        string taxText = "Tax: £";
        string nIText = "<br />National Insurance: £";
        double salaryPerYearInputDouble;

        public void calcSalaryPerYear()
        {
            string salaryInput = salaryInputTextBox.Text;
            salaryPerYearInputDouble = double.Parse(salaryInput);

            if (DropDownList1.Text == "Monthly")
            {
                salaryPerYearInputDouble = salaryPerYearInputDouble * 12;
            }
            else if (DropDownList1.Text == "Weekly")
            {
                salaryPerYearInputDouble = salaryPerYearInputDouble * 52;
            }

        }


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
                 
            calcSalaryPerYear();

               if (salaryPerYearInputDouble <= primaryTaxBoundary)
            {
                    if (salaryPerYearInputDouble <= primaryNIBoundary)
                    {

                        breakdownLabel.Text = taxText + 0 + nIText + 0 + yearlySalaryText + salaryPerYearInputDouble + monthlySalaryText + (salaryPerYearInputDouble/12);

                    }
                    else
                    {
                        double nIContribution = (salaryPerYearInputDouble - primaryNIBoundary) * basicaNIRate;
                        double leftOverYearlySalary = Math.Round(salaryPerYearInputDouble - nIContribution,2);
                        double leftOverMonthlySalary = Math.Round(leftOverYearlySalary / 12,2);
                        breakdownLabel.Text = taxText + 0 + nIText + nIContribution + yearlySalaryText + leftOverYearlySalary + monthlySalaryText + leftOverMonthlySalary;
                    }
             }

                else if (salaryPerYearInputDouble > primaryTaxBoundary && salaryPerYearInputDouble <= basicTaxRateBoundary)
            {
                double taxCalculation = (salaryPerYearInputDouble-primaryTaxBoundary) * basicTaxRate;
                double niCalculation = (salaryPerYearInputDouble - primaryNIBoundary) * basicaNIRate;
                double leftOverYearlySalary = Math.Round(salaryPerYearInputDouble - (taxCalculation + niCalculation),2);
                breakdownLabel.Text = taxText + taxCalculation + nIText + niCalculation + yearlySalaryText + leftOverYearlySalary + monthlySalaryText + Math.Round(leftOverYearlySalary / 12,2);
            } 
                else if (salaryPerYearInputDouble > basicTaxRateBoundary && salaryPerYearInputDouble <= higherTaxRateBoundary)
            {
                double taxCalculation = ((basicTaxRateBoundary - primaryTaxBoundary) *basicTaxRate ) + ((salaryPerYearInputDouble-basicTaxRateBoundary)* higherTaxRate);
                double niCalculation = ((higherNIRateBoundary - primaryNIBoundary) * basicaNIRate) + ((salaryPerYearInputDouble - higherNIRateBoundary) * higherNIRate);
                double leftOverYearlySalary = Math.Round(salaryPerYearInputDouble - niCalculation - taxCalculation, 2);
                breakdownLabel.Text = taxText + taxCalculation + nIText + niCalculation + yearlySalaryText + leftOverYearlySalary + monthlySalaryText + Math.Round(leftOverYearlySalary / 12, 2);
            }
               else if (salaryPerYearInputDouble > higherTaxRateBoundary)
            {
                double taxCalculation = ((basicTaxRateBoundary - primaryTaxBoundary) * basicTaxRate) + ((higherTaxRateBoundary - basicTaxRateBoundary) * higherTaxRate) + ((salaryPerYearInputDouble - higherTaxRateBoundary) * additionalTaxRate);
                double niCalculation = ((higherNIRateBoundary - primaryNIBoundary) * basicaNIRate) + ((salaryPerYearInputDouble - higherNIRateBoundary) * higherNIRate);
                double leftOverYearlySalary = Math.Round(salaryPerYearInputDouble - niCalculation - taxCalculation, 2);
                breakdownLabel.Text = taxText + taxCalculation + nIText +niCalculation + yearlySalaryText + leftOverYearlySalary + monthlySalaryText + Math.Round(leftOverYearlySalary / 12, 2);
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