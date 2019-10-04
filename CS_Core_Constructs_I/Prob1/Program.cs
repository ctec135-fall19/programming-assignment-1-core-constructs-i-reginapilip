/*
Author: Regina Pilipchuk
Date:   10.3.2019
CTEC 135: Microsoft Software Development with C#

CS_Core_Constructs_I

Module 2, Programming Assignment 1, Problem 1

Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 = ???
    page 71 = Ch.3 "System Data Types and Corresponding C# Keywords >>
                        Intrinsic Data Types & new Operator

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.

* region 2: variable initialization

    page 68 = 
    page 78 = "System Data Types..." >> Digit Separators
    page 66-67 = 

    The table on page 68 shows a number of numeric types.

    In this section declare separate variables for each numeric type that is CLS 
    compliant and initialize it to some value non-zero value. Review the section 
    on "Digit Separators" on p. 78 that shows different ways of formatting numeric 
    literals that make them more readable. Try using some of these.

    Follow the section used to declare the variables with a code section that 
    prints the values of each variable to the terminal. Try using format specifiers 
    discussed on pages 66-67.

* region 3: Max/Min Values

    Open the documentation page on the System namespace 
    (https://docs.microsoft.com/en-us/dotnet/api/system?view=netframework-4.7.1) 
    (Links to an external site.).

    Scroll down until you find any one of the numeric types and click on the type. 
    Expand the Fields part of the description. You should see that a MaxValue and 
    a MinValue are defined.

    In this last section print the min and max values to the terminal screen. 
    Use descriptive text in your print statements to provide context for the reader.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations
            // declare three different double variables using each of the three
            // type declarations
            double myDouble = 1.0;
            System.Double myDouble2 = 2.0;
            double d = new double();
            #endregion

            #region variable initialization
            // declare separate variables for each numeric type that is CLS 
            // compliant and initialize it to some value non-zero value (11)

            // define variables and set them to a non-zero value
            bool myBool = true;
            byte myByte = 254;
            short myShort = 14;
            int myInt = 2;
            long myLong = 4;
            char myChar = "cat"[0];
            float myFloat = 10.4F;
            double myNewDouble = 6.2;
            decimal myDecimal = 10.9m;
            string myStr = "here's a string";
            Object myObj = "string object";

            #region trying digit separators
            // code from textbook page 78, pasted to see how these work
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);
            #endregion

            // blank line
            Console.WriteLine();
            // the following code prints the values of the previously defined
            // variables
            Console.WriteLine("GROUP ONE: \nBool = {0}\nByte = {1}\nShort = {2}",
                myBool,myByte,myShort);
            Console.WriteLine("\nGROUP TWO: \nInt = {0}\nLong = {1}\nChar = {2}",
                myInt, myLong, myChar);
            Console.WriteLine("\nGROUP THREE: \nFloat = {0}\nDouble = {1}\nDecimal = {2}",
                myFloat, myNewDouble, myDecimal);
            Console.WriteLine("\nGROUP FOUR: \nString = {0}\nObject = {1}",
                myStr, myObj);
            #endregion

            #region min/max values
            // blank line
            Console.WriteLine();
            // print the min and max values to the terminal screen. 
            // Use descriptive text in your print statements to provide context 
            // for the reader

            // MinValue
            Console.WriteLine("=> A Double Struct represents a double-precision floating point " +
                "number (Microsoft Documentation)");
            Console.WriteLine("A Double's Min. Value is: {0}",Double.MinValue);
            // MaxValue
            Console.WriteLine("A Double's Max. Value is: {0}\n",Double.MaxValue);
            #endregion
        }
    }
}
