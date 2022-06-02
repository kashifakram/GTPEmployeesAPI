using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Repository.Interfaces;

namespace Employee.Repository
{
    public class Operation : IOperation, IOperationScoped, IOperationSingleton, IOperationSingletonInstance, IOperationTransient
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid guid)
        {
            OperationId = guid;
        }

        public Guid OperationId { get; }
    }
}
