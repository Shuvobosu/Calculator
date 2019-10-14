using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calclutor
    {
        public double firstNumber;
        public double secondNumber;
        

        public double Add()
        {
            double addResult = firstNumber + secondNumber;
            return (addResult);
        }
        public double Multiply()
        {
            double mulResult = firstNumber * secondNumber;
            return (mulResult);
        }
        public double Subtract()
        {
            double subResult = firstNumber - secondNumber;
            return (subResult);
        }
        public double Divide()
        {
            double divResult = firstNumber / secondNumber;
            return (divResult);
        }
    }
}




