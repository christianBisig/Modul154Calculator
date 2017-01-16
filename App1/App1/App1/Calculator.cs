using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Calculator
    {
        public float Calculate(string OperationSign, float Number1, float Number2)
        {
            switch (OperationSign)
            {
                case "+":
                    return Addition(Number1, Number2);
                case "-":
                    return Subtraction(Number1, Number2);
                case "*":
                    return Multiplication(Number1, Number2);
                case ":":
                    return Division(Number1, Number2);
            }
            throw new Exception("Not Recognized Operation");
        }

        private float Addition(float Number1, float Number2) => Number1 + Number2;

        private float Subtraction(float Number1, float Number2) => Number1 - Number2;

        private float Multiplication(float Number1, float Number2) => Number1 * Number2;

        private float Division(float Number1, float Number2) => Number1 / Number2;
    }
}
