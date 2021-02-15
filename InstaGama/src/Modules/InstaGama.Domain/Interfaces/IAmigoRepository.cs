
using InstaGama.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Domain.Interfaces
{
    public interface IAmigoRepository
    {
        Task<int> InsertAsync(Amigo amigo);
        Task<List<Amigo>> GetByAmigoIdAsync(int amigoId);
    }
}
