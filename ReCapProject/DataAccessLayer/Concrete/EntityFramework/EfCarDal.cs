using CoreLayer.DataAccess;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.Id
                             join cr in context.Color
                             on c.ColorId equals cr.Id
                             select new CarDetailDto { BrandName = b.Name, CarDescription = c.Description, ColorName = cr.Name };
                return result.ToList();
            }
        }
    }
}
