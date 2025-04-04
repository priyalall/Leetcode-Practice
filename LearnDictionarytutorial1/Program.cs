using System;
namespace LearnDictionaryTutorial
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(102, "Amara");
            students.Add(103, "Rahul");
            students.Add(104, "Kia");
            Console.WriteLine( "Student List :");

            foreach (var student in students) 
            {
                Console.WriteLine($"ID: {student.Key} ,Name :{student.Value}");
            }




        }
    }
}