using static assignment.person;
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
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.
            person[] people = new person[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"enter person number {i + 1} data :");
                Console.WriteLine($"his name :");                                       
                string name = Console.ReadLine();
                Console.WriteLine($"his age :");
                int age = int.Parse(Console.ReadLine());
                people[i] = new person(age, name);
            }
            person people2 = new person();
            people2.displayAllObjects(people);
        }
    }
}
