using System;
using System.Collections.Generic;
using System.Text;

namespace InstaGama.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public Genero Genero { get; private set; }

        public string Fotod { get; private set; }



    }
}
