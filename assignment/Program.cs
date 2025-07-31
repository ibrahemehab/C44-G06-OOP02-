using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Pipes;
using static assignment.Person;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region examples
            //Point point = new Point();
            //Console.WriteLine(point.x);
            //Point point2 = new Point(8);
            //Console.WriteLine(point2.x);
            //object obj = point;
            //Point2 point3 = new Point2();
            //point3.x = 66;
            //Console.WriteLine(point3.x); 
            #endregion
            #region q1
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.
            //person[] people = new person[3];
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"enter person number {i + 1} data :");
            //    Console.WriteLine($"his name :");                                       
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"his age :");
            //    int age = int.Parse(Console.ReadLine());
            //    people[i] = new person(age, name);
            //}
            //person people2 = new person();
            //people2.displayAllObjects(people); 
            #endregion
            #region q2
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
            //Write a C# program that takes two points as input from the user and calculates the 
            //distance between them.
            //Point[] points = new Point[2];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine($"enter point {i + 1} x then y ");
            //    double x = double.Parse(Console.ReadLine());
            //    double y = double.Parse(Console.ReadLine());
            //    points[i] = new Point(x, y);
            //}
            //double result = points[0].Distance(points[1]);
            //Console.WriteLine("result is :");
            //Console.WriteLine(result);
            #endregion
            #region q3
            //Create a struct called "Person" with properties "Name" and "Age". Write a C#
            //program that takes details of 3 persons as input from the user and displays the
            //name and age of the oldest person.
            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"enter person number {i+1} name then age :");
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                people[i] = new Person(age, name);
            }
            string result = helper_to_person.Olderperson(people);
            Console.WriteLine("older person is :");
            Console.WriteLine(result);
            #endregion
    }
    }
}
