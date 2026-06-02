public class DoorLock : Device
{
    private bool _isLocked;

    public DoorLock()
    {
        _name = "Door Lock";
    }

    public void LockDoor()
    {
        _isLocked = true;
    }

    public void UnlockDoor()
    {
        _isLocked = false;
    }
    
    public override void DisplayStatus()
{
    Console.WriteLine($"Device: {_name}");
    Console.WriteLine($"Locked: {_isLocked}");
    Console.WriteLine();
}
}