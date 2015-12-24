

namespace HelloWebJob
{
    using System;

    using Microsoft.Azure.WebJobs;

    /// <summary>
    /// Web job class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Hello WOB JOBS .... this is changed!!");
            Console.ReadLine();
            var host = new JobHost();

            // The following code ensures that the WebJob will be running continuously
            host.RunAndBlock();
        }
    }
}
