using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    #region struct person 
    //public struct person
    //{
    //    private int age;
    //    private string name;
    //    //public string Name
    //    //{
    //    //    get { return name; }   // Getter
    //    //    set { name = value; }  // Setter
    //    //}
    //    //public int Age
    //    //{
    //    //    get { return age; }    // Getter
    //    //    set
    //    //    {
    //    //        if (value >= 0)    // Example validation
    //    //            age = value;
    //    //    }
    //    //}
    //    public person(int AGE, string NAME)
    //    {
    //        age = AGE;
    //        name = NAME;
    //    }
    //    public void displayAllObjects(person[] people)
    //    {
    //        foreach (person person in people)
    //        {
    //            Console.WriteLine(person.name + " " + person.age);
    //        }
    //    }



    //} 
    #endregion
    #region point 
    public struct point
    {
        private double X;
        private double Y;
        public point (double x , double y )
        {
            X = x;
            Y = y;
        }
        public static double distance( point p1 , point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            Console.WriteLine("result is :");
            return Math.Sqrt((dx * dx) + (dy * dy));

        }

    }
    #endregion






}
