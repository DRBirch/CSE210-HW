using System;

public class Device
{
    protected string _name;
    protected bool _status;

    public void DisplayStatus()
    {
        Console.WriteLine($"Device: {_name}");
        Console.WriteLine($"Status: {_status}");
    }

    public void TurnOn()
    {
        _status = true;
    }

    public void TurnOff()
    {
        _status = false;
    }
}