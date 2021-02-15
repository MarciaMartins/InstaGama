using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Entities
{
    public class Amigo
    {
        public Amigo(int usuarioId, int usuarioAmigoId){
            UsuarioId=usuarioId;
            UsuarioAmigoId=usuarioAmigoId;
        }

        
        public int Id { get; private set; }
	    public int UsuarioId { get; private set; }
	    public int UsuarioAmigoId { get; private set; }
    
        
        public void SetId(int id)
        {
            Id = id;
        }

        public bool IsValid(int UsuarioAmigoId)
        {
            if (UsuarioAmigoId == null)
            {
                return false;
            }
            else return true;
        }

     }
}
