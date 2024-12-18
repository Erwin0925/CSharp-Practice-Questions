//create and access nested object array

using System.Collections;

namespace CS_Practise.Question
{
    public class question19
    {
        public void NestedArray()
        {
            var nestedarr = new object[]
            {
                new object[]
                {
                    new int[] {1,2,3},
                    new int[,] {{4,5,6},{7,8,9}},
                    new object[]
                    {
                        new int[] {10,11,12}
                    }
                }
            };

            var flattened = FlattenArray(nestedarr);
            //Console.WriteLine($"Flattened array: {string.Join(", ", flattened)}");
            foreach (var item in flattened)
            {
                Console.Write(item + " , ");
            }
        }

        private IEnumerable<int> FlattenArray(object input)
        {
            if (input is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    foreach (var subItem in FlattenArray(item))
                    {
                        yield return subItem;
                    }
                }
            }
            else if (input is int value)
            {
                yield return value;
            }
        }
    }
}