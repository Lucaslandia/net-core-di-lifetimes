using Microsoft.AspNetCore.Mvc.RazorPages;
using App.Services;

namespace App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;

        public IndexModel(OperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _singletonInstanceOperation = singletonInstanceOperation;

        }

        public void OnGet()
        {
            ViewData["Transient"] = _transientOperation;
            ViewData["Scoped"] = _scopedOperation;
            ViewData["Singleton"] = _singletonOperation;
            ViewData["SingletonInstance"] = _singletonInstanceOperation;

            ViewData["Service"] = _operationService;
        }
    }
}
