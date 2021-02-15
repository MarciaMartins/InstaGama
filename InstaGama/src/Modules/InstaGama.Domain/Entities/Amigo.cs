using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Entities
{
    public class Amigo
    {
        public Amigo(UsuarioId usuarioId, UsuarioAmigoId usuarioAmigoId){
            UsuarioId=usuarioId;
            UsuarioAmigoId=usuarioAmigoId;
        }
       
        public int Id { get; private set; }
	    public UsuarioId UsuarioId { get; private set; }
	    public UsuarioAmigoId UsuarioAmigoId { get; private set; }
    
        
        public void SetId(int id)
        {
            Id = id;
        }    
    }    
}
