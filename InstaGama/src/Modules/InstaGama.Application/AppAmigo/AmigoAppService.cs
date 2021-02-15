using InstaGama.Application.AppAmigo.Input;
using InstaGama.Application.AppAmigo.Interfaces;
using InstaGama.Application.AppAmigo.Output;
using InstaGama.Domain.Entities;
using InstaGama.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InstaGama.Application.AppAmigos
{
    public class AmigoAppService : IAmigoAppService
    {
        //preciso verificar se o id do usuario e do amigo existe? questionar
        private readonly IUsuarioRepository _usuarioRespository;
        private readonly IAmigoRepository _amigoRespository;

        public AmigoAppService(IUsuarioRepository usuarioRepository,
             IAmigoRepository amigoRespository)
        {
            _usuarioRespository = usuarioRepository;
            _amigoRespository = amigoRespository;
        }

        public async Task<List<Amigo>> GetListaAmigoByUsuarioIdAsync(int usuarioId)
        {
            var amigos = await _amigoRespository
                              .GetListaAmigoByUsuarioIdAsync(usuarioId)
                              .ConfigureAwait(false);

            return amigos;
        }

        public async Task<AmigoViewModel> InsertAsync(AmigoInput inputAmigo)
        {
            //validar se os usuário existem utilizando a pesquisa por IdUsuario

            var amigo = new Amigo(inputAmigo.UsuarioId,
                                  inputAmigo.UsuarioAmigoId);

            //mensagem de retornos

            var id = await _amigoRespository
                                .InsertAsync(amigo)
                                .ConfigureAwait(false);

            return new AmigoViewModel()
            {
                UsuarioId = amigo.UsuarioId,
                UsuarioAmigoId = amigo.UsuarioAmigoId
                //incluir o retorno do nome após GetByIdUsuario
            };
        }
    }
    
}
