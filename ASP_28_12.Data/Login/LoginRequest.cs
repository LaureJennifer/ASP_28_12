﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Application.Login
{
    public class LoginRequest
    {
         public string UserName { get; set;}
         public string Password { get; set;}
        //public bool RememberMe { get; set; }
    }
}
