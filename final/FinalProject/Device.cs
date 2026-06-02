using System;

public class Device
{
    protected string _name;
    protected bool _status;

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device: {_name}");
        Console.WriteLine($"Status: {_status}");
        Console.WriteLine();
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