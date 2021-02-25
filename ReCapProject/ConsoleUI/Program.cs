using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManagerMetot();
        }

        private static void CarManagerMetot()
        {
            CarManager _carManager = new CarManager(new EfCarDal());
            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
