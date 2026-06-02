public class Thermostat : Device
{
    private int _temperature;

    public Thermostat()
    {
        _name = "Thermostat";
        _temperature = 70;
    }

    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
    }

    public override void DisplayStatus()
{
    Console.WriteLine($"Device: {_name}");
    Console.WriteLine($"Temperature: {_temperature}");
    Console.WriteLine();
}
}