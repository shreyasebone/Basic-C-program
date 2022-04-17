using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    public class SumOfNumber {
        public int returnSumOfNumber(int inputNumber) {
            int sumOfNNumber = 0;
            for (int i = 1; i <= inputNumber; i++) {
                sumOfNNumber = sumOfNNumber +i;
            }
            return sumOfNNumber;
        }

    }
        
}
