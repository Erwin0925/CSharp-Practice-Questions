// 1. Write a program in C# Sharp to declare a simple structure.
// Expected Output: The sum of x and y is 40 


namespace CS_Practise.Question.Struct
{

    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int PointSum(int x, int y)
        {
            return x + y;
        }
    }
    internal class question40
    {
        public void getSum()
        {
            Point point = new Point();
            point.x = 2;
            point.y = 3;
            var sum = point.PointSum(4, 6);

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine();

        }
    }
}
