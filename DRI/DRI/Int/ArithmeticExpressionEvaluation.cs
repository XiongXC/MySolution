using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRI.Int
{
    public class ArithmeticExpressionEvaluation
    {
        public static void Evaluate(string expression)
        {
            /* 
             1. Push operands onto the operand stack
             2. Push operators onto the operator stack
             3. Ignore left parentheses
             4. On encountering a right parenthesis, 
                pop an operator, 
                pop the requisite number of operands,
                Push onto the operand stack the result of applying that operator to those operands.
             5. After the final right parenthesis has been processed, there is one value on the stack,
                which is the value of the expression.
             */
            Stack<String> operators = new Stack<string>();
            Stack<Double> operands = new Stack<double>();

            string[] expr = expression.Split();
        }
    }
}
