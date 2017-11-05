
namespace Esperanto.Domain.Enums.User
{
    public enum EUserRole
    {
        /// <summary>
        /// Usuário administrador
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Usuário cliente (externo)
        /// </summary>
        Client = 2,

        /// <summary>
        /// Usuário colaborador (interno)
        /// </summary>
        Collaborator = 3
    }
}
