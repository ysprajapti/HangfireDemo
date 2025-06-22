// See https://aka.ms/new-console-template for more information
using Hangfire;
using Hangfire.MemoryStorage;
using HangfireDemo;

Console.WriteLine("Let's Understand a Hangfire");

//1) Install Hangfier frong NUget
//dotnet add package Hangfire
//dotnet add package Hangfire.MemoryStorage

// 1. Configure Hangfire with In-Memory storage (or use SQL Server, etc.)
GlobalConfiguration.Configuration.UseMemoryStorage();

HangfierExample hangfierExample = new HangfierExample();
ThreadExample threadExample = new ThreadExample();

// 2. Start Hangfire server
using (var server = new BackgroundJobServer())
{
    //Console.WriteLine("Hangfire Server started...");

    //// 3. Fire-and-forget job
    //BackgroundJob.Enqueue(() => hangfierExample.PrintMessage("Fire-and-forget job"));

    //// 4. Delayed job
    //BackgroundJob.Schedule(() => hangfierExample.PrintMessage("Delayed job (5s later)"), TimeSpan.FromSeconds(5));

    //// 5. Recurring job (every minute)
    //RecurringJob.AddOrUpdate("recurring", () => hangfierExample.PrintMessage("Recurring job"), Cron.Minutely);

    //// Keep the app running
    //Console.WriteLine("Press Enter to exit...");
    //Console.ReadLine();


    //Thread Example
    Console.WriteLine("Main thread started.");

    Thread t1 = new Thread(() => threadExample.PrintMessage("Thread job"));
    t1.Start();

    Console.WriteLine("Press Enter to exit...");
    Console.ReadLine();
}
