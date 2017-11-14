using Esperanto.Domain.Services;
using System;
using System.Collections.Generic;
using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    /// <summary>
    /// Aplicação de Serviços do Usuário
    /// </summary>
    public class UserAppService : ApplicationService, IUserAppService
    {

        #region Properties

        /// <summary>
        /// Repositório o usuário
        /// </summary>
        private IUserRepository _repository;

        #endregion


        #region Constructor

        /// <summary>
        /// Construtor da Application Service do Usuário
        /// </summary>
        /// <param name="unitOfWork">Unit Of Work</param>
        /// <param name="repository">Repositório do usuário</param>
        public UserAppService(IUnitOfWork unitOfWork, IUserRepository repository) : base(unitOfWork)
        {
            _repository = repository;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para autenticar o usuário
        /// </summary>
        /// <param name="command">Comando de autenticação do usuário</param>
        /// <returns>Retorna o usuário autenticado</returns>
        public User Authenticate(AuthenticateUserCommand command)
        {
            var user = _repository.GetById(command.UserId);

            user.AuthenticateUser(command.Email, command.Password);

            return _repository.Authenticate(command.Email, command.Password);
        }

        /// <summary>
        /// Método para criar um usuário, verificando se há notificações no Domínio
        /// </summary>
        /// <param name="command">Comando de criação do usuário</param>
        /// <returns>Retorna o usuário criado</returns>
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

        /// <summary>
        /// Método para remover um usuário
        /// </summary>
        /// <param name="userId">Guid do usuário a ser removido</param>
        /// <returns>Retorna o usuário a ser removido</returns>
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

        /// <summary>
        /// Método para obter todos os usuários do repositório
        /// </summary>
        /// <returns>Retorna uma lita de usuários</returns>
        public List<User> Get()
        {
            return _repository.Get();
        }

        /// <summary>
        /// Método para atualizar um usuário no repositório, verificando se há notificações no Domínio
        /// </summary>
        /// <param name="command">Comando de atualização do usuário</param>
        /// <returns>Retorna o usuário atualizado caso não haja notificações no Domínio</returns>
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
