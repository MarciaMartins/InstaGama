using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Entities
{
    public class Genero
    {
        public Genero(string descricao)
        {
            Descricao = descricao;
        }

        public int Id { get; private set; }

        public string Descricao { get; private set; }

        //Verificando se é diferente de branco ou nulo
        public bool seValido()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(Descricao))
            {
                //Se nulo, retorna falso
                valido = false;
            }

            return valido;
        }

    }
}
