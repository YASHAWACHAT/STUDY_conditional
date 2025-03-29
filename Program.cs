using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
              // if 

  //Console.WriteLine("Enter the value of a is");
  //int a = int.Parse(Console.ReadLine());
  //Console.WriteLine("Enter the value of b is");
  //int b = int.Parse(Console.ReadLine());

  //if (a < b)
  //{
  //    Console.WriteLine("a is less than b");
  //}


  // if else 

  //Console.WriteLine("Enter the age of student ");
  //int age = int.Parse(Console.ReadLine());
  //if (age > 18)
  //{
  //    Console.WriteLine("you are eligible for driving");
  //}
  //else
  //{
  //    Console.WriteLine("you are not eligible for driving");
  //}


  // Else if

  //Console.WriteLine("Ener the temperature of today");
  //int temperature = int.Parse(Console.ReadLine());
  //if (temperature < 30)
  //{
  //    Console.WriteLine("temperature is normal");
  //}
  //else if (temperature > 45)
  //{
  //    Console.WriteLine("temperature is high");
  //}
  //else if(temperature>-0)
  //{
  //    Console.WriteLine("temperature is low");
  //}
  //else
  //{
  //    Console.WriteLine("temperature is minus");
  //}


  // nested if else

  //int marks1 = 67, marks2 = 45, marks3 = 78;
  //if (marks1 > marks2)
  //{
  //    if (marks1 < marks3)
  //    {
  //        Console.WriteLine("the output is "+marks1);
  //    }
  //    else
  //    {
  //        Console.WriteLine("the output is "+marks2);
  //    }

  //}
  //else
  //{
  //    if (marks2 > marks3)
  //    {
  //        Console.WriteLine("the output is "+marks2);
  //    }
  //    else
  //    {
  //        Console.WriteLine("the output is "+marks3);
  //    }
  //}

 // switch


  int condition;
  Console.WriteLine("1.check number is even or odd");
  Console.WriteLine("2.check number is positive or negative");
  Console.WriteLine("3.Find the Largest Number Among Three Numbers");
  Console.WriteLine("4.check whwther a character is vowels or constants");
  Console.WriteLine("5.check whether a year is leap year or not");
  Console.WriteLine("6.Check Whether a Character is an Alphabet or not");
  Console.WriteLine("7.swap to numbers");
  Console.WriteLine("\nEnter the condition");

  condition = int.Parse(Console.ReadLine());

  switch (condition)
  {
      case 1:
          int a;
          Console.WriteLine("enter a number");
          a = int.Parse(Console.ReadLine());
          if (a % 2 == 0)
          {
              Console.WriteLine("the number is even");
          }
          else
          {
              Console.WriteLine("the number is odd");
          }
          break;

      case 2:
          Console.WriteLine("enter a number which is positive or negative");
          int b = int.Parse(Console.ReadLine());
          if (b > 0)
          {
              Console.WriteLine("positive");
          }
          else
          {
              Console.WriteLine("negative");
          }
          break;

      case 3:
          int x = 30, y = 45, z = 60;
          if (x < y)
          {
              if (x > z)
              {
                  Console.WriteLine("the largest number is " + x);
              }
              else
              {
                  Console.WriteLine("the largest number is " + z);
              }
          }
          else
          {
              if (y > z)
              {
                  Console.WriteLine("the largest number is" + y);
              }
              else
              {
                  Console.WriteLine("the largest number is" + z);
              }
          }
          break;

      case 4:
          char c;
          Console.WriteLine("enter a character");
          c = char.Parse(Console.ReadLine());
          if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
          {
              Console.WriteLine("the character is vowels");
          }
          else
          {
              Console.WriteLine("the character is consonants");
          }
          break;

      case 5:
          Console.WriteLine("Enter a year: ");
          int year = int.Parse(Console.ReadLine());
          if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
          {
              Console.WriteLine($"{year} is a leap year.");
          }
          else
          {
              Console.WriteLine($"{year} is not a leap year.");
          }
          break;

      case 6:
          Console.WriteLine("Enter a character: ");
          char ch = char.Parse(Console.ReadLine());
          if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
          {
              Console.WriteLine("The character is an alphabet.");
          }
          break;

      default:
          Console.WriteLine("please enter correct condition");
          break;
  }

        }
    }
}
