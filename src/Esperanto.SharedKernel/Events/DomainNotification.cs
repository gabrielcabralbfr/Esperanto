using Esperanto.SharedKernel.Events.Contracts;
using System;

namespace Esperanto.SharedKernel.Events
{
    public class DomainNotification : IDomainEvent
    {
        public DomainNotification(string key, string value)
        {
            Key = key;
            Value = value;
            DateOcurred = DateTime.Now;
        }

        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DateOcurred { get; private set; }


    }
}
