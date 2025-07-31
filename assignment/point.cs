using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    #region struct person 
    public struct person
    {
        private int age;
        private string name;
        //public string Name
        //{
        //    get { return name; }   // Getter
        //    set { name = value; }  // Setter
        //}
        //public int Age
        //{
        //    get { return age; }    // Getter
        //    set
        //    {
        //        if (value >= 0)    // Example validation
        //            age = value;
        //    }
        //}
        public person(int AGE, string NAME)
        {
            age = AGE;
            name = NAME;
        }
        public void displayAllObjects(person[] people)
        {
            foreach (person person in people)
            {
                Console.WriteLine(person.name + " " + person.age);
            }
        }

        

    } 
    #endregion





}
