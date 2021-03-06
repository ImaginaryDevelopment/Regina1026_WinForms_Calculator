﻿/*
 * 
 * 2018-10-07 - Created by Regina Curtis as personal learning project
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator
{
    public partial class Form1 : Form
    {

        //Variables
        string input = string.Empty; //string to store user input
        string opperand1 = string.Empty; //string to store first value
        string opperand2 = string.Empty; //string to store second value
        char operation; //to store chosen operation
        decimal result = 0; //calculated result


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box of current value
            input += "0";  //add 0 to existing value entered by user
            this.txt_01.Text += input; //adds new value to text field to display to user
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "1";  //add 1 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }
        private void Btn_Two_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "2";  //add 2 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "3";  //add 3 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "4";  //add 4 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "5";  //add 5 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "6";  //add 6 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "7";  //add 7 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "8";  //add 8 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user        
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //clear text box
            input += "9";  //add 9 to existing value entered by user
            this.txt_01.Text += input; //adds value to text field to display to user
        }
        
        private void Btn_Period_Click(object sender, EventArgs e)
        {
            //check if period button has been pressed before, if so don't allow a second time
            if (input.Contains("."))
            {
                this.txt_01.Text = input;
            }

            else
            {
                this.txt_01.Text = ""; //clear text box
                input += ".";  //add . to existing value entered by user
                this.txt_01.Text += input; //adds value to text field to display to user
            }
                        
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Btn_Subtract_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            opperand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = "";
            this.input = string.Empty;
            this.opperand1 = string.Empty;
            this.opperand2 = string.Empty;
        }

        //Allow user to delete values
        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            this.txt_01.Text = ""; //remove text from text field

            //check if the input variable is null
            if (input != "")  
            {
                //if it isn't remove the last character
                input = input.Remove(input.Length - 1, 1);
            }
            
            //display what is in input
            this.txt_01.Text = input;
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hi gina");
            opperand2 = input;  //save second value
            this.input = string.Empty; //clear value from input for next use
            decimal num1, num2;  //variables to hold values for computations
            decimal.TryParse(opperand1, out num1); //move values 
            decimal.TryParse(opperand2, out num2); //move values
            
            if (operation == '+')  //add values together
            {
                result = num1 + num2;
                txt_01.Text = result.ToString("#,###.################################");  //display with commas
            }   
            else if (operation == '-') //subtract 1st value from 2nd
            {
                result = num1 - num2;
                txt_01.Text = result.ToString("#,###.################################"); //display value with commas
            }
            else if (operation == '*') //mulitply values together
            {
                result = num1 * num2;
                txt_01.Text = result.ToString("#,###.################################");
            }
            else if (operation == '/') //divide 1st value into second value
            {
                if (num2 != 0) //make sure second value isn't 0
                {
                    result = num1 / num2;
                    txt_01.Text = result.ToString("#,###.################################");
                }
                else  //if value is 0 display error message
                {
                    txt_01.Text = "Invalid - Unable to Divide by 0!";
                }

            }
        }

        //Open new window for dollars to euros conversion
        private void BtnDollarsToEuros_Click(object sender, EventArgs e)
        {
            var newWindow = new EurosToDollarsForm();
            newWindow.Location = this.Location;
            this.Hide();
            newWindow.Show();
                        
        }
    }
}