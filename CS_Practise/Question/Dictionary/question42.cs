// Mapping Student Names to IDs
// Write a program that uses a Dictionary to store student IDs (as keys) and their names (as values). Perform the following tasks:
// Add three students with their IDs and names to the dictionary.
// Retrieve and display the name of a student using their ID.
// Check if a particular student ID exists in the dictionary.

namespace CS_Practise.Question.Dictionary
{
    internal class question42
    {
        public void Dictionary()
        {
            var students = new Dictionary<int, String>();
            students.Add(1, "John");
            students.Add(2, "Mary");
            students.Add(3, "Peter");

            Console.WriteLine(students[2]);

            foreach (var student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }

            if (students.ContainsKey(2))
            {
                Console.WriteLine(students[2]);
            }
            else
            {
                Console.WriteLine("Not Applicable");
            }
        }
    }
}
