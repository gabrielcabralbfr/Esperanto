using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.SharedKernel.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime DateOcurred { get; }
    }
}
