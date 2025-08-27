using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_advanced04
{
    internal class Student :IComparable<Student>
    {
        public Student(int iD, string? name)
        {
            ID = iD;
            Name = name;
        }
        public Student()
        {
            
        }

        public int ID { get; set; } 
        public string? Name { get; set; }


        public override string ToString()
        {
            return $"ID => {ID}  name=> {Name}";
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1 ;

           return this.ID.CompareTo(other.ID);
        }
    }
}
