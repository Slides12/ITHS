using öv5.Classes;
using öv5.Interface;

INotifier notifier = new SlackNotifier(new SmsNotifier(new EmailNotifier()));
notifier.Send("System update completed!");