﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject
{
    internal interface IDigitalProductModal : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
