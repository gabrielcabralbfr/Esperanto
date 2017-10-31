using Esperanto.Domain.Entities;
using Esperanto.Domain.Enums.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Specs
{
    public class ProjectSpecs
    {
        #region Methods

        /// <summary>
        /// Método para ordenação por nome
        /// </summary>
        /// <returns>Retorna uma expressão para ordenação dos projetos pelo nome</returns>
        public static Expression<Func<Project, string>> OrderByDefault()
        {
            return p => p.Name;
        }

        /// <summary>
        /// Método para buscar um Projeto pelo ID
        /// </summary>
        /// <param name="projectId">ID a ser buscado</param>
        /// <returns>Retorna uma Expression de consulta por ID</returns>
        public static Expression<Func<Project, bool>> GetById(Guid projectId)
        {
            return p => p.ProjectId.Equals(projectId);
        }

        /// <summary>
        /// Método para obter Projetos ativos
        /// </summary>
        /// <returns>Retorna uma Expression para buscar projetos ativos</returns>
        public static Expression<Func<Project, bool>> GetActives()
        {
            return p => p.ProjectStatus.Equals(EProjectStatus.Active);
        }

        /// <summary>
        /// Método para obter Projetos inativos
        /// </summary>
        /// <returns>Retorna uma Expression para buscar projetos inativos</returns>
        public static Expression<Func<Project, bool>> GetInactives()
        {
            return p => p.ProjectStatus.Equals(EProjectStatus.Inactive);
        }

        /// <summary>
        /// Método para obter Projetos com SendType = MANUAL
        /// </summary>
        /// <returns>Retorna uma Expression para buscar projetos SendType = MANUAL</returns>
        public static Expression<Func<Project, bool>> GetManualSendType()
        {
            return p => p.ProjectStatus.Equals(ESendType.Manual);
        }

        /// <summary>
        /// Método para buscar todos os projetos com SendType = FTP
        /// </summary>
        /// <returns>Retorna uma Expression de Project com SendType = FTP</returns>
        public static Expression<Func<Project, bool>> GetFTPSendType()
        {
            return p => p.ProjectStatus.Equals(ESendType.FTP);
        }


        /// <summary>
        /// Método para buscar todos os projetos com SendType = API
        /// </summary>
        /// <returns>Retorna uma Expression de Project com SendType = API</returns>
        public static Expression<Func<Project, bool>> GetAPISendType()
        {
            return p => p.ProjectStatus.Equals(ESendType.API);
        }

        /// <summary>
        /// Método para buscar Projects com o e-mail informado
        /// </summary>
        /// <param name="email">email a ser buscado</param>
        /// <returns>Retorna uma Expression de Project com o campo ErrorEmail informado</returns>
        public static Expression<Func<Project, bool>> GetByErrorEmail(String email)
        {
            return p => p.ErrorEmail.Equals(email);
        }

        /// <summary>
        /// Método para buscar Projects de algum determinado LicenseId
        /// </summary>
        /// <param name="licenseId">Código da Licença a ser buscado</param>
        /// <returns>Retorna uma Expression de Projects que possuem o LicenseID informado</returns>
        public static Expression<Func<Project, bool>> GetByLicenseId(Guid licenseId)
        {
            return p => p.LicenseId.Equals(licenseId);
        }

        /// <summary>
        /// Método para buscar Projects de algum determinado permissionId
        /// </summary>
        /// <param name="permissionId">Código da Base Cadastral a ser buscado</param>
        /// <returns>Retorna uma Expression de Projects que possuem o permissionId informado</returns>
        public static Expression<Func<Project, bool>> GetByPermissionId(Guid permissionId)
        {
            return p => p.PermissionId.Equals(permissionId);
        }

        #endregion
    }
}
