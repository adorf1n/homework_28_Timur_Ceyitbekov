using System;

class Program
{
    static void Main(string[] args)
    {
        MessageManager messageManager = new MessageManager();
        Phone phone = new Phone();
        Mail mail = new Mail();

        messageManager.NewMessage += phone.OnNewMessage;
        messageManager.NewMessage += mail.OnNewMessage;

        Console.WriteLine("Отправка сообщения");
        Console.Write("Введите тип сообщения: ");
        string type = Console.ReadLine();
        Console.Write("Введите сообщение: ");
        string message = Console.ReadLine();

        MyMessage myMessage = new MyMessage(type, message);
        Console.WriteLine("\nПолучатель:");
        messageManager.SendMessage(myMessage);
    }
}
