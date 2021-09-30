using System;
using System.Collections.Generic;

namespace BrechoDomain.Entitys
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
