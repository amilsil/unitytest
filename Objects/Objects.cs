using System;

namespace UnityTest.Objects
{
    public interface IObjectForTransient { }
    public interface IObjectForContainerControlled { }
    public interface IObjectForExternallyControlled { }
    public interface IObjectForPerResolve { }
    public interface IObjectForPerThread { }

    public class ObjectForTransient : IObjectForTransient
    {
        public ObjectForTransient()
        {
            Console.WriteLine("Creating instance of {0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
        }
    }

    public class ObjectForContainerControlled : IObjectForContainerControlled
    {
        public ObjectForContainerControlled()
        {
            Console.WriteLine("Creating instance of {0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
        }
    }

    public class ObjectForExternallyControlled : IObjectForExternallyControlled
    {
        public ObjectForExternallyControlled()
        {
            Console.WriteLine("Creating instance of {0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
        }
    }

    public class ObjectForPerResolve : IObjectForPerResolve
    {
        public ObjectForPerResolve()
        {
            Console.WriteLine("Creating instance of {0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
        }
    }

    public class ObjectForPerThread : IObjectForPerThread
    {
        public ObjectForPerThread()
        {
            Console.WriteLine("Creating instance of {0}", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
        }
    }
}
