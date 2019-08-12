//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace calculator_csharp
//{
//    class Class1
//    {
//        public void btn_click(object sender, EventArgs e)
//        {
//            Button button = (Button)sender;

//            if (!isOperator(button))// if the button is a number
//            {
//                if (isOprClick)
//                {
//                    num1 = float.Parse(textBox1.Text);
//                    textBox1.Text = "";
//                }
//                // if the textbox text not contain "."
//                if (!textBox1.Text.Contains("."))
//                {
//                    if (textBox1.Text.Equals("0") && !button.Text.Equals("."))
//                    {
//                        // delete the first "0"
//                        // set button text to the textbox
//                        // if the button text is not "."
//                        textBox1.Text = button.Text;
//                        isOprClick = false;
//                    }
//                    else
//                    {
//                        textBox1.Text += button.Text;
//                        isOprClick = false;
//                    }
//                }

//                else if (!button.Text.Equals("."))
//                {
//                    textBox1.Text += button.Text;
//                    isOprClick = false;
//                }
//            }
//            else // if the button is an operator [+ - / * =]
//            {
//                if (oprClickCount == 0)// if it's the first time we click on an operator
//                {
//                    oprClickCount++;
//                    // convert textbox text to float and set it into num1
//                    num1 = float.Parse(textBox1.Text);
//                    // get the operator from button text
//                    opr = button.Text;
//                    // set oprclick to true
//                    isOprClick = true;
//                }
//                else
//                {
//                    if (!button.Text.Equals("=")) { 
//                        if (!isEqualClick) 
//                        {
//                            num2 = float.Parse(textBox1.Text);
//                            textBox1.Text = Convert.ToString(calc(opr, num1, num2));
//                            num2 = float.Parse(textBox1.Text);
//                            opr = button.Text;
//                            isOprClick = true;
//                            isEqualClick = false;
//                        }
//                        else
//                        {
//                            isEqualClick = false;
//                            opr = button.Text;
//                        }
//                    }
//                    else
//                    {
//                        num2 = float.Parse(textBox1.Text);
//                        textBox1.Text = Convert.ToString(calc(opr, num1, num2));
//                        num1 = float.Parse(textBox1.Text);
//                        isOprClick = true;
//                        isEqualClick = true;
//                    }
//                }
//            }
//        }
//    }
