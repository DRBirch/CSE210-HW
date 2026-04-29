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
        programmer.DisplayInformation();
    }
    public class Job
    {
        public string _company;
        public string _jobTitle;
        //public int _startYear;        
        //public int _endYear;

        public void DisplayInformation()
        {
            Console.WriteLine($"Company: {_company} \nJob Title: {_jobTitle}");
        }
    }    
}