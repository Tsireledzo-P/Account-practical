// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;

class Firstclass
{
    static void Main()
    {
        bool f = false;
        while (!f)
        {
            System.Console.WriteLine("Enter your mark :");
            String marks = System.Console.ReadLine();

            int mark = Convert.ToInt32(marks);

            if (mark >= 75)
            {
                Console.WriteLine("Your mark is {0}, You have passed with a distiction", mark);
            }

            else if (mark >= 50)
            {
                Console.WriteLine("Your mark is {0}, you have passed", mark);
            }

            else if (mark >= 40)
            {
                Console.WriteLine("Your mark is {0}, you have sub", mark);
            }

            else if(mark<=39)
                    {
                Console.WriteLine("Your mark is {0}, you have failed", mark);
                    }
            if(mark == 0)
            {
                break;
            }
        }

    }

    }

// create a program that tells the student if they passed with a distintion, passed or failed.
// make your program repetitive
// break code at the end