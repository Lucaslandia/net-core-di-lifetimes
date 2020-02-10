using System;

namespace App.Models
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        public Guid Guid { get; set; }
        
        public Operation() => Guid = Guid.NewGuid();

        public Operation(Guid guid) => Guid = guid;

        public Guid GetCurrentID() => Guid;
    }
}