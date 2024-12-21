// Mapping Student Names to IDs
// Write a program that uses a Dictionary to store student IDs (as keys) and their names (as values). Perform the following tasks:
// Add three students with their IDs and names to the dictionary.
// Retrieve and display the name of a student using their ID.
// Check if a particular student ID exists in the dictionary.

namespace CS_Practise.Question.Dictionary
{
    public class Student
    {
        public required string Name { get; set; }
        public int Id { get; set; }
    }

    public class question43
    {
        public void Dictionary()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            // Add three students with their IDs and names to the dictionary
            students.Add(1, new Student { Id = 1, Name = "Peter" });
            students.Add(2, new Student { Id = 2, Name = "Mary" });
            students.Add(3, new Student { Id = 3, Name = "John" });

            // Retrieve and display the name of a student using their ID
            int idToRetrieve = 2;
            if (students.TryGetValue(idToRetrieve, out Student student))
            {
                Console.WriteLine($"Student with ID {idToRetrieve}: {student.Name}");
            }
            else
            {
                Console.WriteLine($"Student with ID {idToRetrieve} not found.");
            }

            // Check if a particular student ID exists in the dictionary
            int idToCheck = 3;
            if (students.ContainsKey(idToCheck))
            {
                Console.WriteLine($"Student with ID {idToCheck} exists in the dictionary.");
            }
            else
            {
                Console.WriteLine($"Student with ID {idToCheck} does not exist in the dictionary.");
            }

            // Display all records
            Console.WriteLine("All student records:");
            foreach (var entry in students)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value.Name}");
            }
        }
    }
}
