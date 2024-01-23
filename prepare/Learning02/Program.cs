using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 1993;
        job1._endYear = 2004;

        Job job2 = new Job();
        job2._jobTitle = "Nanny";
        job2._company = "Walmart";
        job2._startYear = 2016;
        job2._endYear = 2017;

        Resume resume1 = new Resume();
        resume1._name = "Allison Rode";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}