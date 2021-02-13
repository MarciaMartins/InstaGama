using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Entities
{
    public class Curtidas
    {
		public Curtidas(int postagemId,
						int usuarioId)
		{
			PostagemId = postagemId;
			UsuarioId = usuarioId;
		}

		public Curtidas(int id,
						int postagemId,
						int usuarioId)
		{
			Id = id;
			PostagemId = postagemId;
			UsuarioId = usuarioId;
		}

		public int Id { get; private set; }
		public int PostagemId { get; private set; }
		public int UsuarioId { get; private set; }
	}


}
