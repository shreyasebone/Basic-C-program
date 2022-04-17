using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3{
    public class PrimeNumber{
        public bool isPrimeNumber(int number){
            bool flag = true;
            if (number <2){
                flag = false;
            }
            for(int i = 2; i < number / 2; i++){
                if(number % i == 0){
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        //static void Main(string[] args){
        //    PrimeNumber primeNumber = new PrimeNumber();
          //  Console.WriteLine("enter the number");
            //int number = Convert.ToInt32(Console.ReadLine());
          //  bool isPrimeNumber = primeNumber.isPrimeNumber(number);
            //if (isPrimeNumber){
              //  Console.WriteLine(number +" Given number is prime number ");
           // }else{
             //   Console.WriteLine(number +" Given number is not prime number");
           // }

       // }
    }
}
