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
        public virtual string sendMessage(string text)
        {
            return text;
        }

    }
}
