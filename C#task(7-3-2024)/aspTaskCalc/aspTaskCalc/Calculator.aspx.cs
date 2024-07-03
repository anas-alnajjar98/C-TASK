using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspTaskCalc
{
    public partial class Calculator : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Operator"] = string.Empty;
                ViewState["FirstOperand"] = string.Empty;
                ViewState["SecondOperand"] = string.Empty;
                ViewState["WaitingForSecondOperand"] = false;
            }

        }
        protected void ButtonPlus_Click(object sender, EventArgs e) => HandleOperator("+");
        protected void ButtonMinus_Click(object sender, EventArgs e) => HandleOperator("-");
        protected void ButtonMultiply_Click(object sender, EventArgs e) => HandleOperator("×");
        protected void ButtonDivide_Click(object sender, EventArgs e) => HandleOperator("÷");

        protected void Button0_Click(object sender, EventArgs e) => HandleDigit("0");
        protected void Button1_Click(object sender, EventArgs e) => HandleDigit("1");
        protected void Button2_Click(object sender, EventArgs e) => HandleDigit("2");
        protected void Button3_Click(object sender, EventArgs e) => HandleDigit("3");
        protected void Button4_Click(object sender, EventArgs e) => HandleDigit("4");
        protected void Button5_Click(object sender, EventArgs e) => HandleDigit("5");
        protected void Button6_Click(object sender, EventArgs e) => HandleDigit("6");
        protected void Button7_Click(object sender, EventArgs e) => HandleDigit("7");
        protected void Button8_Click(object sender, EventArgs e) => HandleDigit("8");
        protected void Button9_Click(object sender, EventArgs e) => HandleDigit("9");

        protected void ButtonDecimal_Click(object sender, EventArgs e) => HandleDigit(".");
        protected void ButtonClear_Click(object sender, EventArgs e) => Clear();
        protected void ButtonEquals_Click(object sender, EventArgs e) => Calculate();

        private void HandleDigit(string digit)
        {
            bool waitingForSecondOperand = (bool)ViewState["WaitingForSecondOperand"];
            if (waitingForSecondOperand)
            {
                ViewState["SecondOperand"] += digit;
            }
            else
            {
                ViewState["FirstOperand"] += digit;
            }
            UpdateDisplay();
        }

        private void HandleOperator(string op)
        {
            ViewState["Operator"] = op;
            ViewState["WaitingForSecondOperand"] = true;
            UpdateDisplay();
        }

        private void Clear()
        {
            ViewState["FirstOperand"] = string.Empty;
            ViewState["SecondOperand"] = string.Empty;
            ViewState["Operator"] = string.Empty;
            ViewState["WaitingForSecondOperand"] = false;
            UpdateDisplay();
        }

        private void Calculate()
        {
            string firstOperand = ViewState["FirstOperand"].ToString();
            string secondOperand = ViewState["SecondOperand"].ToString();
            string op = ViewState["Operator"].ToString();

            if (!string.IsNullOrEmpty(firstOperand) && !string.IsNullOrEmpty(secondOperand) && !string.IsNullOrEmpty(op))
            {
                decimal first = Convert.ToDecimal(firstOperand);
                decimal second = Convert.ToDecimal(secondOperand);
                decimal result = 0;

                switch (op)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    case "×":
                        result = first * second;
                        break;
                    case "÷":
                        result = first / second;
                        break;
                }

                ViewState["FirstOperand"] = result.ToString();
                ViewState["SecondOperand"] = string.Empty;
                ViewState["Operator"] = string.Empty;
                ViewState["WaitingForSecondOperand"] = false;
            }
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            string firstOperand = ViewState["FirstOperand"].ToString();
            string secondOperand = ViewState["SecondOperand"].ToString();
            CalculatorScreen.Text = secondOperand == string.Empty ? firstOperand : secondOperand;
        }


    }
}