using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangfireJob.Jobs
{
    public interface IJob
    {
        string JobName { get; }
        void Init();
        bool Run();
    }
}
