using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {



            Assert("HelloWorld() should say 'Hello World!'", Exercises.HelloWorld() == "Hello World!");
            Assert("SayHello() should say 'Hello {your name}!'", Exercises.SayHello("Giovanni") == "Hello Giovanni!");
            Assert("Sum() should return the sum of {num1 + num2}", Exercises.Sum(5, 7) == 12);
            Assert("Divide() should return {num1/num2}", Exercises.Divide(16.0m, 2.0m) == 8.0m);
            Assert("CanOpenCheckingAccount() should return true if input>18 and false if input<18", Exercises.CanOpenCheckingAccount(19) == true);
            Assert("GetFirstName() should return first name", Exercises.GetFirstName("Cam Carson") == "Cam");
            Assert("ReverStringHard() should reverse a string", Exercises.ReverseStringHard("Hello") == "olleH");
            Assert("ReverseStringEasy() should reverse a string", Exercises.ReverseStringEasy("Hello Gio") == "oiG olleH");
            Assert("PrintTimesTable() should return a string of a table",Exercises.PrintTimesTable(9)== Constants.TimesTableFor9);
            Assert("ConvertKelvinToFahrenheit() should return a fahrenheit int", Exercises.ConvertKelvinToFahrenheit(273.15)== 32);
            Assert("GetAverageHard() should return 3", Exercises.GetAverageHard(new int[] { 2, 3, 5, 2 }) == 3);
            Assert("GetAverageEasy() should return 3", Exercises.GetAverageEasy(new int[] { 2, 3, 5, 2 }) == 3);
            Assert("DrawnTriangle() should return a triangle of integers", Exercises.DrawnTriangle(8, 5)== Constants.TriangleFor8and5);
            Assert("GetMilesPerHour() should return 100MPH in this case", Exercises.GetMilesPerHour(150, 1, 30, 0)=="100MPH");
            Assert("IsVowel() should return false for letter n  ", Exercises.IsVowel('n')== false);
            Assert("IsVowel() should return true for letter e  ", Exercises.IsVowel('e')==true);
            Assert("IsConsonant() should return false for letter e", Exercises.IsConsonant('e')==false);
            Assert("IsConsonant() should return true for letter n", Exercises.IsConsonant('n')== true);

           

            // Assert("",);

            



            Console.ReadLine();






            //Person[] people = new Person[4];

            //people[0] = new Person { Id = 1, FirstName = "Blaine" };
            //people[1] = new Person { Id = 2, FirstName = "Cameron" };
            //people[2] = new Person { Id = 3, FirstName = "Jennifer" };
            //people[3] = new Person { Id = 4, FirstName = "Ryan" };

            //Console.WriteLine("Length of array: {0}", people.Length);

            //int id = 2;

            //// Grab the person to delete from the list
            //foreach (var person in people)
            //{
            //    if (person.Id == 2)
            //    {
            //        // people.Remove(person);
            //        break;
            //    }
            //}



        }


        static void Assert(string exerciseName, bool condition)
        {
            if (condition)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[PASS] - {exerciseName}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] - {exerciseName}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
    class Person
    {
        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
    }
}
