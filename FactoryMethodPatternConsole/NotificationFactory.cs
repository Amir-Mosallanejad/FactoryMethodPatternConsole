public class NotificationFactory
{
    public INotificationService Create(string channel)
    {
        return channel.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            "push" => new PushNotification(),
            _ => throw new ArgumentException("Unsupported notification channel", nameof(channel))
        };
    }
}