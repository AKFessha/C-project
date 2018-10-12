using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    public abstract class Person
    {
        private String firstName;
        private String lastName;
        private String email;
        private int age;

        public abstract float GradeAverage();

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getFirstName()
        {
            return firstName; 
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return email;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public virtual string sendMessage(string message)
        {
            // we use the string builder class to manipulate strings. 
            var sb = new StringBuilder();
            // string.Format() is a static method that returns a formatted string
            var timestamp = string.Format("Sent on{0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timestamp);
            sb.AppendLine(" ");
            sb.AppendLine(" Dear " + firstName + ",");
            sb.AppendLine(message);
            return sb.ToString();

        }

    }
}
