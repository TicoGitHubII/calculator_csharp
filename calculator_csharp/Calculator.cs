using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_csharp
{
    public class Calculator
    {
        // members
        public int Left { get; set; }
        public int Right { get; set; }
        public string Operator { get; set; }
        public string Result { get; set; }

        public Calculator(int Right, int Left, string Operator)
        {
            this.Left = Left;
            this.Right = Right;
            this.Operator = Operator;

        }


        //public string Calculate(value)
        //{
        //    var x = 0;
        //    switch (x)
        //    {

        //        case 1:
        //            // sdfad
        //            break;
        //        default:
        //            Console.WriteLine("Result {Result}", Result);
        //    }


        //    return value
        //}

        //public int getResult() { return  }


    }

}
