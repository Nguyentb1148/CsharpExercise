using System;

namespace BasicCSharp.Basic
{
    public class InputInformations
    {
        /*
       * Enter your name, age, email, weight, height, then print that information,
       * and include the index bmi=(weight (kg)/(height(cm))^2)* 10000,
       * and is in relationship or not (true/false)
       */
        public static void InputInformationsMain()
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            Console.Write("Enter your email: ");
            var email = Console.ReadLine();
            Console.Write("Enter youe age:");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter your height(cm): ");
            var height = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight(kg): ");
            var weight = int.Parse(Console.ReadLine());
            Console.Write("In a relationship (true/false): ");
            var isInRelationship = bool.Parse(Console.ReadLine());
            var bmi = (float)weight / (height * height) * 10000;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight (kg): " + weight );
            Console.WriteLine("height (cm) : " + height );
            Console.WriteLine("bmi : " + bmi );
            Console.WriteLine("In a Relationship "+ isInRelationship);
            Console.ReadKey();
        }
    }
}