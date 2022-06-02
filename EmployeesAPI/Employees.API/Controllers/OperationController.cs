using System.Text;
using Employee.Repository.Interfaces;
using Employee.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _operationTransient;
        private readonly IOperationScoped _operationScoped;
        private readonly IOperationSingleton _operationSingleton;
        private readonly IOperationSingletonInstance _operationSingletonInstance;

        public OperationController(OperationService operationService,
            IOperationTransient operationTransient,
            IOperationScoped operationScoped,
            IOperationSingleton operationSingleton,
            IOperationSingletonInstance operationSingletonInstance
            )
        {
            _operationService = operationService;
            _operationTransient = operationTransient;
            _operationScoped = operationScoped;
            _operationSingleton = operationSingleton;
            _operationSingletonInstance = operationSingletonInstance;
        }

        [HttpGet]
        [Route("")]
        public string GetOperationGuid()
        {
            var result = new StringBuilder();

            result.AppendLine($"Transient: {_operationTransient.OperationId}");
            result.AppendLine($"Scoped: {_operationScoped.OperationId}");
            result.AppendLine($"Singleton: {_operationSingleton.OperationId}");
            result.AppendLine($"Singleton Instance: {_operationSingletonInstance.OperationId}");
            result.AppendLine();
            result.AppendLine();
            result.AppendLine($"Operation Service Transient: {_operationService.TransientOperation.OperationId}");
            result.AppendLine($"Operation Service Scoped: {_operationService.ScopedOperation.OperationId}");
            result.AppendLine($"Operation Service Singleton: {_operationService.SingletonOperation.OperationId}");
            result.AppendLine($"Operation Service Singleton Instance: {_operationService.SingletonInstanceOperation.OperationId}");

            return result.ToString();
        }
    }
}
