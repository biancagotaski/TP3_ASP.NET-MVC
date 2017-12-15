using GerenciadorAniversario.Infra.DataAccess;
using GerenciadorAniversario.Infra.Models;
using System;using System.Collections.Generic;

namespace GerenciadorAniversario.Infra.Business
{
    public class PessoaBusiness
    {
        public List<Pessoa> retornoListDal()
        {
            //metodo que retorna a copia da lista do 'BD', e pra retornar essa lista, eh necessario criar uma nova.
            PessoaDAL pessoinhaDal = new PessoaDAL();
            List<Pessoa> copiaListarDados = pessoinhaDal.ListarDados();

            return copiaListarDados;
        }

        public void Adicionar(Pessoa pessoa)
        {
            PessoaDAL pessoinhaDal = new PessoaDAL();

            pessoinhaDal.Adicionar(pessoa);
        }
    }
}