using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityTest.Objects;

namespace UnityTest
{
    public class Candidate : ICandidate
    {
        private readonly IObjectForContainerControlled _containerControlled;
        private readonly IObjectForTransient _forTransient;
        private readonly IObjectForExternallyControlled _externallyControlled;
        private readonly IObjectForPerResolve _perResolve;
        private readonly IObjectForPerThread _perThread;

        public Candidate(IObjectForContainerControlled containerControlled, IObjectForTransient forTransient, IObjectForExternallyControlled externallyControlled, IObjectForPerResolve perResolve, IObjectForPerThread perThread)
        {
            _containerControlled = containerControlled;
            _forTransient = forTransient;
            _externallyControlled = externallyControlled;
            _perResolve = perResolve;
            _perThread = perThread;
        }
    }
}
