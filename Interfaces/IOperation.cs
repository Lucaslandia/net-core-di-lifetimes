using System;

public interface IOperation
{
    Guid GetCurrentID();
}

public interface IOperationTransient : IOperation { }
public interface IOperationScoped : IOperation { }
public interface IOperationSingleton : IOperation { }
public interface IOperationSingletonInstance : IOperation { }
