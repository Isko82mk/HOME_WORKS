using System;

namespace Ex._2_StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = { "joe", "vanesa", "bob", "steven" };
            string[] studentsG2 = { "mike", "joane", "luke", "david" };


            Console.WriteLine("Enter student group: ( there are 1 and 2)");

            string userImput = Convert.ToString(Console.ReadLine());

            if (userImput == "1")
            {
                Console.WriteLine($"The Students in G1 are:");
                foreach (string student1 in studentsG1)
                {

                    //Console.WriteLine($"{student1}");

                    Console.WriteLine(char.ToUpper(student1[0]) + student1.Substring(1));

                }

            }
            else
            {
                Console.WriteLine($"The Students in G2 are:");
                foreach (string student2 in studentsG2)
                {
                    //Console.WriteLine($" {student2}");

                    Console.WriteLine(char.ToUpper(student2[0]) + student2.Substring(1));



                }

            }


            Console.ReadLine();







        }
    }
}
