using System.Collections.Generic;
using Esperanto.Domain.Commands.CompanyCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;
using System;

namespace Esperanto.ApplicationService.Services
{
    /// <summary>
    /// Aplicação de servico para a Entidade Company
    /// </summary>
    public class CompanyAppService : ApplicationService, ICompanyAppService
    {
        #region Properties

        /// <summary>
        /// Repositório de Company
        /// </summary>
        private ICompanyRepository _repository;

        #endregion


        #region Constructor

        /// <summary>
        /// Construtor da aplicação de serviço da Entidade Company
        /// </summary>
        /// <param name="unitOfWork">Unit Of Work</param>
        /// <param name="repository">Repositório de Company</param>
        public CompanyAppService(IUnitOfWork unitOfWork, ICompanyRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para realizar a criação de uma Company fazendo as verificações de escopo
        /// </summary>
        /// <param name="command">Comando de criação de Company</param>
        /// <returns>Retorna a Company criada ou null caso haja notificações no domínio</returns>
        public Company Create(CreateCompanyCommand command)
        {
            var company = new Company(command);

            company.CreateCompany(company);

            _repository.Create(company);

            if (Commit())
            {
                return company;
            }

            return null;
        }

        /// <summary>
        /// Método para remover uma Company
        /// </summary>
        /// <param name="command">Comando de remoção da Company</param>
        /// <returns>Retorna a Company removida</returns>
        public Company Delete(DeleteCompanyCommand command)
        {
            var company = _repository.GetById(command.CompanyId);

            _repository.Delete(company);

            if (Commit())
            {
                return company;
            }

            return null;
        }

        /// <summary>
        /// Método para obter todas as Companies do banco
        /// </summary>
        /// <returns>Retorna uma Lista de Company</returns>
        public List<Company> Get()
        {
            return _repository.Get();
        }

        /// <summary>
        /// Método para obter uma Lista de Company ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Company a serem desconsiderados</param>
        /// <param name="take">Quantidade de Company a serem obtidos</param>
        /// <returns>Retorna uma Lista de Company</returns>
        public List<Company> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }



        #endregion
    }
}
