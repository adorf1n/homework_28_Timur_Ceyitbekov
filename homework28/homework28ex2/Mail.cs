using System;

public class Mail
{
    public void OnNewMessage(object sender, MyMessage msg)
    {
        if (msg.MessageType == "email")
        {
            Console.WriteLine($"Получил письмо {msg.Message}");
        }
    }
}
