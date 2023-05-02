using System;

namespace BasicCSharp.OOP
{
    internal class Student
    {
        private string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string major { get; set; }
        public double midtermGrade { get; set; }
        public double finalGrade { get; set; }
        public double assignmentGrade { get; set; }
        public double averageGrade { get; set; }
        private string status { get; set; }
        //Id, name, age, gender,major, midterm grade, final grade, assignment grade,average grade, status.
        public void GetId()
        {
            id = "GCD201888";
            Console.WriteLine($"id: {id}");
        }
        public void GetStudent()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Major: {major}");
            Console.WriteLine($"Midterm grade: {midtermGrade}");
            Console.WriteLine($"Final grade: {finalGrade}");
            Console.WriteLine($"Assignment grade: {assignmentGrade}");
        }
        public double CalculateAverageGrade()
        {
            averageGrade = (assignmentGrade + midtermGrade * 2 + finalGrade * 3) / 6;
            Console.WriteLine($"Average grade: {averageGrade}");
            return averageGrade;
        }
        public string SetStatus()
        {
            if (averageGrade >= 5)
            {
                status = "Passed";
            }
            else
            {
                status = "Falied";
            }
            Console.WriteLine($"Status: {status}");
            return status;
        }
    }
    public class File1
    {
        public static void File1Main()
        {
            Student student1 = new Student();
            student1.GetId();
            student1.name = "Tran Bao Nguyen";
            student1.age = 19;
            student1.gender = "Male";
            student1.major = "IT";
            student1.midtermGrade = 6;
            student1.finalGrade = 7;
            student1.assignmentGrade = 8;
            student1.GetStudent();
            student1.CalculateAverageGrade();
            student1.SetStatus();
            Console.ReadLine();
        }
    }
}