public class Writing : Assignment
{
    private string _title;

    public Writing(string name, string topic, string title)
        : base(name, topic)
    {
        // Here we set any variables specific to the WritingAssignment class
        _title = title;
    }

    public string WritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string name = GetName();

        return $"{_title} by {name}";
    }
}