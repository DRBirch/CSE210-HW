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
}