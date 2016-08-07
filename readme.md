A Microsoft.Practices.Unity.LifetimeManager that holds onto the instance given to it. When the Microsoft.Practices.Unity.ContainerControlledLifetimeManager is disposed, the instance is disposed with it.

SynchronizedLifetimeManager abstract
	^
	|
ContainerControlledLifetimeManager
	^
	|
ExternallyControlledLifetimeManager
A special lifetime manager which works like Microsoft.Practices.Unity.ContainerControlledLifetimeManager, except that in the presence of child containers, each child gets it's own instance of the object, instead of sharing one in the common parent.


PerResolveLifetimeManager
This is a custom lifetime manager that acts like Microsoft.Practices.Unity.TransientLifetimeManager, but also provides a signal to the default build plan, marking the type so that instances are reused across the build up object graph.

PerThreadLifetimeManager
A Microsoft.Practices.Unity.LifetimeManager that holds the instances given to it, keeping one instance per thread.

MAIN THREAD
Creating all on Thread 8
Creating instance of ObjectForContainerControlled
Creating instance of ObjectForTransient
Creating instance of ObjectForExternallyControlled
Creating instance of ObjectForPerResolve
Creating instance of ObjectForPerThread
Creating instance of ObjectForTransient

Creating all on Thread 8
Creating instance of ObjectForTransient
Creating instance of ObjectForPerResolve
Creating instance of ObjectForTransient

TASK RUN
Creating all on Thread 10
Creating instance of ObjectForTransient
Creating instance of ObjectForPerResolve
Creating instance of ObjectForPerThread
Creating instance of ObjectForTransient

Creating all on Thread 9
Creating instance of ObjectForTransient
Creating instance of ObjectForPerResolve
Creating instance of ObjectForPerThread
Creating instance of ObjectForTransient

