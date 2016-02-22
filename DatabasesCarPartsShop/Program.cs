using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesCarPartsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car()
                {
                    Brand = "BMW",
                    Model = "3 series",
                    ProductionYear = "2015"
                };
            CarPartsShopEntities db = new CarPartsShopEntities();
            db.Cars.Add(bmw);
            db.SaveChanges();

        }
    }
}
