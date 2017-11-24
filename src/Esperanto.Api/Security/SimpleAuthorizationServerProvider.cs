using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Enums.User;
using Esperanto.Domain.Services;
using Microsoft.Owin.Security.OAuth;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace Esperanto.Api.Security
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private readonly Container _container;

        public SimpleAuthorizationServerProvider(Container container)
        {
            _container = container;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //Trabalhar com os CORS
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            dynamic user;

            using (_container.BeginExecutionContextScope())
            {
                var _userService = _container.GetInstance<IUserAppService>();

                var authenticateCommand = new AuthenticateUserCommand(context.UserName, context.Password);

                user = _userService.Authenticate(authenticateCommand);

                if (user == null)
                {
                    context.SetError("invalid_grant", "Usuário ou senha inválidos");
                    return;
                }
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            identity.AddClaim(new Claim(ClaimTypes.Name, user.Email));
            identity.AddClaim(new Claim(ClaimTypes.Role, user.UserRole.ToString()));

            GenericPrincipal principal = new GenericPrincipal(identity, new string[] { user.UserRole == EUserRole.Admin ? "admin" : "" });

            Thread.CurrentPrincipal = principal;

            context.Validated(identity);
        }
    }
}