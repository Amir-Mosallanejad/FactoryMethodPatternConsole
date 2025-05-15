public class PushNotification : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification: {message}");
    }
}
