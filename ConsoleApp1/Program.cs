using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            // Student name: Amanjeet singh bajwa Student-id = c0731712
            //CSD3354 section 2
            // Assignment 2
            // March 6, 2019

            DelegateExcercises a = new DelegateExcercises();
            a.Method3();
            Console.ReadLine();
        }
    }
   
       public class DelegateExcercises
        { 
            public delegate int  MyDelegate(int intValue);
            public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
    
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);

            }
        }
         
}
