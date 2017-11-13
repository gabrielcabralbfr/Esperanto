using Esperanto.Domain.Services;
using System;
using System.Collections.Generic;
using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    public class UserAppService : ApplicationService, IUserAppService
    {

        #region Properties

        private IUserRepository _repository;

        #endregion


        #region Constructor

        public UserAppService(IUnitOfWork unitOfWork, IUserRepository repository) : base(unitOfWork)
        {
            _repository = repository;
        }

        #endregion


        #region Methods

        public User Authenticate(AuthenticateUserCommand command)
        {
            var user = _repository.GetById(command.UserId);

            user.AuthenticateUser(command.Email, command.Password);

            return _repository.Authenticate(command.Email, command.Password);
        }

        public User Create(CreateUserCommand command)
        {
            var user = new User(command);

            user.CreateUser(user);

            _repository.Create(user);

            if (Commit())
            {
                return user;
            }

            return null;
        }

        public User Delete(Guid userId)
        {
            var user = _repository.GetById(userId);

            _repository.Delete(user);

            if (Commit())
            {
                return user;
            }

            return null;
        }

        public List<User> Get()
        {
            return _repository.Get();
        }

        public User Update(UpdateUserCommand command)
        {
            var user = _repository.GetById(command.UserId);

            user.UpdateUser(user);
            _repository.Update(user);

            if (Commit())
            {
                return user;
            }

            return null;
        }

        #endregion
    }
}
