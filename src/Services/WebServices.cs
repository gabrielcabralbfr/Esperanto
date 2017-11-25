using Services.QuestManagerWebService;


namespace Services
{
    public class WebServices
    {
        string license_id = "936068e1-c0e2-42a2-8639-8d220d25da81";
        string permission_id = "332b8702-0280-4820-aa00-f56c8696de79";
        string xml_data = "";

        public string Insert_update()
        {

            //questmanager_webserviceSoapClient webservice = new questmanager_webserviceSoapClient.qm_insert_update(license_id, permission_id, xml_data);

            questmanager_webserviceSoapClient WebService = new questmanager_webserviceSoapClient();

            WebService.qm_insert_update(license_id, permission_id, xml_data);

            return "";

        }

        



    }


}
