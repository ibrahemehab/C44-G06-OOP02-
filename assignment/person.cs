using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
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
    //public struct Point
    //{
    //    private double x;
    //    private double y;
    //    public Point (double x , double y )
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //    public  double Distance( Point other)
    //    {
    //        double dx = x - other.x;
    //        double dy = y - other.y;
    //        return Math.Sqrt((dx * dx) + (dy * dy));

    //    }

    //}
    #endregion
    #region 
    public struct Person
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {

                if (value <= 0) throw new Exception("invalid age");
                age = value;
            }
        }
        public Person(int age , string name)
        {
            Age = age;
            Name = name;
        }
    }
    #endregion






}
