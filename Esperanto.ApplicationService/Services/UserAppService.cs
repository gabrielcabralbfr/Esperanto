using Esperanto.Domain.Services;
using System;
using System.Collections.Generic;
using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;
using Esperanto.Domain.Enums.User;
using Esperanto.ApplicationService.QMWS;

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
        /// Método para obter uma Lista de Users ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de usuários que serão desconsiderados</param>
        /// <param name="take">Quantidade de usuários que serão considerados</param>
        /// <returns>Retorna List<User> - Quantidade de usuários informada, excluindo quantos usuários foram informados</returns>
        public List<User> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        /// <summary>
        /// Método para buscar os usuários ativos
        /// </summary>
        /// <returns>Retorna List<User> dos usuários com status ativo </returns>
        public List<User> GetActives()
        {
            return _repository.GetActives();
        }

        /// <summary>
        /// Método para buscar os usuários inativos
        /// </summary>
        /// <returns>Retorna List<User> dos usuários com status inativo </returns>
        public List<User> GetInactives()
        {
            return _repository.GetInactives();
        }


        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Admin
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Admin</returns>
        public List<User> GetAdmins()
        {
            return _repository.GetAdmins();
        }


        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Client
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Client</returns>
        public List<User> GetClients()
        {
            return _repository.GetClients();
        }

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Collaborator
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Collaborator</returns>
        public List<User> GetCollaborators()
        {
            return _repository.GetCollaborators();
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

        /// <summary>
        /// Método para tornar um usuário ativo
        /// </summary>
        /// <param name="user">Usuário a ser ativado</param>
        /// <returns>Retorna true caso o usuário tenha sido ativado</returns>
        public bool ActivateUser(User user)
        {
            if (user.UserStatus.Equals(EUserStatus.Active))
            {
                return false;
            }

            user.ActivateUser();

            _repository.Update(user);

            return true;
        }

        /// <summary>
        /// Método para tornar um usuário inativo
        /// </summary>
        /// <param name="user">Usuário a ser desativado</param>
        /// <returns>Retorna true caso o usuário tenha sido desativado</returns>
        public bool DeactivateUser(User user)
        {
            if (user.UserStatus.Equals(EUserStatus.Inactive))
            {
                return false;
            }

            user.DeactivateUser();

            _repository.Update(user);

            return true;
        }

        #endregion
    }
}
