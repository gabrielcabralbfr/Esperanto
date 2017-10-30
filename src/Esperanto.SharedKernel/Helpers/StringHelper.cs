using System.Security.Cryptography;
using System.Text;

namespace Esperanto.SharedKernel.Helpers
{
    public static class StringHelper
    {
        public static string Encrypt(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "";

            //Criar um salt
            value += "|F5C1BE42-6B5A-4692-B5CE-76FD2BB8B9AA";

            MD5 md5 = MD5.Create();

            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(value));

            StringBuilder sbString = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sbString.Append(data[i].ToString("x2"));
            }

            return sbString.ToString();
        }
    }
}
