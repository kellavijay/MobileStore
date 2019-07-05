using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Models;
using MobileStore.ViewModels;

namespace MobileStore.Controllers
{
    public class ProductController : Controller
    {
     
        private readonly IRepository _repository;
        private readonly IHostingEnvironment hostingenvironment;

        public ProductController(IRepository repository,IHostingEnvironment ehostingenvironment)
        {
            this.hostingenvironment = ehostingenvironment;
            _repository = repository;
        }

        [Route("productdetails/{id}")]
        public IActionResult productdetails(int id)
        {
            ProductViewModel viewModel = new ProductViewModel
            {
                _mobileobj = _repository.GetMobileById(id)
            };
            return View(viewModel);
        }

        [HttpGet]
        [Route("editproductdetails/{id}")]
        public IActionResult editproductdetails(int id)
        {
            ProductViewModel viewModel = new ProductViewModel
            {
                _mobileobj = _repository.GetMobileById(id)
            };
            return View(viewModel);
        }


        [HttpPost]
        [Route("editproductdetails/{id}")]
        public IActionResult editproductdetails(int id, ProductViewModel input)
        {
            if (ModelState.IsValid)
            {
                string uniqufilename = null;
                if(input.Photo !=null)
                {
                   string uploadsfolder= Path.Combine(hostingenvironment.WebRootPath, "images");
                    uniqufilename= Guid.NewGuid().ToString() + "_" + input.Photo.FileName;
                    string filepath = Path.Combine(uploadsfolder, uniqufilename);
                    input.Photo.CopyTo(new FileStream(filepath, FileMode.Create));
                }

                Mobile updatemobile = new Mobile()
                {
                    Id=id,
                    Name = input._mobileobj.Name,
                    Price = input._mobileobj.Price,
                    TinyDescription = input._mobileobj.TinyDescription,
                    FullDescription = input._mobileobj.FullDescription,
                    ImageUrl = uniqufilename

                };
                _repository.Update(updatemobile);
            }
            return RedirectToAction("productdetails");
        }
    }
}