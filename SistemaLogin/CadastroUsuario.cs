
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Ramon", Senha = "7692"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string Nome, string Senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == Nome && usuario.Senha == Senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
