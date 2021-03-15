using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class calc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string SelectedSymbol { get; set; }

        public double Add(double one, double two)
        {
            return one + two;

        }
        public double Subtract(double one, double two)
        {
            return one - two;
        }
        public double Divide(double one, double two)
        {
            return one / two;
        }
        public double Multiply(double one, double two)
        {
            return one * two;
        }
        public string[] LoadSymbols()
        {
            String[] ComboBoxItems = new[] { "Choose an operation", "*", "-", "+", "/" };
            return ComboBoxItems;
        }
        public double SelectOperation()
        {
            double Answer = 0;
            switch (SelectedSymbol)
            {
                case "*":
                    Answer = Multiply(num1, num2);
                    break;
                case "-":
                    Answer = Subtract(num1, num2);
                    break;
                case "+":
                    Answer = Add(num1, num2);
                    break;
                case "/":
                    Answer = Divide(num1, num2);
                    break;
            }
            return Answer;
        }

    }
}
