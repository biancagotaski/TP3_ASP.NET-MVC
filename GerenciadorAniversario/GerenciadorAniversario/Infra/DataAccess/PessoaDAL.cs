using GerenciadorAniversario.Infra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorAniversario.Infra.DataAccess
{
    public class PessoaDAL
    {
        static List<Pessoa> pessoas = new List<Pessoa>();

        public List<Pessoa> ListarDados()
        {
            List<Pessoa> copiaLista = new List<Pessoa>();
            copiaLista.AddRange(pessoas);

            return copiaLista;
        }

        public void Adicionar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }


    }
}