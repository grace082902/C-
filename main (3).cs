/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      double weight,height,BMI;
    
     Console.Write("Enter weight in pounds :");
         weight =Convert.ToDouble(Console.ReadLine());
     Console.Write("Enter height ininches :");
         height =Convert.ToDouble(Console.ReadLine());
     
      BMI = (weight * 0.45359237) / ((height * 0.0254) * (height * 0.0254));
      
       Console.WriteLine("BMI is " + BMI);
  }
}