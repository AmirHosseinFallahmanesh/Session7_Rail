using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetAge(12);
            student.SetName("amir");
            student.SetSurname("amiri");
            Console.WriteLine(student.GetUsername());
            student.SetPassword("A123465");
           
        }
    }
    public class Student
    {
       private string name;
       private string surname;
       private int age;
       private string username="a@a";
        private string password;

        public void SetPassword(string value)
        {
            password = value;
        }
        public string GetUsername()
        {
            return username;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetName()
        {
            return name;
        }

        public void SetSurname(string value)
        {
            surname = value;
        }

        public string GetSurname()
        {
            return surname;
        }


        public void SetAge(int value)
        {
            age = value;
        }
        public int GetAge()
        {
            return age;
        }

    }

}
