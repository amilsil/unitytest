using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using UnityTest.Objects;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = UnityConfig.RegisterComponents();
            var lockObject = new object();

            Action resolveOnce = () =>
            {
                lock (lockObject)
                {
                    Console.WriteLine("Creating all on Thread {0}", Thread.CurrentThread.ManagedThreadId);
                    //container.Resolve<IObjectForTransient>();
                    //container.Resolve<IObjectForContainerControlled>();
                    //container.Resolve<IObjectForExternallyControlled>();
                    //container.Resolve<IObjectForPerResolve>();
                    //container.Resolve<IObjectForPerThread>();
                    container.Resolve<ICandidateService>();
                    Console.WriteLine();
                }
            };

            Console.WriteLine("MAIN THREAD");
            resolveOnce();
            resolveOnce();

            Console.WriteLine("TASK RUN");
            Task.Run(resolveOnce);
            Task.Run(resolveOnce);

            Console.Read();
        }
    }
}
