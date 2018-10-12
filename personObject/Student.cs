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
            return (this.subjectOneMark + this.subjectTwoMark + this.subjectThreeMark)/3;
        }
        public override string sendMessage(string message)
        {
            var orginal = base.sendMessage(message);
            var sb = new StringBuilder(orginal);
            sb.AppendLine(" ");
            sb.AppendLine("You are recieving this email because you consented to recieve marketing emails");
            return sb.ToString();
        }
        

     
    }
}
