using System;

namespace BasicCSharp.Basic
{
    public class File3
    {
        public static void File3Main()
        {
            string name,email;
            int age, height, weight;
            float bmi;
            bool isInRelationship;
            Console.Write("Enter your name:");
            name= Console.ReadLine();
            Console.Write("Enter your email: ");
            email= Console.ReadLine();
            Console.Write("Enter youe age:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter your height(cm): ");
            height= int.Parse(Console.ReadLine());
            Console.Write("Enter your weight(kg): ");
            weight= int.Parse(Console.ReadLine());
            Console.Write("In a relationship (true/false): ");
            isInRelationship = bool.Parse(Console.ReadLine());
            bmi=(float)weight / (height * height) * 10000;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight (kg): " + weight );
            Console.WriteLine("height (cm) : " + height );
            Console.WriteLine("bmi : " + bmi );
            Console.WriteLine("In a Relationship "+ isInRelationship);
            Console.ReadKey();
        }
    }
}