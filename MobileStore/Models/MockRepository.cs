using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
    public class MockRepository : IRepository
    {
        private List<Mobile> _mobiles;
        public MockRepository()
        {
            if (_mobiles == null)
            {
                InitializeRepository();
            }

        }

        private void InitializeRepository()
        {
            _mobiles = new List<Mobile> {new Mobile{Id=1,Name="RedMiPro5",Price=6000,TinyDescription="HD Camera,LED display", FullDescription="Mobile Store is one of the most trusted RedMiPro5 repair specialists in the UK. We offer RedMiPro5 screen repair, RedMiPro5 battery replacement, iPhone 7 liquid damage repair and RedMiPro5 camera repair at your convenience. Feel free to wait with us in-store while we repair your Phone in less than 30 minutes or leave your device and come back later to collect it at one of our stores located nationwide.",IsMobileOfTheDay=false,ImageUrl="\\Images\\Redmi.jpg" },
                new Mobile{Id=2,Name="RedMiPro7",Price=16000,TinyDescription="Mobile Store is one of the most trusted RedMiPro7 repair specialists in the UK. We offer iPhone 7 screen repair, iPhone 7 battery replacement, iPhone 7 liquid damage repair and iPhone 7 camera repair at your convenience. Feel free to wait with us in-store while we repair your iPhone in less than 30 minutes or leave your  device and come back later to collect it at one of our stores located nationwide.", FullDescription="HD Camera,LED displayHD Camera,LED displayHD Camera,LED display",IsMobileOfTheDay=false,ImageUrl="\\Images\\Redmi1.jpg" },
                new Mobile{Id=3,Name="IPhone7",Price=60000,TinyDescription="Mobile Store is one of the most trusted iPhone 7 repair specialists in the UK. We offer iPhone 7 screen repair, iPhone 7 battery replacement, iPhone 7 liquid damage repair and iPhone 7 camera repair at your convenience. Feel free to wait with us in-store while we repair your iPhone in less than 30 minutes or leave your  device and come back later to collect it at one of our stores located nationwide.", FullDescription="HD Camera,LED displayHD Camera,LED displayHD Camera,LED display",IsMobileOfTheDay=false,ImageUrl="\\Images\\Iphone.jpg" },
                new Mobile{Id=4,Name="OnePlus3T",Price=30000,TinyDescription="HD Camera,LED display", FullDescription="Mobile Store is one of the most trusted OnePlus3T repair specialists in the UK. We offer OnePlus3T screen repair, OnePlus3T battery replacement, OnePlus3T liquid damage repair and iPhone 7 camera repair at your convenience. Feel free to wait with us in-store while we repair your Phone in less than 30 minutes or leave your Apple device and come back later to collect it at one of our stores located nationwide.",IsMobileOfTheDay=false,ImageUrl="\\Images\\OnePlus.jpg" },
            };
        }

        public IEnumerable<Mobile> GetAllMobiles()
        {
            return _mobiles;
        }

        public Mobile GetMobileById(int id)
        {
            return _mobiles.FirstOrDefault(x => x.Id == id);
        }

        public Mobile Add(Mobile mobile)
        {
            mobile.Id = _mobiles.Max(e => e.Id) + 1;
            _mobiles.Add(mobile);
            return mobile;
        }

        public Mobile Update(Mobile mobilechanges)
        {
            Mobile umobile = _mobiles.FirstOrDefault(e => e.Id == mobilechanges.Id);
            if (umobile != null)
            {
                umobile.Name = mobilechanges.Name;
                umobile.Price = mobilechanges.Price;
                umobile.TinyDescription = mobilechanges.TinyDescription;
                umobile.IsMobileOfTheDay = mobilechanges.IsMobileOfTheDay;
                umobile.FullDescription = mobilechanges.FullDescription;
                umobile.ImageUrl = mobilechanges.ImageUrl;
                umobile.ImageThumbUrl = mobilechanges.ImageThumbUrl;
            }
            return umobile;
        }

            public Mobile Delete(int id)
        {
            Mobile dmobile = _mobiles.FirstOrDefault(e => e.Id == id);
            if (dmobile != null)
            {
                _mobiles.Remove(dmobile);
            }
            return dmobile;
        }
    }
}
