using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    public class TwoSumProblem {
        public bool twoSum(int[] inputArray, int targetNumber) {
            bool flag = false;
            //int[] outputArray = new int[2];
            for (int i = 0; i < inputArray.Length; i++) {
                for (int j = i + 1; j < inputArray.Length; j++) {
                    if ((inputArray[j] + inputArray[i]) == targetNumber) {
                        flag = true;
                        //outputArray[i] = inputArray[i];
                        //outputArray[j] = inputArray[j];
                    }
                }
            }
            return flag;
        }
    }
}
