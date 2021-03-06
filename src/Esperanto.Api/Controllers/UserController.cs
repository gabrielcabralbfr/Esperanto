﻿using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Enums.User;
using Esperanto.Domain.Services;
using External_Services;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Services;

namespace Esperanto.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserAppService _service;

        public UserController(IUserAppService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/users")]
        public Task<HttpResponseMessage> Get()
        {
            var users = _service.Get();

            return CreateResponse(HttpStatusCode.OK, users);
        }

        [HttpPost]
        [Route("api/users/new")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateUserCommand(
                    email: (string)body.email,
                    password: (string)body.password,
                    name: (string)body.name,
                    userRole: (EUserRole)body.userRole
                );

            var user = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, user);
        }

        [HttpPost]
        [Route("api/users/delete")]
        public Task<HttpResponseMessage> DeleteUser([FromBody]dynamic body)
        {
            var command = new DeleteUserCommand(
                    userId: (Guid)body.userId

                );

            var user = _service.Delete(command.UserId);

            return CreateResponse(HttpStatusCode.OK, user);
        }


        [HttpGet]
        [Route("api/user/name")]
        [Authorize(Roles = "Admin")]
        public string Authenticate()
        {
            return User.Identity.Name;
        }
    }
}