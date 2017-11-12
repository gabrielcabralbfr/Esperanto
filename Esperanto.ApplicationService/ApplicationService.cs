using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.SharedKernel;
using Esperanto.SharedKernel.Events;

namespace Esperanto.ApplicationService
{
    public class ApplicationService
    {
        #region Properties

        private IUnitOfWork _unitOfWork;

        private IHandler<DomainNotification> _notifications;

        #endregion

        #region Constructor

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            _unitOfWork = unitOfWork;
        }

        #endregion
        

        #region Methods

        public bool Commit()
        {
            if (_notifications.HasNotifications())
            {
                return false;
            }

            _unitOfWork.Commit();
            return true;
        }

        #endregion
    }
}
