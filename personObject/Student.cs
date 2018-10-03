using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    class Student: Person
    {
        public int subjectOneMark;
        public int subjectTwoMark;
        public int subjectThreeMark;
        public override float GradeAverage()
        {
            //Just to test; fix the implementation later
            return (this.subjectOneMark + this.subjectTwoMark + this.subjectThreeMark)/3;
        }
        

     
    }
}
