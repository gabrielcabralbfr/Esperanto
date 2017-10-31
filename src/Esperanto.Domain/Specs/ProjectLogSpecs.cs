using Esperanto.Domain.Entities;
using System;
using System.Linq.Expressions;


namespace Esperanto.Domain.Specs
{
    public class ProjectLogSpecs
    {
        /// <summary>
        /// Método para ordenação dos Logs de Projeto por data de criação
        /// </summary>
        /// <returns>Retorna uma Expression para ordenação por data de criação</returns>
        public static Expression<Func<ProjectLog, DateTime>> OrderByDefault()
        {
            return pl => pl.CreatedOn;
        }

        /// <summary>
        /// Método para buscar um ProjectLog por ID
        /// </summary>
        /// <param name="projectLogId">ID do ProjectLog a ser buscado</param>
        /// <returns>Retorna true caso encontre um ProjectLog com o ID informado</returns>
        public static Expression<Func<ProjectLog, bool>> GetById(Guid projectLogId)
        {
            return pl => pl.ProjectLogId.Equals(projectLogId);
        }
    }
}
