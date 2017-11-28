using Esperanto.Domain.ExternalServices;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Esperanto.Api.Controllers
{
    public class WebServiceController : BaseController
    {
        private readonly IWebServices _service;

        public WebServiceController(IWebServices service)
        {
            this._service = service;
        }

        [HttpPost]
        [Route("api/services/insert_update")]
        public Task<HttpResponseMessage> InsertUpdate([FromBody]dynamic body)
        {

            _service.InsertUpdate(
                licenseId: (string)body.licenseId,
                permissionId: (string)body.permissionId,
                 xmlData: body.xml_data.ToObject<List<dynamic>>()

                );


            return CreateResponse(HttpStatusCode.OK, null);
        }
    }
}
