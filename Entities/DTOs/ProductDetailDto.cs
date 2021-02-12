﻿using Core.Entities;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CateogryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
