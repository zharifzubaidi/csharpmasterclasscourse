using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class Student
    {
        // best practice is to create a new files
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        // simple custom constructor
        public Student(int id, string name, float GPA)
        {
            // This refers to the class properties instead of parameters of the same name
            // This refers to the current instance of the Student class
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
