using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorAniversario.Infra.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nascimento { get; set; }
        public char Genero { get; set; }
    }
}