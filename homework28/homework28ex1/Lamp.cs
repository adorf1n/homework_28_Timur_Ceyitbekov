public class Lamp
{
    public bool TurnedOn { get; set; }

    public string GetLampStatus()
    {
        return TurnedOn ? "The lamp is on." : "The lamp is off.";
    }
}
