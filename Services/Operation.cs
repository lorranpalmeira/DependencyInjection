using System;
using InjecaoDep.Interfaces;

namespace InjecaoDep.Services
{
           
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {       
        public Operation(Guid OperationIdObj)
        {
            this.OperationId = OperationIdObj;
        }

        public Operation()
        {
            this.OperationId = Guid.NewGuid();
        }
        public Guid OperationId {get;}
    }
}