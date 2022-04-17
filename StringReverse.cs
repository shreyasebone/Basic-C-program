using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    public class StringReverse {
        public string returnReverseString(string inputString) {
            string reverse = "";
            for (int i = inputString.Length - 1; i >= 0; i--) {
                reverse = reverse + inputString[i];
            }
            return reverse;
        }
        
    }
}
