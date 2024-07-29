using System;

class Program
{
    public delegate string GetStatusDelegate();

    static void Main(string[] args)
    {
        Lamp lamp = new Lamp { TurnedOn = true };
        Cat cat = new Cat();
        Man man = new Man();

        GetStatusDelegate lampStatus = lamp.GetLampStatus;
        GetStatusDelegate catStatus = cat.WhatIdDoingNow;
        GetStatusDelegate manStatus = man.WhatHeIsDoingNow;

        ReadState(lampStatus);
        ReadState(catStatus);
        ReadState(manStatus);
    }

    public static void ReadState(GetStatusDelegate getStatus)
    {
        Console.WriteLine(getStatus());
    }
}
