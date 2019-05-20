using InjecaoDep.Interfaces;
using InjecaoDep.Services;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDep.Controllers
{
        public class OperationsController : Controller
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _singletonInstanceOperation;

        public OperationsController(OperationService operationService,
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

        public IActionResult Index()
        {
            // viewbag contains controller-requested services
            ViewBag.Transient = _transientOperation.OperationId;
            ViewBag.Scoped = _scopedOperation.OperationId;
            ViewBag.Singleton = _singletonOperation.OperationId;
            ViewBag.SingletonInstance = _singletonInstanceOperation.OperationId;

            // operation service has its own requested services
            ViewBag.ServiceTransient = _operationService.TransientOperation.OperationId;
            ViewBag.ServiceScoped = _operationService.ScopedOperation.OperationId;
            ViewBag.ServiceSingleTon = _operationService.SingletonOperation.OperationId;
            ViewBag.ServiceSingletonInstanceOperation = _operationService.SingletonInstanceOperation.OperationId;
            return View();
        }
    }
        
}