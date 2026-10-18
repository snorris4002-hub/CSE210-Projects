using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Re-stocker";
        job1._company = "Hobby lobby";
        job1._startYr = 2025;
        job1._endYr = 2026;

        Job job2 = new Job();
        job2._jobtitle = "Janitor";
        job2._company = "VABVI";
        job2._startYr = 2019;
        job2._endYr = 2023;

        Job job3 = new Job();
        job3._jobtitle = "Cashier";
        job3._company = "Price Chopper";
        job3._startYr = 2022;
        job3._endYr = 2023;

        Record myResume = new Record();
        myResume._name = "Samuel Norris";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}