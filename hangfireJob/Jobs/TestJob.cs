using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace hangfireJob.Jobs
{
    public class TestJob : IJob
    {
        public string JobName => TestJob.JobId;
        public static string JobId => "Test Job Name.";
        public TestJob()
        {
        }
        public bool Run()
        {
            try
            {
                SendInvoiceMail("defaultName");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

       public void Init()
        {
            RecurringJob.AddOrUpdate(JobId,() => Run(), Cron.Minutely);
        //    BackgroundJob.ContinueJobWith(JobId, () => Run());
        } 

        public void SendInvoiceMail(string userName)
        {
            //Logic to Mail the user
            Console.WriteLine($"Here is your invoice, {userName}");
        }


    }

}
