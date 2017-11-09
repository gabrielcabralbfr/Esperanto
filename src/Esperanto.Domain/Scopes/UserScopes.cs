using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class UserScopes
    {
        /// <summary>
        /// Método para fazer as validações do escopo de criação de um usuário
        /// </summary>
        /// <param name="user">Usuário a ser criado</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool CreateUserScopeIsValid(this User user)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertEmailIsValid(user.Email, "O valor especificado precisa ser um e-mail válido."),
                AssertionConcern.AssertGuidIsNotEmpty(user.UserId, "O ID do usuário não pode estar vazio."),
                AssertionConcern.AssertLength(user.Password, 6, 32, "A senha precisa ter um tamanho mínimo de 6 caracteres e no máximo 32."),
                AssertionConcern.AssertLength(user.Name, 3, 20, "O nome de usuário precisa ter no mínimo 3 caracteres e no máximo 20"),
                AssertionConcern.AssertLength(user.Email, 5, 60, "O e-mail de usuário precisa ter no mínimo 5 caracteres e no máximo 60"),
                AssertionConcern.AssertNotEmpty(user.Email, "O e-mail é obrigatório")
            );
        }

        /// <summary>
        /// Método para fazer as validações no escopo de autenticação do usuário
        /// </summary>
        /// <param name="user">Usuário a ser autenticado</param>
        /// <param name="email">E-mail informado na autenticação</param>
        /// <param name="encryptedPassword">Senha criptografada informada na autenticação</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool AuthenticateUserScopeIsValid(this User user, string email, string encryptedPassword)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertAreEquals(user.Email, email, "Usuário ou senha inválido"),
                AssertionConcern.AssertAreEquals(user.Password, encryptedPassword, "Usuário ou senha inválido"),
                AssertionConcern.AssertNotEmpty(email, "O e-mail é obrigatório"),
                AssertionConcern.AssertNotEmpty(encryptedPassword, "A senha é obrigatória"),
                AssertionConcern.AssertEmailIsValid(email, "O e-mail é inválido")
            );
        }

        /// <summary>
        /// Método para fazer as validações no escopo de atualização do usuário
        /// </summary>
        /// <param name="user">Usuário a ser atualizado</param>
        /// <param name="name">Novo valor para o Nome</param>
        /// <param name="email">Novo valor para o E-mail</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool UpdateUserScopeIsValid(this User user, string name, string email)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(name, "O Nome não pode estar vazio."),
                AssertionConcern.AssertLength(name, 3, 20, "O nome de usuário precisa ter no mínimo 3 caracteres e no máximo 20"),
                AssertionConcern.AssertNotEmpty(email, "O Nome não pode estar vazio."),
                AssertionConcern.AssertLength(email, 5, 60, "O e-mail de usuário precisa ter no mínimo 5 caracteres e no máximo 60"),
                AssertionConcern.AssertEmailIsValid(email, "O e-mail é inválido")
            );
        }

        /// <summary>
        /// Método para fazer as validações de troca de senha do usuário
        /// </summary>
        /// <param name="user">Usuário que efetuará a troca de senha</param>
        /// <param name="newPassword">Nova senha a ser armazenada</param>
        /// <returns>Retorna true caso a troca de senha seja bem sucedida</returns>
        public static bool ChangeUserPasswordIsValid(this User user, string newPassword)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertLength(newPassword, 6, 32, "A senha precisa ter um tamanho mínimo de 6 caracteres e no máximo 32."),
                AssertionConcern.AssertNotEmpty(newPassword, "A nova senha não pode ser vazia"),
                AssertionConcern.AssertTrue(user.Password != newPassword, "A nova senha não pode ser igual à senha atual")
            );
        }
    }
}

