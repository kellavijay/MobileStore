using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mobile>().HasData(

              new Mobile { Id = 102, Name = "RedmiGO", Price = 4500, TinyDescription = "Smart Mobile Under Budget" },
                new Mobile { Id = 103, Name = "RedmiNote5Pro", Price = 11500, TinyDescription = "Smart Mobile Under Best Suited for taking pictures" },
                  new Mobile { Id = 104, Name = "RedmiNote7Pro", Price = 15500, TinyDescription = "Smart Mobile With 48 Mega Pixel camera" }

              );


            modelBuilder.Entity<Users>().HasData(

            new Users {uId=1,uName="Vijay Kumar", MobileNumber=9030718891, uEmail="kellavijay@gmail.com",userType="Admin"  },
              new Users { uId = 2, uName = "Ajay Kumar", MobileNumber = 9030715591, uEmail = "ajay@gmail.com", userType = "Customer" },
               new Users { uId = 3, uName = "Prasad", MobileNumber = 9030717791, uEmail = "prasad@gmail.com", userType = "Customer" }

           );
        }
    }
}
