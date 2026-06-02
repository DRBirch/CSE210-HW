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
}