using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Repositories
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Método para criar Projects
        /// </summary>
        /// <param name="project"></param>
        void Create(Project project);

        /// <summary>
        /// Método para atualizar Projects
        /// </summary>
        /// <param name="project">Project a ser atualizado</param>
        void Update(Project project);

        /// <summary>
        /// Método para remover Projects
        /// </summary>
        /// <param name="project">Project a ser atualizado</param>
        void Delete(Project project);

        /// <summary>
        /// Método para buscar todos os Projects
        /// </summary>
        /// <returns>Retorna todos os Projects criados</returns>
        List<Company> Get();

        /// <summary>
        /// Método para buscar Projects, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de Projects a ser desconsiderado</param>
        /// <param name="take">Quantidade de Projects que deseja obter</param>
        /// <returns></returns>
        List<Company> Get(int skip, int take);

        /// <summary>
        /// Método para buscar Project por ID
        /// </summary>
        /// <param name="companyId">ID do Projects a ser buscado</param>
        /// <returns>Retorna o Project com o ID informado</returns>
        Company Get(string companyId);
    }
}
