using Services.QuestManagerWebService;


namespace Services
{
    public class WebServices
    {
        public string LicenseId { get; set; }

        public string PermissionId { get; set; }

        public string xml_data { get; set; }


        public void Insert_update(string LicenseId, string PermissionId, string xml_data)
        {

            questmanager_webserviceSoapClient WebService = new questmanager_webserviceSoapClient();

            WebService.qm_insert_update(LicenseId, PermissionId, xml_data);
        }

        



    }


}
