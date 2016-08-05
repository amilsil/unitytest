using Microsoft.Practices.Unity;
using UnityTest.Objects;

namespace UnityTest
{
    public class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer()
                .RegisterType<IObjectForTransient, ObjectForTransient>(new TransientLifetimeManager())
                .RegisterType<IObjectForContainerControlled, ObjectForContainerControlled>(new ContainerControlledLifetimeManager())
                .RegisterType<IObjectForExternallyControlled, ObjectForExternallyControlled>(new ExternallyControlledLifetimeManager())
                .RegisterType<IObjectForPerResolve, ObjectForPerResolve>(new PerResolveLifetimeManager())
                .RegisterType<IObjectForPerThread, ObjectForPerThread>(new PerThreadLifetimeManager())

                .RegisterType<ICandidate, Candidate>()
                .RegisterType<ICandidateService, CandidateService>();

            return container;
        }
    }
}
