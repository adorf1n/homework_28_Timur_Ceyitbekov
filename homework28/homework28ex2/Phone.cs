using System;

public class Phone
{
    public void OnNewMessage(object sender, MyMessage msg)
    {
        if (msg.MessageType == "sms")
        {
            Console.WriteLine($"Получил смс {msg.Message}");
        }
    }
}
