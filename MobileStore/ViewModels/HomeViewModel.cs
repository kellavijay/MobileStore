using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Mobile> Mobiles { get; set; }
        public Mobile _mobileobj { get; set; }
    }
}
