public class Alarm : Device
{
    private bool _isActive;

    public Alarm()
    {
        _name = "Alarm";
    }

    public void AlarmOn()
    {
        _isActive = true;
    }

    public void AlarmOff()
    {
        _isActive = false;
    }
    public override void DisplayStatus()
    {
        Console.WriteLine($"Device: {_name}");
        Console.WriteLine($"Status: {_isActive}");
    }
}