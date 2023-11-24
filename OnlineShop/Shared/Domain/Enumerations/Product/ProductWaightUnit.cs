using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Shared.Domain.Enumerations.Product
{
    public enum ProductWeightUnit:byte
    {
        None = 0,
        Gram = 1,
        KilloGram = 2,
        Ton = 3,
    }
}
