// create and access object array
namespace CS_Practise.Question
{
    public class question20
    {
        public void ObjectArray()
        {
            var objarr = new object[]
            {
                1,
                "John",
                3.14,
                new int[] {1,2,3},
                new {Name = "mary", Age = 23}
            };

            Console.WriteLine(objarr[0]);
            Console.WriteLine(objarr[1]);
            Console.WriteLine(objarr[2]);
            if (objarr[3] is int[] intArray)
            {
                foreach (var item in intArray)
                {
                    Console.WriteLine(item);
                }
            }
            dynamic person = objarr[4];
            Console.WriteLine($"Name: {person.Name} | Age: {person.Age}");
            
        }
    }
}