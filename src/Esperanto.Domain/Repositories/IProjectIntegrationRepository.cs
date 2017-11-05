using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Repositories
{
    public interface IProjectIntegrationRepository
    {
        /// <summary>
        /// Método para criar ProjectIntegration
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration a ser criado</param>
        void Create(ProjectIntegration projectIntegration);

        /// <summary>
        /// Método para atualizar ProjectIntegration
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration a ser atualizado</param>
        void Update(ProjectIntegration projectIntegration);

        /// <summary>
        /// Método para remover ProjectIntegration
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration a ser atualizado</param>
        void Delete(ProjectIntegration projectIntegration);

        /// <summary>
        /// Método para buscar todos os ProjectIntegration
        /// </summary>
        /// <returns>Retorna todos os ProjectIntegration criados</returns>
        List<ProjectIntegration> Get();

        /// <summary>
        /// Método para buscar ProjectIntegrations, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de ProjectIntegration a ser desconsiderado</param>
        /// <param name="take">Quantidade de ProjectIntegration que deseja obter</param>
        /// <returns>Retorna List de ProjectIntegration</returns>
        List<ProjectIntegration> Get(int skip, int take);

        /// <summary>
        /// Método para verificar se a Integração do Projeto deve ser executada
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration que a integração vai executar</param>
        /// <returns>Retorna true caso a integração deva ser executada</returns>
        bool CheckExecuteIntegration(ProjectIntegration projectIntegration);

        /// <summary>
        /// Método para executar a Integração do Projeto
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration que a integração vai executar</param>
        /// <returns>Retorna true caso a integração tenha sido executada com sucesso</returns>
        bool ExecuteIntegration(ProjectIntegration projectIntegration);
    }
}
