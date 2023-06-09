﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ShoppingOrder
    {
        public int Id { get; set; }
        
        //public int UserId { get; set; }
        
        public DateTime Date { get; set; }
       
        public string Address { get; set; }    
        public string? PaymentMethod { get ; set; }
        public double Total { get; set; }   
    }
}

