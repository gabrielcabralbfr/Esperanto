using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.ExternalServices
{
    public interface IWebServices
    {
        void InsertUpdate(string licenseId, string permissionId, string xmlData);

    }
}
