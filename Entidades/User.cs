﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class User
    {
        public int Id { get; set; }    
        public string Name { get; set; }   
        public string Email { get; set; }  
        
        //public string Password { get; set; }
        //public string Address { get; set; } //= default!;
       
    }
}
