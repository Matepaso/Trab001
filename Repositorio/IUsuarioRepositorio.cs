using Trab001.Models;

namespace Trab001.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarPorLogin (string login);
        List<Usuario> BuscarTodos();
        Usuario BuscarPorId(int id);
        Usuario Adicionar(Usuario usuario);
        Usuario Atualizar(Usuario usuario);
        bool apagar (int id);
    }
}
