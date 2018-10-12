using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    class Lecturers: Person
    {
        public override float GradeAverage()
        {
            return 0.0f;
        }

        public override string sendMessage(string message)
        {
            var original = base.sendMessage(message);
            var sb = new StringBuilder(original);
            // Let's say that our legal department at our school has gotten involved and we need to add some sort of disclaimer to all messages sent to students.
            sb.AppendLine("");
            sb.AppendLine("This message is private and confidential");
            return sb.ToString();
        }


    }
}
