using Esperanto.SharedKernel;
using Esperanto.SharedKernel.Events;
using System.Collections.Generic;


namespace Esperanto.CrossCutting
{
    public class DomainNotificationHandler : IHandler<DomainNotification>
    {
        #region Properties

        private List<DomainNotification> _notifications;

        #endregion


        #region Constructor

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        #endregion


        #region Methods

        public void Dispose()
        {
            _notifications = new List<DomainNotification>();
        }

        public void Handle(DomainNotification args)
        {
            _notifications.Add(args);
        }

        public bool HasNotifications()
        {
            return _notifications.Count > 0;
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValue();
        }

        public List<DomainNotification> GetValue()
        {
            return _notifications;
        }

        #endregion
    }
}
