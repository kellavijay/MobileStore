using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MobileStore.Models
{
    public class Mobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TinyDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbUrl { get; set; }
        public bool IsMobileOfTheDay { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ProductRelaseDate { get; set; }
    }
}
