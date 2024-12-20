// Custom Object Sorting Create a Person class with Name and Age properties.
// Write a program to sort a List<Person>:
   // By Name in alphabetical order. 
   // By Age in descending order.

namespace CS_Practise.Question.Search_Sort
{
    public class Person
    {
        public required string name { get; set; }
        public int age { get; set; }
    }

    internal class question27
    {
        public void SortPerson()
        {
            List<Person> personlist = new List<Person>();
            personlist.Add(new Person { name = "Alice", age = 30 });
            personlist.Add(new Person { name = "Charlie", age = 25 });
            personlist.Add(new Person { name = "Bob", age = 35 });

            // Sort by Name in alphabetical order
            personlist.Sort((a, b) => String.Compare(a.name, b.name));
            Console.WriteLine("Sorted by Name:");
            foreach (var person in personlist)
            {
                Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            }

            //Sort by Age
            personlist.Sort((a,b) => a.age.CompareTo(b.age));
            Console.WriteLine("Sorted by Age:");
            foreach (var person in personlist)
            {
                Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            }

            //Sort by Name in alphabetical order
            for(int i = 0; i < personlist.Count-1 ; i++)
            {
                for (int j = 0; j < personlist.Count-i-1; j++)
                {
                    if (String.Compare(personlist[j].name, personlist[j+1].name) > 0)
                    {
                        (personlist[j].name, personlist[j + 1].name) = (personlist[j + 1].name, personlist[j].name);
                    }
                }
            }
            Console.WriteLine("Sorted by Name Manually:");
            foreach (var person in personlist)
            {
                Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            }

            //Sort by Age Manually
            for (int i = 0; i < personlist.Count -1 ; i++)
            {
                for (int j = 0; j < personlist.Count - i - 1; j++)
                {
                    if (personlist[j].age > personlist[j + 1].age)
                    {
                        (personlist[j].age, personlist[j + 1].age) = (personlist[j + 1].age, personlist[j].age);
                    }
                }
            }
            Console.WriteLine("Sorted by Age Manually:");
            foreach (var person in personlist)
            {
                Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            }
        }
    }
}
