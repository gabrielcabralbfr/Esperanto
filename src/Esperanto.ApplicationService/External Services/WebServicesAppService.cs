using Esperanto.Domain.ExternalServices;
using External_Services;

namespace Esperanto.ApplicationService.External_Services
{
    public class WebServicesAppService : IWebServices
    {
        public void IsertUpdate(string licenseId, string permissionId, string xmlData)
        {
            WebServices.InsertUpdate(licenseId, permissionId, xmlData);
        }
    }
}
