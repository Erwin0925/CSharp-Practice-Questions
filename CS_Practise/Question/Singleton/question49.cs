namespace CS_Practise.Question.Singleton
{
    internal class question49
    {
        private static question49? _instance;

        private static object _lock = new object();

        private List<int> nums;

        private question49()
        {
            nums = new List<int>();
        }

        public static question49 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new question49();
                        }
                    }
                }
                return _instance;
            }
        }

        public void AddData(int value)
        {
            nums.Add(value);
        }

        public void DisplayData()
        {
            foreach (var item in nums)
            {
                Console.Write(item.ToString());
            }
        }
    }
}
