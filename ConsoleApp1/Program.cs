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

            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {

            System.Console.WriteLine(MyDelegate.ToString());
        }
    }


}
}