using Microsoft.AspNetCore.Http;
using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.ViewModels
{
    public class ProductViewModel
    {
        public string Title { get; set; }
        public Mobile _mobileobj { get; set; }
        public IFormFile Photo { get; set; }
    }
}
