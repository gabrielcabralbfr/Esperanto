using System.Collections.Generic;

namespace Esperanto.Domain.ExternalServices
{
    public interface IWebServices
    {
        void InsertUpdate(string licenseId, string permissionId, List<dynamic> xmlData);

    }
}
