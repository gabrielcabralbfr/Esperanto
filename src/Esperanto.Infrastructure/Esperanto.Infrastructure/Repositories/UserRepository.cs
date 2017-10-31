using Esperanto.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.Context;
using Esperanto.Domain.Specs;

namespace Esperanto.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        #region Properties

        /// <summary>
        /// Contexto da aplicação
        /// </summary>
        private StoreDataContext _context;

        #endregion


        #region Constructor

        /// <summary>
        /// Construtor do repositório do usuário
        /// </summary>
        /// <param name="context">contexto da aplicação</param>
        public UserRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Implementação do método para autenticar o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário a ser autenticado</param>
        /// <param name="password">senha do usuário a ser autenticado</param>
        /// <returns></returns>
        public User Authenticate(string email, string password)
        {
            return _context.Users
                           .FirstOrDefault(UserSpecs.AuthenticateUser(email, password));
        }

        /// <summary>
        /// Método para criar um usuário no contexto
        /// </summary>
        /// <param name="user">usuário a ser autenticado</param>
        public void Create(User user)
        {
            _context.Users.Add(user);
        }

        /// <summary>
        /// Método para atualizar um usuário
        /// </summary>
        /// <param name="user">Usuário a ser atualizado</param>
        public void Update(User user)
        {
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }


        /// <summary>
        /// Método para remover um usuário do contexto
        /// </summary>
        /// <param name="user">usuário a ser removido</param>
        public void Delete(User user)
        {
            _context.Users.Remove(user);
        }

        /// <summary>
        /// Método para obter todos os usuários
        /// </summary>
        /// <returns>retorna todos os usuários</returns>
        public List<User> Get()
        {
            return _context.Users
                           .ToList();
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
            return _context.Users
                           .OrderBy(UserSpecs.OrderByDefault())
                           .Skip(skip)
                           .Take(take)
                           .ToList();
        }

        /// <summary>
        /// Método para obter usuários ativos
        /// </summary>
        /// <returns>retorna apenas usuários ativos</returns>
        public List<User> GetActives()
        {
            return _context.Users
                           .Where(UserSpecs.GetActives())
                           .OrderBy(UserSpecs.OrderByDefault())           
                           .ToList();
        }

        /// <summary>
        /// Método para obter usuários inativos
        /// </summary>
        /// <returns></returns>
        public List<User> GetInactives()
        {
            return _context.Users
                           .Where(UserSpecs.GetInactives())
                           .OrderBy(UserSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Admin
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Admin</returns>
        public List<User> GetAdmins()
        {
            return _context.Users
                           .Where(UserSpecs.GetAdmins())
                           .OrderBy(UserSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Client
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Client</returns>
        public List<User> GetClients()
        {
            return _context.Users
                           .Where(UserSpecs.GetClients())
                           .OrderBy(UserSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Collaborator
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Collaborator</returns>
        public List<User> GetCollaborators()
        {
            return _context.Users
                           .Where(UserSpecs.GetCollaborators())
                           .OrderBy(UserSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar usuário pelo email
        /// </summary>
        /// <param name="email">email do usuário a ser buscado</param>
        /// <returns>Retorna um User que possui o email informado</returns>
        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(UserSpecs.GetByEmail(email));
        }


        /// <summary>
        /// Método para buscar usuário pelo ID
        /// </summary>
        /// <param name="userID">ID do usuário a ser buscado</param>
        /// <returns>Retorna um User que possui o ID informado</returns>
        public User GetById(Guid userID)
        {
            return _context.Users.FirstOrDefault(UserSpecs.GetById(userID));
        }

        #endregion
    }
}
