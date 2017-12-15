using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorAniversario.ViewModels
{
    public class PessoaVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Nascimento { get; set; }
        public char Genero { get; set; }
    }
}