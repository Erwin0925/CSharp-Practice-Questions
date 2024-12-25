//Define a delegate Notify that takes a string parameter.
    //SendEmail - Prints[Email] message.
    //SendSMS - Prints[SMS] message.
    //SendPushNotification - Prints[Push] message.
//Combine all three methods into a single multicast delegate and invoke it.

namespace CS_Practise.Question.Delegate
{
    internal class question46
    {
        public delegate void Notification(string message);

        public void SendNotification(string message)
        {
            Thread.Sleep(1000);
            System.Console.WriteLine("Push Notification :" + message);
        }

        public void SendEmail(string message)
        {
            Thread.Sleep(1000);
            System.Console.WriteLine("Email Notification :" + message);
        }

        public void SendSMS(string message)
        {
            Thread.Sleep(1000);
            System.Console.WriteLine("SMS Notification : " + message);
        }
        public void DelegatePrac()
        {
            Notification notification = SendNotification;
            notification += SendEmail;
            notification += SendSMS;
            notification("Please pay your bill");

            Notification notification2 = SendNotification;
            notification2 += SendEmail;
            notification2 += SendSMS;
            notification2 -= SendEmail;

            notification2("Please pay your electric bill");
        }
    }
}
