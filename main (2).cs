/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    float M,finalTemperature,initialTemperature; 
        
        
         Console.Write("Enter te amount of water in kilograms :");
         M =Convert.ToSingle(Console.ReadLine());
       
        Console.Write("Enter the initial temperature : ");
        initialTemperature= Convert.ToSingle(Console.ReadLine());
         
         Console.Write("Enter the final Temperature  :");
         finalTemperature = Convert.ToSingle(Console.ReadLine());
         
      float Q= M* (finalTemperature-initialTemperature)* 4184;
         
         Console.WriteLine("The energy needed is " + Q);
  }
}