
using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<int> InserirAsync(Usuario  usuario);

        Task<Usuario> GetByLoginAsync(string login);

        Task<Usuario> GetById(int id);
    }
}
