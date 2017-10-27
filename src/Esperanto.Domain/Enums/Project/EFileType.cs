using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Enums.Project
{
    public enum EFileType
    {
        /// <summary>
        /// Arquivo CSV separado por tabulações
        /// </summary>
        CsvWithTabs = 1,

        /// <summary>
        /// Arquivo CSV separado por ponto-e-vírgula
        /// </summary>
        CsvWithSemiColon = 2,

        /// <summary>
        /// Arquivo TXT separado por tabulações
        /// </summary>
        TxtWithTabs = 3,

        /// <summary>
        /// Arquivo TXT separado por caracter personalizado
        /// </summary>
        TxtCustom = 4
    }
}
