using GerenciadorAniversario.Infra.Business;
using GerenciadorAniversario.Infra.Models;
using GerenciadorAniversario.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorAniversario.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            PessoaBusiness instanciaPessoaBusiness = new PessoaBusiness();
            List<Pessoa> retornaListaBusiness = instanciaPessoaBusiness.retornoListDal();
            List<PessoaVM> listaPessoaVM = new List<PessoaVM>();

            foreach (Pessoa p in retornaListaBusiness)
                listaPessoaVM.Add(new PessoaVM()
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Sobrenome = p.Sobrenome,
                    Genero = p.Genero
                });
            return View();
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaVM model)
        {
            try
            {
                PessoaBusiness business = new PessoaBusiness();

                Pessoa pessoa = new Pessoa()
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Sobrenome = model.Sobrenome,
                    Genero = model.Genero
                };

                business.Adicionar(pessoa);
                return RedirectToAction("Index");
            } catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
