using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class StringAnagram{
        public bool isAnagram(string firstString, string secondString) {
            bool flag = false;
            char [] character = firstString.ToLower().ToCharArray();
            char [] character2 = secondString.ToLower().ToCharArray();
            Array.Sort(character);
            Array.Sort (character2);
            for (int i = 0; i < character.Length; i++) {
                if (character[i] != character2[i]) {
                   flag = false;
                }
                else {
                    flag = true;
                }
            }
            return flag;
        }
    //static void Main(string[] args) {
    //    StringAnagram stringAnagram=new StringAnagram();  
    //    Console.WriteLine("enter first String");
    //    string firstString=Console.ReadLine();
    //    Console.WriteLine("enter Second String");
    //    string secondString=Console.ReadLine();
    //    bool result=stringAnagram.isAnagram(firstString, secondString); 
    //    Console.WriteLine(result);
    //    }

    }
}
