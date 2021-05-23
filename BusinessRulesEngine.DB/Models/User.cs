﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DB.Models
{
    /// <summary>
    /// DB Entity Class
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserCity { get; set; }
    }
}