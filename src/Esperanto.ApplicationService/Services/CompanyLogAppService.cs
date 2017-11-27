using System.Collections.Generic;
using Esperanto.Domain.Commands.CompanyLogCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    /// <summary>
    /// Aplicação de Serviço para os Logs de Company
    /// </summary>
    public class CompanyLogAppService : ApplicationService, ICompanyLogAppService
    {

        #region Properties

        /// <summary>
        /// Repositório dos Logs de Usuário
        /// </summary>
        private ICompanyLogRepository _repository;

        #endregion


        #region Constructor

        /// <summary>
        /// Método construtor da Aplicação de Serviço de Logs de Company
        /// </summary>
        /// <param name="unitOfWork">Unit Of Work</param>
        /// <param name="repository">Repositório dos Logs de Company</param>
        public CompanyLogAppService(IUnitOfWork unitOfWork, ICompanyLogRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criação de um Log de Company realizando as validações de escopo
        /// </summary>
        /// <param name="command">Comando de criação do Log de Company</param>
        /// <returns>Retorna o Log criado</returns>
        public CompanyLog Create(CreateCompanyLogCommand command)
        {
            var companyLog = new CompanyLog(command);

            companyLog.CreateCompanyLog(companyLog);

            _repository.Create(companyLog);

            if (Commit())
            {
                return companyLog;
            }

            return null;
        }

        /// <summary>
        /// Método para obter todos Logs de Company
        /// </summary>
        /// <returns>Retorna uma Lista de Logs de Company</returns>
        public List<CompanyLog> Get()
        {
            return _repository.Get();
        }

        /// <summary>
        /// Método para obter uma Lista de Logs de Company ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Logs de Company a serem desconsiderados</param>
        /// <param name="take">Quantidade de Logs de Company a serem obtidos</param>
        /// <returns>Retorna uma Lista de Logs de Company</returns>
        public List<CompanyLog> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        #endregion
    }
}
