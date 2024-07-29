using System;

public class MessageManager
{
    public event EventHandler<MyMessage> NewMessage;

    public void SendMessage(MyMessage message)
    {
        NewMessage?.Invoke(this, message);
    }
}
