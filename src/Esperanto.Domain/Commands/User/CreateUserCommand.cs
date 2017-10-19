using Esperanto.Domain.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Commands.User
{
    class CreateUserCommand
    {
        public CreateUserCommand(string email, string password, string name, EUserRole userRole)
        {
            this.Email = email;
            this.Password = password;
            this.Name = name;
            this.UserRole = userRole;
            
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public EUserRole UserRole { get; set; }
    }
}
