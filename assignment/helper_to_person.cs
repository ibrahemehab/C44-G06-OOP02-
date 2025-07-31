using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class helper_to_person
    {
        public static string Olderperson(Person[] people)
        {
            Person maximum = new Person();
            maximum.Age = int.MinValue;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age > maximum.Age)
                {
                    maximum = people[i];
                }
            }
            return maximum.Name + " " + maximum.Age;
        }
    }
}
