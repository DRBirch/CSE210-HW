public class Light : Device
{
    private int _brightness;

    public Light()
    {
        _name = "Light";
        _brightness = 0;
    }

    public void AdjustBrightness(int level)
    {
        _brightness = level;
    }

    public override void DisplayStatus()
{
    Console.WriteLine($"Device: {_name}");
    Console.WriteLine($"Brightness: {_brightness}");
    Console.WriteLine();
}
}