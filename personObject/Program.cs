using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] list_of_students = new Student[2];
            ArrayList studentList = new ArrayList();
            Lecturers[] list_of_lecturers = new Lecturers[2];
           
            Student student1 = new Student();
            student1.setFirstName("Awet");
            student1.setLastName("Fessha");
            student1.setEmail("awet@gmail.com");
            student1.setAge(25);
            student1.subjectOneMark = 86;
            student1.subjectTwoMark = 80;
            student1.subjectThreeMark = 90;

            

            Student student2 = new Student();
            student2.setFirstName("Ismaiel");
            student2.setLastName("Adam");
            student2.setEmail("Ismaiel@gmail.com");
            student2.setAge(25);

            list_of_students[0] = student1;
            list_of_students[1] = student2;
            studentList.Add(student1);
            studentList.Add(student2);
            
            foreach(Student i in studentList)
            {
                Console.WriteLine(i.getFirstName() + " " + i.getLastName());
            }

            Lecturers lecturer1 = new Lecturers();
            lecturer1.setFirstName("Paul");
            lecturer1.setLastName("Dorman");
            lecturer1.setEmail("paul@yahoo.com");
            lecturer1.setAge(45);

            Lecturers lecturer2 = new Lecturers();
            lecturer2.setFirstName("Angeline");
            lecturer2.setLastName("Nesbitt");
            lecturer2.setEmail("angeline@yahoo.com");
            lecturer2.setAge(45);

            list_of_lecturers[0] = lecturer1;
            list_of_lecturers[1] = lecturer2;

            Lecturers paul = new Lecturers();
            paul.setFirstName("Paul");
           
            Lecturers mahmood = new Lecturers();
            mahmood.setFirstName("Mahmood");
            Lecturers Andrea = new Lecturers();
            Andrea.setFirstName("Andrea");

            Stack listLecturers = new Stack();
            listLecturers.Push(paul);
            listLecturers.Push(Andrea);
            listLecturers.Push(mahmood);

            listLecturers.Pop();

            if (listLecturers.Contains(mahmood))
            {
                Console.WriteLine(mahmood.sendMessage("I am not coming to class tomorrow"));
            }
            else if(listLecturers.Contains(Andrea))
            {
                Console.WriteLine(Andrea.sendMessage("Please let mahmood know that I'm not coming today."));
            }


            Console.WriteLine(student1.sendMessage("Student List"));
            for (int i=0; i< list_of_students.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + list_of_students[i].getFirstName() + " " + list_of_students[i].getLastName());
            }
            Console.WriteLine("===========================================");
            Console.WriteLine(student1.sendMessage("Lecturers List"));
            for (int i = 0; i < list_of_lecturers.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + list_of_lecturers[i].getFirstName() + " " + list_of_lecturers[i].getLastName());
            }
            

            Console.ReadLine();
            
        }
    }
}
