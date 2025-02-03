namespace SOLIDPrinciples
{
    public class NotificationService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Enviando Email a {email}: {message}");
        }
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
        }
    }
}
