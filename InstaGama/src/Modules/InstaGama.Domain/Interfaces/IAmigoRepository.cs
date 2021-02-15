
using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface IAmigoRepository
    {
        Task<int> InsertAsync(Amigo inputAmigo);
        Task<List<Amigo>> GetListaAmigoByUsuarioIdAsync(int usuarioId);
    }
}
