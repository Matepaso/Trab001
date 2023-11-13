using Microsoft.EntityFrameworkCore;
using Trab001.Models;

namespace Trab001.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ContextoUsuario _context;

        public UsuarioRepositorio(ContextoUsuario context)
        {
            this._context = context;
        }

        public Usuario Adicionar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorLogin(string login)
        {
            return _context.usuarios.FirstOrDefault(x => x.Email.ToUpper() == login.ToUpper());
        }

        public List<Usuario> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
