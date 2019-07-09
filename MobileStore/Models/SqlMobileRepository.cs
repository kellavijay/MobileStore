using System.Collections.Generic;

namespace MobileStore.Models
{
    public class SqlMobileRepository : IRepository
    {
        private readonly AppDbContext context;

        public SqlMobileRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public Mobile Add(Mobile mobile)
        {
            context.Mobiles.Add(mobile);
            context.SaveChanges();
            return mobile;
        }

        public Mobile Delete(int id)
        {
            Mobile mobile = context.Mobiles.Find(id);
            if (mobile != null)
            {
                context.Mobiles.Remove(mobile);
                context.SaveChanges();
            }
            return mobile;
        }

        public IEnumerable<Mobile> GetAllMobiles()
        {
            return context.Mobiles;
        }

        public Mobile GetMobileById(int id)
        {
            return context.Mobiles.Find(id);
        }

        public Mobile Update(Mobile mobilechanges)
        {
            var mobile = context.Mobiles.Attach(mobilechanges);
            mobile.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return mobilechanges;
        }
    }
}