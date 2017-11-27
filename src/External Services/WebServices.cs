using External_Services.QuestManagerWebService;

namespace External_Services
{
    public static class WebServices
    {


        public static void InsertUpdate(string licenseId, string permissionId, string xmlData)
        {
            questmanager_webservice _webserice = new questmanager_webservice();


            _webserice.qm_insert_update(licenseId, permissionId, xmlData);
        }

    }
}
