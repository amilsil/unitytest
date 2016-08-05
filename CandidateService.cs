using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityTest.Objects;

namespace UnityTest
{
    public interface ICandidateService { }

    public class CandidateService : ICandidateService
    {
        private readonly ICandidate _candidate;
        private readonly IObjectForContainerControlled _containerControlled;
        private readonly IObjectForTransient _forTransient;
        private readonly IObjectForExternallyControlled _externallyControlled;
        private readonly IObjectForPerResolve _perResolve;
        private readonly IObjectForPerThread _perThread;

        public CandidateService(
            IObjectForContainerControlled containerControlled, 
            IObjectForTransient forTransient, 
            IObjectForExternallyControlled externallyControlled, 
            IObjectForPerResolve perResolve, 
            IObjectForPerThread perThread, 
            ICandidate candidate)
        {
            _containerControlled = containerControlled;
            _forTransient = forTransient;
            _externallyControlled = externallyControlled;
            _perResolve = perResolve;
            _perThread = perThread;
            _candidate = candidate;
        }
    }
}
