using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
	public partial class MainPage : ContentPage
	{
        bool isOperatorSelected = false;
        string operatorSelected;
        double result;
		public MainPage()
		{
			InitializeComponent();
		}

        private void DivideButton_Clicked(object sender, EventArgs e)
        {
            isOperatorSelected = true;
            operatorSelected = "Division";
            Op.Text = "/";
        }
        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            isOperatorSelected = true;
            operatorSelected = "Multiplication";
            Op.Text = "*";
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            isOperatorSelected = true;
            operatorSelected = "Addition";
            Op.Text = "+";
        }
        private void SubtractButton_Clicked(object sender, EventArgs e)
        {
            isOperatorSelected = true;
            operatorSelected = "Subtraction";
            Op.Text = "-";
        }

        private void ResultButton_Clicked(object sender, EventArgs e)
        {
            
            
            if (operatorSelected == "Addition")
            {
                //result = Addition((Convert.ToInt32(FirstValue)), (Convert.ToInt32(SecondValue)));
                result = Addition(Convert.ToDouble(FirstValue.Text), Convert.ToDouble(SecondValue.Text));
                
            }
            else if (operatorSelected == "Subtraction")
            {
                 result = Sub(Convert.ToDouble(FirstValue.Text), Convert.ToDouble(SecondValue.Text));
            }
            else if (operatorSelected == "Multiplication")
            {
                 result = Mul(Convert.ToDouble(FirstValue.Text), Convert.ToDouble(SecondValue.Text));
            }
            else if (operatorSelected == "Division")
            {
                 result = Division(Convert.ToDouble(FirstValue.Text), Convert.ToDouble(SecondValue.Text));
            }
            Result.Text= Convert.ToString(result);
           
        }

        private static double Division(double v1, double v2)
        {
            return v1 / v2 ;
        }

        private static double Mul(double v1, double v2)
        {
            return v1 * v2;
        }

        private static double Sub(double v1, double v2)
        {
            return v1 - v2;
        }

        private static double Addition(double v1, double v2)
        {
            return v1 + v2;
        }

        private void one_Clicked(object sender, EventArgs e)
        {
            if(!isOperatorSelected)
            {
                FirstValue.Text += "1";
            }
            else
            {
                SecondValue.Text += "1";
            }
        }
        private void two_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "2";
            }
            else
            {
                SecondValue.Text += "2";
            }
        }
        private void three_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "3";
            }
            else
            {
                SecondValue.Text += "3";
            }
        }
        private void four_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "4";
            }
            else
            {
                SecondValue.Text += "4";
            }
        }
        private void five_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "5";
            }
            else
            {
                SecondValue.Text += "5";
            }
        }
        private void six_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "6";
            }
            else
            {
                SecondValue.Text += "6";
            }
        }
        private void seven_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "7";
            }
            else
            {
                SecondValue.Text += "7";
            }
        }
        private void eight_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "8";
            }
            else
            {
                SecondValue.Text += "8";
            }
        }
        private void nine_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "9";
            }
            else
            {
                SecondValue.Text += "9";
            }
        }
        private void dot_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += ".";
            }
            else
            {
                SecondValue.Text += ".";
            }

        }
        private void zero_Clicked(object sender, EventArgs e)
        {
            if (!isOperatorSelected)
            {
                FirstValue.Text += "0";
            }
            else
            {
                SecondValue.Text += "0";
            }
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            //ClearValue(FirstValue.Text, SecondValue.Text, Result.Text);

            //FirstValue.Text.SetValue(FirstValue.Text, null);
            FirstValue.Text = "";
            SecondValue.Text = "";
            Result.Text = "";
            isOperatorSelected = false;
            Op.Text = "";

        }
    }
}
