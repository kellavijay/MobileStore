using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Models;
using MobileStore.ViewModels;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository )
        {
            _repository = repository;
        }

        [Route("")]       
        [Route("Home")]
        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel
            {
                Title = "Mobiles and only Mobiles",
                Mobiles = _repository.GetAllMobiles().OrderByDescending(x => x.Price).ToList()
            };

            return View(viewModel);
        }
           
            
        }
       
    }

    
