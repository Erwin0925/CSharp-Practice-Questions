//create and access nested object array

using System.Collections;

namespace CS_Practise.Question.ArrayObject
{
    public class question20
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

        public IEnumerable<int> FlattenArray(object array)
        {
            if (array is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    foreach (var subitem in FlattenArray(item))
                    {
                        yield return subitem;
                    }
                }
            }
            else if (array is int num)
            {
                yield return num;
            }
        }
    }
}

//FlattenArray([[[[1, 2], [3, 4, [5, 6]]]]])
//  ? FlattenArray([[[1, 2], [3, 4, [5, 6]]]])
//      ? FlattenArray([[1, 2], [3, 4, [5, 6]]])
//          ? FlattenArray([1, 2])  ? yields 1, 2
//          ? FlattenArray([3, 4, [5, 6]])
//              ? yields 3, 4
//              ? FlattenArray([5, 6]) ? yields 5, 6
