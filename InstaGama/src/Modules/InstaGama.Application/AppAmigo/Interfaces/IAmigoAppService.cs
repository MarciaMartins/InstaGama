using InstaGama.Application.AppAmigo.Input;
using InstaGama.Application.AppAmigo.Output;
using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Application.AppAmigo.Interfaces
{
    public interface IAmigoAppService
    {
        Task<AmigoViewModel> InsertAsync(AmigoInput amigo);
        Task<List<Amigo>> GetListaAmigoByUsuarioIdAsync(int usuarioId);
    }
}
