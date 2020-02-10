namespace App.Services
{
    public class OperationService
    {
        public IOperationTransient TransientOperation { get; set; }
        public IOperationScoped ScopedOperation { get; set; }
        public IOperationSingleton SingletonOperation { get; set; }
        public IOperationSingletonInstance SingletonInstanceOperation { get; set; }

        public OperationService(IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance instanceOperation)
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            SingletonInstanceOperation = instanceOperation;
        }
    }
}