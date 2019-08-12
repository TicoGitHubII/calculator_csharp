using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace calculator_csharp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public  int Left { get; set; }
        public  int Right { get; set; }
        public string Operator { get; set; }
        public string Result { get; set; }
        ArrayList memory = new ArrayList();


      

        //public Form1(int Left, int Right, string Operator) : this()
        //{
        //    this.Left = 0;
        //    this.Right = 0;
        //    this.Operator = Operator;

        //}

        int isOprClickCount = 0;
        bool isOprClick = false, isEqualClick = false;
        Stack recall = new Stack();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {

                if (c is Button)
                {
                    if(c.Text != "C") { 
                    c.Click += new EventHandler(buttonClick);
                    }
                }
            }
        }
        //  4 /, 8 *, 12 - , 16 + 

        public void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!isOperator(button))
            {
                if (isOprClick)
                {
                    // if its not an operator this then number
                    Left = int.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                // if contains '.'
                if (!textBox1.Text.Contains("."))
                {
                    if (textBox1.Text.Equals("0") && !button.Text.Equals("."))
                    {

                        textBox1.Text = button.Text;
                        isOprClick = false;
                    }
                    else
                    {
                        textBox1.Text += button.Text;
                        isOprClick = false;
                    }

                }
                else if (!button.Text.Equals("."))
                {
                    textBox1.Text += button.Text;
                    isOprClick = false;
                }
            }
            else // button Operator
            {
                if (isOprClickCount == 0)
                {
                    isOprClickCount++;
                    Left = int.Parse(textBox1.Text);
                    Operator = button.Text;
                    isOprClick = true;

                }
                else
                {     // Equals
                    if (!button.Text.Equals("=")) {
                        if (!isEqualClick)
                        {
                            Right = int.Parse(textBox1.Text);
                            textBox1.Text = Convert.ToString(Calculate(Left, Right, Operator));
                            Right = int.Parse(textBox1.Text);
                            //Operator = button.Text;
                            isOprClick = true;
                            isEqualClick = false;
                        }
                        else {
                            isEqualClick = false;
                            Operator = button.Text;

                            }

                    } else {
                            Right =int.Parse(textBox1.Text);
                            textBox1.Text = Convert.ToString(Calculate(Left, Right, Operator));
                            Left = int.Parse(textBox1.Text);
                            isOprClick = true;
                            isEqualClick = true;
                            recall.Push(Left); // push to stack 
                    


                    }
                }
            }  if (button.Text.Equals("MR")) {
                               
                 while(recall.Count > 0) { 
                textBox1.Text = recall.Pop().ToString();
                    if (recall.Count <= 0) MessageBox.Show("Empty"); break;
                }  

            }
        }

        public bool isOperator(Button button)
        {
            var oper = false;
            var buttonText = button.Text;

            switch (buttonText)
            {
                case "+":
                case "-":
                case "/":
                case "*":
                case "=":
                case ".":
                    oper = true;
                    break; 
                default:               
                    break;

            }
            return oper;
        }

        // Operator a button?
        public int Calculate(int left, int right, string oper)
        {
            int Result = 0;

            switch (oper)
            {
                case "+":
                    Result = left + right;

                    break;
                case "-":
                    Result = left - right;
                    break;
                case "/":
                    if (right != 0)
                    {
                        Result = left / right;
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by Zero {0}/{1}", left, right);
                    }
                    break;
                case "*":
                    Result = left * right;
                    break;
            
                default:
                    Console.WriteLine("error please check inputs of Calculate");
                    break;
            }
            return Result;
        }




        //  20  calculate =
        private void getPrevious_Click(object sender, EventArgs e)
        {

            textBox1.Text =   (string)recall.Pop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Left = 0;
                Right = 0;
                Operator = "";
                isOprClick = false;
                isEqualClick = false;
                isOprClickCount = 0;
                textBox1.Text = "0";
                recall.Clear();
            
        }
    }
}
