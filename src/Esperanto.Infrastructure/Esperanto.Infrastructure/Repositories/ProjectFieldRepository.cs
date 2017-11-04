using Esperanto.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.Context;
using System.Data.Entity;

namespace Esperanto.Infrastructure.Repositories
{
    public class ProjectFieldRepository : IProjectFieldRepository
    {
        #region Properties

        private StoreDataContext _context { get; set; }

        #endregion

        #region Constructor

        public ProjectFieldRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método para criar ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser criado</param>
        public void Create(ProjectField projectField)
        {
            _context.ProjectFields.Add(projectField);
        }

        /// <summary>
        /// Método para atualizar ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser atualizado</param>
        public void Update(ProjectField projectField)
        {
            _context.Entry(projectField).State = EntityState.Modified;
        }

        /// <summary>
        /// Método para remover ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser atualizado</param>
        public void Delete(ProjectField projectField)
        {
            _context.ProjectFields.Remove(projectField);
        }

        /// <summary>
        /// Método para buscar todos os ProjectField
        /// </summary>
        /// <returns>Retorna todos os ProjectField criados</returns>
        public List<ProjectField> Get()
        {
            return _context.ProjectFields.ToList();
        }

        /// <summary>
        /// Método para buscar ProjectFields, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de ProjectField a ser desconsiderado</param>
        /// <param name="take">Quantidade de ProjectField que deseja obter</param>
        /// <returns>Retorna List de ProjectField</returns>
        public List<ProjectField> Get(int skip, int take)
        {
            return _context.ProjectFields
                           .Skip(skip)
                           .Take(take)
                           .ToList();
        }

        #endregion
    }
}
