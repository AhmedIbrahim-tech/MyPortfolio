using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;

        public IUnitOfWork<PortfolioItem> _Portfolio { get; }

        public HomeController(IUnitOfWork<Owner> owner , IUnitOfWork<PortfolioItem> Portfolio)
        {
            _owner = owner;
            _Portfolio = Portfolio;
        }
        public IActionResult Index()
        {
            var homeviewmodel = new HomeViewModel
            {
                Owner = _owner.Entity.Find().First(),
                PortfolioItems = _Portfolio.Entity.Find().ToList()
            };
            return View(homeviewmodel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
