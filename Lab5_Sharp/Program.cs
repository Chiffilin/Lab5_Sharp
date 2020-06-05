using System;
using System.Collections.Generic;

namespace Lab5_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            list.Add(new Student("Ли В.С.","Физика"));
            list.Add(new Teacher("Василенко О.В.", "Физика"));
            list.Add(new Zavkaf("Григорьев В.А.","Физика"));
            foreach (var item in list) Console.WriteLine(item);
            Console.ReadLine();

        }
    }
   abstract class Person 
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public Person(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }
        public override string ToString()
        {
            return "Инфо: " + Name + "||" ;
        }

    }
    
    class Student : Person
    {
        public Student(string name, string subject) : base(name, subject)
        {
        }
        public override string ToString()
        {
            return base.ToString() + "Студент";
        }
    }
    
    class Teacher : Person
    {
        public string TeacherName { get; set; }
        public Teacher(string name,string subject) : base(name,subject)
        {
            //TeacherName = teachername;
        }
        public override string ToString()
        {
            return base.ToString() + "Преподает: " + Subject;
        }
    }

    class Zavkaf : Person
    {
        public string ZavkafName { get; set; }
        public Zavkaf(string name, string subject ) : base(name,subject)
        {
        }
        public override string ToString()
        {
            return base.ToString() + "Зав.Кафедры: " + Subject;
        }
    }
}
