﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ShoppingCart
    {
        public int Id { get; set; } 
        //public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }   
        public double SubTotal { get; set; }   
       
    }
}