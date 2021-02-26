﻿using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
