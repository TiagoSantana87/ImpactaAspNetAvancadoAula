﻿using Loja.Mvc.Helpers;
using Loja.Repositorios.SqlServer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Loja.Mvc.Areas.Vendas.Controllers
{
    public class LeiloesController : Controller
    {
        private LojaDbContext _db = new LojaDbContext();

        // GET: Vendas/Leiloes
        public ActionResult Index()
        {
            return View(Mapeamento.Mapear(_db.Produtos.Where(p => p.EmLeilao).ToList()));
        }
    }
}