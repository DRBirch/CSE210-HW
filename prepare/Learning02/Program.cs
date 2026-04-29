using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {        
        Job programmer = new Job();        
        programmer._company = "Microsoft";
        programmer._jobTitle = "Software Engineer";
        programmer._startYear = 2019;
        programmer._endYear = 2020;
        programmer.DisplayInformation();

        Job manager = new Job();
        manager._company = "Apple";
        manager._jobTitle = "Manager";
        manager._startYear = 2022;
        manager._endYear = 2023;
        manager.DisplayInformation();

        Resume myResume = new Resume();
        myResume._jobs.Add(programmer);
        myResume._jobs.Add(manager);
        myResume._jobs[0]._jobTitle
    }
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;        
        public int _endYear;

        public void DisplayInformation()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }    
    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();
    }
}