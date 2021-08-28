using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
