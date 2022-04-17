using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    public class FactorialOfNumber {
        public int returnFactorialOfNumber(int inputNumber) {
            int factorial = 1;
            if (inputNumber > 0) {
                for (int i = 1; i <= inputNumber; i++) {
                    factorial = factorial * i;
                }
            }
            else if (inputNumber == 0) {
                factorial = 0;
            }
            else {
                throw new ArithmeticException("please enter positive integer only"); 
            }
            return factorial;
        }

    }
}
