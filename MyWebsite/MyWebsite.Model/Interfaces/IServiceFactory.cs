﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Interfaces
{
    public interface IServiceFactory
    {
        IGolfService GetGolfService();
    }
}
