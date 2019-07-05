using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
   public interface IRepository
    {
        IEnumerable<Mobile> GetAllMobiles();
        Mobile GetMobileById(int id);

        Mobile Add(Mobile mobile);
        Mobile Update(Mobile mobilechanges);
        Mobile Delete(int id);
    }
}
