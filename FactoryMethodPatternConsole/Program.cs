Console.WriteLine("Factory Method Pattern");

var factory = new NotificationFactory();

INotificationService notification = factory.Create("email");
notification.Send("Welcome to our service!");

notification = factory.Create("sms");
notification.Send("Your OTP is 123456");

notification = factory.Create("push");
notification.Send("You have a new message!");

Console.ReadKey();