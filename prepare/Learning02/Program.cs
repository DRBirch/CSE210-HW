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


        Job manager = new Job();
        manager._company = "Apple";
        manager._jobTitle = "Manager";
        manager._startYear = 2022;
        manager._endYear = 2023;


        Resume myResume = new Resume();
        myResume._jobs.Add(programmer);
        myResume._jobs.Add(manager);
        myResume._name = "Allsion Rose";

        myResume.DisplayResume();

    } 
}