using System.Collections.Generic;
using Esperanto.Domain.ExternalServices;
using External_Services;

namespace Esperanto.ApplicationService.External_Services
{
    public class WebServicesAppService : IWebServices
    {

        public void InsertUpdate(string licenseId, string permissionId, List<dynamic> xmlData)
        {
            string xml_data = "<?xml version='1.0' encoding='utf-8'?><table>";

            

            foreach(var item in xmlData)
            {
                var id = item.id;
                var name = item.name;

                xml_data += "<row><col index='id'>" + id + "</col>";
                xml_data += "<col index='nome'>" + name + "</col></row>";
            }

            xml_data += "</table>";

            WebServices.InsertUpdate(licenseId, permissionId, xml_data);
        }
    }
}
