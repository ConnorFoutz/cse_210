using System;

class Program1
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._company = "BYUI";
       job1._jobTitle = "Math Tutor";
       job1._startYear = "2026";
       job1._endYear = "2026";

       Job job2 = new Job();
       job2._company = "Temple Square Hospitality";
       job2._jobTitle = "Expo Chef";
       job2._startYear = "2025";
       job2._endYear = "2026";

       //job1.DisplayJob();

       Resume myResume = new Resume();
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);
       myResume._name = "Connor";

       myResume.PrintResume();

    }
}