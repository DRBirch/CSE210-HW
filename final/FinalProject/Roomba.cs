public class Roomba : Device
{
    private bool _isCleaning;

    public Roomba()
    {
        _name = "Roomba";
    }

    public void StartCleaning()
    {
        _isCleaning = true;
    }

    public void ReturnHome()
    {
        _isCleaning = false;
    }
}