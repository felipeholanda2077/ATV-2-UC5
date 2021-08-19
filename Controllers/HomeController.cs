using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV2_UC5.Models;
using ATIVIDADE_1;

namespace ATV2_UC5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Cadastro(ItemPedido itemForm)
        {
            Dados.PedidoAtual.IncluirItem(itemForm);
           return View();
        }

        public IActionResult Listagem()
        {
           List<ItemPedido> pedido = Dados.PedidoAtual.ListaPedido();
           return View(pedido);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
