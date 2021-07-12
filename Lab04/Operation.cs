using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Operation
    {
        public double num1; //properties
        public double num2;//properties
        public string operation;//properties
        public Operation(double num1, double num2, string operation)//constructor
        {
            this.num1 = num1;//Dependency
            this.num2 = num2;//Dependency
            this.operation = operation;//Dependency
        }
        public double Execute()
        {

            if (operation == "+")//plus symbol
            {
                return this.num1 + this.num2;
            }
            else if (this.operation == "-")//minus sign
            {
                return this.num1 - this.num2;
            }
            else if  (this.operation == "*")//multiplication sign
            {
                return this.num1 * this.num2;
            }
            else if (this.operation == "/")//division sign
            {
                return this.num1 / this.num2;
            }
            else 
            {
                throw new Exception("***Error***");//Prevent error information
            }
            
        }
    }
}