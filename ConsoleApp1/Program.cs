using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {
         public static void Main()
        {
           
            // Student name: Amanjeet singh bajwa Student-id = c0731712
            //CSD3354 section 2
            // Assignment 2
            // March 6, 2019

            DelegateExercises delegateExercises = new DelegateExercises();
            try
            {
                delegateExercises.Method3();
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Exception Occured.");
                Console.ReadLine();
            }
        }
    }
    public delegate int MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            throw new System.Exception();
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate2();
    }






}