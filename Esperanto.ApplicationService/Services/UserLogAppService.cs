using System;
using System.Collections.Generic;
using Esperanto.Domain.Commands.UserLogCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    public class UserLogAppService : ApplicationService, IUserLogAppService
    {
        #region Properties

        private IUserLogRepository _repository;

        #endregion

        #region Constructor
        public UserLogAppService(IUnitOfWork unitOfWork, IUserLogRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }
        #endregion

        #region Methods

        public UserLog Create(CreateUserLogCommand command)
        {
            var userLog = new UserLog(command);

            userLog.CreateUserlog(userLog);

            _repository.Create(userLog);

            if (Commit())
            {
                return userLog;
            }

            return null;
        }

        public List<UserLog> Get()
        {
            return _repository.Get();
        }

        public List<UserLog> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        #endregion





    }
}
