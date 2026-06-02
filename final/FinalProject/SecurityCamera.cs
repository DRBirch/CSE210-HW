public class SecurityCamera : Device
{
    private bool _isRecording;

    public SecurityCamera()
    {
        _name = "Security Camera";
    }

    public void StartRecording()
    {
        _isRecording = true;
    }

    public void StopRecording()
    {
        _isRecording = false;
    }

    public override void DisplayStatus()
{
    Console.WriteLine($"Device: {_name}");
    Console.WriteLine($"Recording: {_isRecording}");
    Console.WriteLine();
}
}