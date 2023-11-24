﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Shared.Domain.Entities.Base
{
    public record BaseEntity<TKey>
    {
        public TKey Id { get; set;}
        public string Title { get; set;}
        public bool IsActive { get; set; }
    }
}
