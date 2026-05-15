public class MathHW : Assignment
{
    private string _section;
    private string _problems;

    public MathHW(string name, string topic, string section, string problems)
        : base(name, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"Section {_section} Problems {_problems}";
    }
}