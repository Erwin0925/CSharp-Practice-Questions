namespace CS_Practise.Question.Singleton
{
    internal class Singleton
    {
        private static Singleton? _instance;

        private static readonly object _lock = new();

        private Singleton()
        {
            Console.WriteLine("Instance is created");
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public void DisplayMessage(string str)
        {
            Console.WriteLine(str);
        }
    }
}
