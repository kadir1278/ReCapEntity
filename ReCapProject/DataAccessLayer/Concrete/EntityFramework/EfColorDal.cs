﻿using CoreLayer.DataAccess;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfColorDal:EfEntityRepositoryBase<Color,ReCapProjectContext>,IColorDal
    {
    }
}
