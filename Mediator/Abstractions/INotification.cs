using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Abstractions
{
    
    public interface INotification
    {
        
    }

    public interface INotification<TResponse> : INotification
    {
        
    }

}