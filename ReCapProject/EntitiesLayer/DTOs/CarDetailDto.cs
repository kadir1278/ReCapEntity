using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.DTOs
{
    public class CarDetailDto:IDto
    {
        public string CarDescription { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
    }
}
