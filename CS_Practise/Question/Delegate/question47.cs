//Define a ProcessData method that accepts a delegate for logging purposes.
//Write a method LogToConsole that logs the processed data.
//Call ProcessData with a callback to log data to the console.

namespace CS_Practise.Question.Delegate
{
    internal class question47
    {
        public delegate void Callback (String userinfo);

        public void ProcessData(String userinfo, Callback callback)
        {
            string processedData = userinfo;
            callback (processedData);
        }

        public void LogToConsole(String userinfo)
        {
            Console.WriteLine("Welcome " + userinfo);
        }
        public void DelegatePrac()
        {
            ProcessData("John", LogToConsole);
        }
    }
}
