using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Repositories
{
    public interface IProjectFieldRepository
    {
        /// <summary>
        /// Método para criar ProjectField
        /// </summary>
        /// <param name="projectField"></param>
        void Create(ProjectField projectField);

        /// <summary>
        /// Método para atualizar ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser atualizado</param>
        void Update(ProjectField projectField);

        /// <summary>
        /// Método para remover ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser atualizado</param>
        void Delete(ProjectField projectField);

        /// <summary>
        /// Método para buscar todos os ProjectField
        /// </summary>
        /// <returns>Retorna todos os ProjectField criados</returns>
        List<ProjectField> Get();

        /// <summary>
        /// Método para buscar ProjectFields, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de ProjectField a ser desconsiderado</param>
        /// <param name="take">Quantidade de ProjectField que deseja obter</param>
        /// <returns>Retorna List de ProjectField</returns>
        List<ProjectField> Get(int skip, int take);

    }
}
