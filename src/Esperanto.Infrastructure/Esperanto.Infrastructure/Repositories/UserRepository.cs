using Esperanto.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.Context;

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

        public User Authenticate(string email, string password)
        {
            
        }

        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public List<User> Get(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public List<User> GetActives()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAdminUsers()
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid userID)
        {
            throw new NotImplementedException();
        }

        public List<User> GetClientUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetCollaboratorUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetInactives()
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
