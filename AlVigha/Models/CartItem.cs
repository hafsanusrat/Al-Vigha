﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlVigha.Models
{
    public class CartItem
    {
        public Menu menuItem { get; set; }
        public Cart cartItem { get; set; }

    }
}