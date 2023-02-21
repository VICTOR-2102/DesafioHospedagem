using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHospedagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
    }
}
